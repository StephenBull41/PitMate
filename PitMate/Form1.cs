//to do:
//make the settings do stuff
//add an in app explanation for all the settings
//
//update readme on github to reflect new changes


using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Drawing;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PitMate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        //user input readings
        public List<TrackReading> trackReadings = new List<TrackReading>();
        //generated readings calculated from user input
        public List<TrackReading> autoReadings = new List<TrackReading>();
        //setup loaded by the user
        public dynamic setup;
        public string setupPath = null;

        private void CarSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            if (username.Contains("\\")) { username = username.Remove(0, username.LastIndexOf("\\") + 1); }
            f.InitialDirectory = $@"C:\Users\{username}\Documents\Assetto Corsa Competizione\Setups";
            f.ShowDialog();
            if (File.Exists(f.FileName))
            {
                string s = File.ReadAllText(f.FileName);
                setup = JsonConvert.DeserializeObject(s);
                lblCarName.Text = setup.carName;
                lblSetupName.Text = f.FileName.Remove(0, f.FileName.LastIndexOf("\\") + 1);
                setupPath = f.FileName;
            }
            else
            {
                MessageBox.Show("Failed to load setup");
            }
        }

        private void ListReadings()
        {
            trackReadings = trackReadings.GroupBy(x => x.trackTemp).Select(y => y.First()).ToList(); //remove duplicate readings
            trackReadings = trackReadings.OrderBy(x => x.trackTemp).ToList(); //sort list by track temp
            lbxReadings.Items.Clear();
            foreach (TrackReading r in trackReadings)
            {
                lbxReadings.Items.Add(r.trackTemp);
            }
        }

        private void btnAddReading_Click(object sender, EventArgs e)
        {
            btnSetStrats.Enabled = true;
            btnAddReading.Enabled = false;
            TrackReading tr = new TrackReading();
            tr.trackTemp = Convert.ToInt32(udTrackTemp.Value);
            tr.lf = Convert.ToDouble(udLf.Value);
            tr.rf = Convert.ToDouble(udRf.Value);
            tr.lr = Convert.ToDouble(udLr.Value);
            tr.rr = Convert.ToDouble(udRr.Value);

            trackReadings.Add(tr);
            
            ListReadings();           
            generatePressures();
        }

        private void btnUpdateGraph_Click(object sender, EventArgs e)
        {
            //Clear readings
            chtPressures.Series.Clear();
            trackReadings.Clear();
        }

        private void updateGraph()
        {
            chtPressures.Series.Clear();
            chtPressures.Series.Add("LF");
            chtPressures.Series.Add("RF");
            chtPressures.Series.Add("LR");
            chtPressures.Series.Add("RR");
            chtPressures.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chtPressures.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chtPressures.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chtPressures.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            autoReadings = autoReadings.OrderBy(x => x.trackTemp).ToList();
            foreach (TrackReading r in autoReadings)
            {
                chtPressures.Series[0].Points.AddXY(r.trackTemp, r.lf);
                chtPressures.Series[1].Points.AddXY(r.trackTemp, r.rf);
                chtPressures.Series[2].Points.AddXY(r.trackTemp, r.lr);
                chtPressures.Series[3].Points.AddXY(r.trackTemp, r.rr);
            }
        }

        private void generatePressures()
        {
            //remove duplicate temps
            int tMin = Convert.ToInt32(nudTmin.Value);
            int tMax = Convert.ToInt32(nudTmax.Value);

            if (trackReadings.Count > 1)
            {

                //create a temporary list, this will become our main list later
                List<TrackReading> templist = new List<TrackReading>();

                //first extrapolate for readings below the lowest entered reading if needed
                if (trackReadings[0].trackTemp != tMin)
                {
                    
                    double[] delta01 = getDelta(trackReadings[0], trackReadings[1]);
                    for (int i = tMin; i < trackReadings[0].trackTemp; i++)
                    {
                        //if we're here then the lowest temp reading entered is > 21
                        //extrapolate from what data we have to populate readings down to 21c
                        int tyreDelta = trackReadings[0].trackTemp - i;
                        TrackReading tr = new TrackReading();
                        tr.trackTemp = i;
                        //get the expected pressures based on the rate of pressure change of closest known readings 
                        //and the temperature difference from the closest reading
                        //newReading.tyre = reading[0].tyre - (tempdelta * tyreDelta)
                        //minus because we're going down in temp

                        tr.lf = Math.Round(trackReadings[0].lf - (delta01[0] * tyreDelta), 1);
                        tr.rf = Math.Round(trackReadings[0].rf - (delta01[1] * tyreDelta), 1);
                        tr.lr = Math.Round(trackReadings[0].lr - (delta01[2] * tyreDelta), 1);
                        tr.rr = Math.Round(trackReadings[0].rr - (delta01[3] * tyreDelta), 1);
                        templist.Add(tr);
                    }
                }

                //next populate readings within temps provided
                //for each track reading except the last
                
                for (int i = 0; i < trackReadings.Count - 1; i++)
                {
                    //validate we're not working with the final temps & there is a gap between readings
                    if (trackReadings[i].trackTemp < tMax && (trackReadings[i + 1].trackTemp - trackReadings[i].trackTemp) > 1)
                    {
                        double[] delta = getDelta(trackReadings[i], trackReadings[i + 1]);
                        //create a reading for each degree between existing readings
                        for (int j = 0; j < (trackReadings[i + 1].trackTemp - trackReadings[i].trackTemp - 1); j++)
                        {
                            TrackReading tr = new TrackReading();
                            tr.trackTemp = trackReadings[i].trackTemp + j + 1;
                            tr.lf = Math.Round(trackReadings[i].lf + (delta[0] * (j + 1)), 1);
                            tr.rf = Math.Round(trackReadings[i].rf + (delta[1] * (j + 1)), 1);
                            tr.lr = Math.Round(trackReadings[i].lr + (delta[2] * (j + 1)), 1);
                            tr.rr = Math.Round(trackReadings[i].rr + (delta[3] * (j + 1)), 1);
                            templist.Add(tr);
                        }
                    }
                }

                //finaly extrapolate readings beyond the highest reading if that reading is not 42(max)

                if (trackReadings[trackReadings.Count - 1].trackTemp != tMax)
                {
                    double[] delta = getDelta(trackReadings[trackReadings.Count - 2], trackReadings[trackReadings.Count - 1]);
                    int j = 1;
                    for (int i = trackReadings[trackReadings.Count - 1].trackTemp + 1; i < tMax + 1; i++)
                    {
                        TrackReading tr = new TrackReading();
                        tr.trackTemp = i;
                        tr.lf = Math.Round(trackReadings[trackReadings.Count - 1].lf + (delta[0] * j), 1);
                        tr.rf = Math.Round(trackReadings[trackReadings.Count - 1].rf + (delta[1] * j), 1);
                        tr.lr = Math.Round(trackReadings[trackReadings.Count - 1].lr + (delta[2] * j), 1);
                        tr.rr = Math.Round(trackReadings[trackReadings.Count - 1].rr + (delta[3] * j), 1);
                        templist.Add(tr);
                        j++;
                    }
                }

                foreach(TrackReading r in trackReadings)
                {
                    templist.Add(r);
                }

                autoReadings.Clear();
                autoReadings.AddRange(templist);
                updateGraph();
                double[] iMin = { autoReadings.Last().lf, autoReadings.Last().lr, autoReadings.Last().rf, autoReadings.Last().rr };
                double[] iMax = { autoReadings[0].lf, autoReadings[0].lr, autoReadings[0].rf, autoReadings[0].rr };                
                int min = Convert.ToInt32(Math.Floor(iMin.Min()));
                int max = Convert.ToInt32(Math.Ceiling(iMax.Max()));
                //MessageBox.Show($"min is {min} max is {max}");
                chtPressures.ChartAreas[0].AxisY.Minimum = min;
                chtPressures.ChartAreas[0].AxisY.Maximum = max;

                //chtPressures.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(Math.Ceiling())
            }
        }

        private double[] getDelta(TrackReading tr1, TrackReading tr2)
        {
            //find the change in tyre pressure respective to the change in track temperature
            double[] r = { 0, 0, 0, 0 };
            double tempDelta = tr1.trackTemp - tr2.trackTemp;
            r[0] = (tr1.lf - tr2.lf) / tempDelta;
            r[1] = (tr1.rf - tr2.rf) / tempDelta;
            r[2] = (tr1.lr - tr2.lr) / tempDelta;
            r[3] = (tr1.rr - tr2.rr) / tempDelta;
            return r;
        } 

        private void udTrackTemp_ValueChanged(object sender, EventArgs e)
        {
            btnAddReading.Enabled = true;
        }

        private void udLf_ValueChanged(object sender, EventArgs e)
        {
            btnAddReading.Enabled = true;
        }

        private void udRf_ValueChanged(object sender, EventArgs e)
        {
            btnAddReading.Enabled = true;
        }

        private void udLr_ValueChanged(object sender, EventArgs e)
        {
            btnAddReading.Enabled = true;
        }

        private void udRr_ValueChanged(object sender, EventArgs e)
        {
            btnAddReading.Enabled = true;
        }

        private void btnSetStrats_Click(object sender, EventArgs e)
        {
            //So I found out similar to how you can exploit setup values to create out of range values you can do the same with the amount of pit strategies you have
            //the limit of 30 is only imposed by the UI & all we need to do is simply add more into the setup json
            //due to limitations in game & not being able to set setup display names we want to make the setup number correspond with a track temp
            //with ingame temps going slightly over 40c we want to exceed the UI limit of 30 strategies
            //unlike out of range setup changes saving the setup in game will not revert or in this case remove out of range strategies
            //however the user cannot see out of range strategies until they're in the car & have access to the MFD effectively making them read only

            //add strategies until we have enough to deal with the ranges the user wants
            int reqStrats = Convert.ToInt32(nudTmax.Value) - Convert.ToInt32(nudTmin.Value) + Convert.ToInt32(nudOffset.Value);
            if (setup.basicSetup.strategy.pitStrategy.Count < reqStrats)
            {
                int c = setup.basicSetup.strategy.pitStrategy.Count;
                for (int i = c; i <= reqStrats; i++)
                {
                    dynamic a = setup.basicSetup.strategy.pitStrategy[0];
                    setup.basicSetup.strategy.pitStrategy.Add(a);
                }                
            }
            //autoReadings = autoReadings.OrderBy(x => x.trackTemp).ToList();

            int j = Convert.ToInt32(nudOffset.Value); //pit strat offset
            int b = 0;

            //offset
            //a value of 0 for a tyre pressure is 20.3 psi in game
            //every 1 value is 0.1 psi in the game
            int offset = 203;

            foreach (TrackReading r in autoReadings)
            {
                //conver pressure values into setup values
                //don't need to worry about decimals since we rounded to 1 place & we multiply by 10 
                int[] p = {
                    Convert.ToInt32(r.lf * 10) - offset,
                    Convert.ToInt32(r.rf * 10) - offset,
                    Convert.ToInt32(r.lr * 10) - offset,
                    Convert.ToInt32(r.rr * 10) - offset
                };

                //tyre set settings
                int set = 0;
                if (cbxSetTyre.Checked)
                {
                    if (cbxIncTyre.Checked)
                    {
                        set = Convert.ToInt32(nudTyreSet.Value) + b * Convert.ToInt32(nudTyreStep.Value) - 1;
                        setup.basicSetup.strategy.pitStrategy[j].tyreSet = set;
                    }
                    else
                    {
                        setup.basicSetup.strategy.pitStrategy[j].tyreSet = Convert.ToInt32(nudTyreSet.Value) - 1;
                    }                    
                }
                //set the pressures for the strat
                setup.basicSetup.strategy.pitStrategy[j].tyres.tyrePressure[0] = p[0];
                setup.basicSetup.strategy.pitStrategy[j].tyres.tyrePressure[1] = p[1];
                setup.basicSetup.strategy.pitStrategy[j].tyres.tyrePressure[2] = p[2];
                setup.basicSetup.strategy.pitStrategy[j].tyres.tyrePressure[3] = p[3];
                //other strat settings
                setup.basicSetup.strategy.pitStrategy[j].fuelToAdd = Convert.ToInt32(nudFuel.Value);
                setup.basicSetup.strategy.pitStrategy[j].frontBrakePadCompound = Convert.ToInt32(nudPadF.Value) - 1;
                setup.basicSetup.strategy.pitStrategy[j].rearBrakePadCompound = Convert.ToInt32(nudPadR.Value) - 1;

                j++;
                b++;
            }

            if(setupPath == null)
            {
                MessageBox.Show("Cannot set pit strategies with no setup loaded");
            }
            else
            {
                string sourcePath = setupPath.Remove(setupPath.LastIndexOf('\\') + 1);
                string sourceName = setupPath.Remove(0, setupPath.LastIndexOf('\\') + 1);
                string newfilename = "PitMate_" + sourceName;
                string outputPath = sourcePath + newfilename;

                int k = 1;
                while (File.Exists(outputPath) && k < 50)
                {
                    newfilename = "PitMate" + k.ToString() + "_" + sourceName; //for the message box
                    outputPath = sourcePath + newfilename;
                    k++;
                }

                File.WriteAllText(outputPath, JsonConvert.SerializeObject(setup, Formatting.Indented));
                btnSetStrats.ForeColor = Color.Green;
                btnSetStrats.Enabled = false;
                MessageBox.Show($"Created new setup \"{newfilename}\" at:" + Environment.NewLine + sourcePath, "Setup Created");
            }
        }

        private void btnEditReading_Click(object sender, EventArgs e)
        {
            btnSetStrats.Enabled = true;
            if (lbxReadings.SelectedIndex >= 0)
            {
                trackReadings[lbxReadings.SelectedIndex].trackTemp = Convert.ToInt32(udEditTT.Value);
                trackReadings[lbxReadings.SelectedIndex].lf = Convert.ToDouble(udEditLF.Value);
                trackReadings[lbxReadings.SelectedIndex].rf = Convert.ToDouble(udEditRF.Value);
                trackReadings[lbxReadings.SelectedIndex].lr = Convert.ToDouble(udEditLR.Value);
                trackReadings[lbxReadings.SelectedIndex].rr = Convert.ToDouble(udEditRR.Value);
                btnEditReading.ForeColor = Color.Green;
            }

            lbxReadings.ClearSelected();
            udEditTT.Value = 0;
            udEditLF.Value = 0;
            udEditRF.Value = 0;
            udEditLR.Value = 0;
            udEditRR.Value = 0;
            ListReadings();
            generatePressures();
        }

        private void btnRemoveReading_Click(object sender, EventArgs e)
        {
            btnSetStrats.Enabled = true;
            if (lbxReadings.SelectedIndex >= 0)
            {
                trackReadings.RemoveAt(lbxReadings.SelectedIndex);
            }

            lbxReadings.ClearSelected();
            udEditTT.Value = 0;
            udEditLF.Value = 0;
            udEditRF.Value = 0;
            udEditLR.Value = 0;
            udEditRR.Value = 0;
            ListReadings();
            generatePressures();
        }

        private void lbxReadings_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditReading.ForeColor = Color.White;
            btnRemoveReading.ForeColor = Color.White;
            if (lbxReadings.SelectedIndex >= 0)
            {
                udEditTT.Value = trackReadings[lbxReadings.SelectedIndex].trackTemp;
                udEditLF.Value = Convert.ToDecimal(trackReadings[lbxReadings.SelectedIndex].lf);
                udEditRF.Value = Convert.ToDecimal(trackReadings[lbxReadings.SelectedIndex].rf);
                udEditLR.Value = Convert.ToDecimal(trackReadings[lbxReadings.SelectedIndex].lr);
                udEditRR.Value = Convert.ToDecimal(trackReadings[lbxReadings.SelectedIndex].rr);
            }
            
        }

        private void btnExplainSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Strat min & Max: sets the minimum & maximum track temperatures strategies will be created for" + Environment.NewLine +
                "Strat offset: sets what strat number the strats will start at" + Environment.NewLine +
                "Fuel to add: sets a fuel value on every strat" + Environment.NewLine +
                "Front & rear pad: sets the brake pad for each strat" + Environment.NewLine +
                "Set tyre set: sets a tyre set for each strat" + Environment.NewLine +
                "increment tyre set: makes each strat increase the tyre set by the step value so you get a different tyre set for each strat");
        }

        private void nudTmin_ValueChanged(object sender, EventArgs e)
        {
            generatePressures();
            chtPressures.ChartAreas[0].AxisX.Minimum = Convert.ToInt32(nudTmin.Value);
        }

        private void nudTmax_ValueChanged(object sender, EventArgs e)
        {
            generatePressures();
            chtPressures.ChartAreas[0].AxisX.Maximum = Convert.ToInt32(nudTmax.Value);
        }
    }

    public class TrackReading
    {
        public int trackTemp;
        public double lf;
        public double rf;
        public double lr;
        public double rr;
    }

}
