using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

// N Tier C# and SQL Program to Analyze CTA Ridership data
// Mika Cabudol
// U. of Illinois, Chicago
// CS341, Fall2017
// Project #08

namespace CTARidershipAnalysis
{
    public partial class Form1 : Form
    {
        // *********************** MAIN FORM CONSTRUCTORS ********************************
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            top10Panel.Visible = false;
            submitFilter.Enabled = false;
            unFilter.Enabled = false;
            reportADA.Enabled = false;
            if (!testConnection(""))
            {
                // ignore any exception that occurs, goal is just to startup
            }
        }

        // ************************ FUNCTIONALITY *************************
        private bool testConnection(string filename)
        {
            bool isThere = true;
            try
            {
                BusinessTier.Business bizTier = new BusinessTier.Business(filename);
                bizTier.TestConnection();
            }
            catch
            {
                isThere = false;
            }
            return isThere;
        }

        private void resetAllFormData()
        {
            this.avgRidership.Text = "0";
            this.totalRidership.Text = "0";
            this.percentRidership.Text = "0";
            this.weekday.Text = "0";
            this.saturday.Text = "0";
            this.sunday.Text = "0";
            this.stopList.Items.Clear();
            this.handicap.Text = "";
            this.location.Text = "(-0.0000, -0000)";
            this.lineList.Items.Clear();
            this.topTenList.Items.Clear();
            this.handicap.Text = "╳";
            this.reportADA.Enabled = false;
        }

        // *************** EVENT HANDLERS ************************
        // From Load option in the Tool Strip
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // grab custom database; if null, set to default
            if (this.databaseName.Text == "")
            {
                this.databaseName.Text = String.Format("|DataDirectory|\\CTA.mdf");
            }

            if (testConnection(this.databaseName.Text))
                loadFileData();
        }

        // Toggles top 10 visibility
        private void top10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.top10Panel.Visible = true;
        }

        private void backStations_Click(object sender, EventArgs e)
        {
            this.top10Panel.Visible = false;
        }

        // dynamic functions for listbox events
        private void stationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fetch station label
            string selectedStation = this.stationList.Text;
            this.selectedStationLabel.Text = selectedStation;
            selectedStation = selectedStation.Replace("'", "''");
            loadStationDetails(selectedStation);
        }

        private void stopList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fetch station label
            string selectedStop = this.stopList.Text;
            this.selectedStopLabel.Text = selectedStop;
            selectedStop = selectedStop.Replace("'", "''");
            loadStopDetails(selectedStop);
        }

        // ADA change
        private void reportADA_Click(object sender, EventArgs e)
        {
            try
            {
                // determine whether the ADA is updated
                BusinessTier.Business bizTier = new BusinessTier.Business(this.databaseName.Text);
                if (bizTier.updateADA(this.selectedStopLabel.Text, (this.adaChange.SelectedIndex - 1)))
                {
                    this.loadStopDetails(this.selectedStopLabel.Text); // update ada display in Form1
                    MessageBox.Show("ADA for " + this.selectedStopLabel.Text + " updated!");
                }
                else
                {
                    MessageBox.Show("ADA for " + this.selectedStopLabel.Text + " unchanged.");
                }
            }
            catch (Exception ex)
            {
                string msg = string.Format("New ADA Error: '{0}'.", ex.Message);
                MessageBox.Show(msg);
            }
        }

        // filter events
        private void submitFilter_Click(object sender, EventArgs e)
        {
            this.stationList.Items.Clear();
            this.stationList.Refresh();
            loadStations(this.filter.Text);
        }

        private void unFilter_Click(object sender, EventArgs e)
        {
            this.stationList.Items.Clear();
            this.stationList.Refresh();
            loadStations("");
        }

        // **************** ALL DATA FETCH FUNCTIONS ***************
        private void loadFileData()
        {
            this.stationList.Items.Clear();
            this.stationList.Refresh();
            this.topTenList.Items.Clear();
            this.topTenList.Refresh();
            top10Panel.Visible = false; // resets display in case top10 is visible

            try
            {
                loadStations("");

                // loads the top 10
                BusinessTier.Business bizTier = new BusinessTier.Business(this.databaseName.Text);
                int rank = 0;
                var top10 = bizTier.GetTopStations(10);
                foreach (var ten in top10)
                {
                    rank++;
                    this.topTenList.Items.Add("[" + rank + "] " + ten.Name);
                }

                this.unFilter.Enabled = true;
                this.submitFilter.Enabled = true;
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error: '{0}'.", ex.Message);
                MessageBox.Show(msg);
            }
        }

        private void loadStations(string filter)
        {
            // loads stations
            BusinessTier.Business bizTier = new BusinessTier.Business(this.databaseName.Text);
            this.noStations.Text = Convert.ToString(bizTier.GetTotalStationCount()); // get station count
            this.noFilteredStationsLabel.Text = Convert.ToString(bizTier.GetShowingStationCount(filter));
            var stations = bizTier.GetStations(filter);
            foreach (var station in stations)
            { this.stationList.Items.Add(station.Name); }
            if (this.stationList.Items.Count > 0)
            {
                this.stationList.SelectedIndex = 0;
            }
            else
            {
                resetAllFormData();
            }
        }

        private void loadStationDetails(string selectedStation)
        {
            // loads the list of stops
            this.stopList.Items.Clear();
            this.stopList.Refresh();

            try
            {
                BusinessTier.Business bizTier = new BusinessTier.Business(this.databaseName.Text);
                var station = bizTier.GetStationDetails(selectedStation);
                this.totalRidership.Text = Convert.ToString(station.TotalRidership);
                this.avgRidership.Text = Convert.ToString(station.AvgRidership) + "/day";
                this.percentRidership.Text = station.PercentRidership;
                this.weekday.Text = Convert.ToString(station.Weekday);
                this.saturday.Text = Convert.ToString(station.Saturday);
                this.sunday.Text = Convert.ToString(station.Sunday);

                var stops = bizTier.GetStops(station.ID);
                foreach (var stop in stops)// display stations:
                {
                    this.stopList.Items.Add(stop.Name);
                }
            } catch(Exception ex)
            {
                string msg = string.Format("Error: '{0}'.", ex.Message);
                MessageBox.Show(msg);
            }

            if (this.stopList.Items.Count > 0)
            {
                this.stopList.SelectedIndex = 0;
                this.reportADA.Enabled = true;
            }
            else
            {
                // exception handling for closed stations
                this.selectedStopLabel.Text = "No Stops";
                this.lineList.Items.Clear();
                this.handicap.Text = "╳";
                this.location.Text = "(0, 0)";
                this.reportADA.Enabled = false;
            }
        }

        public void loadStopDetails(string selectedStop)
        {
            // fetch lines
            this.lineList.Items.Clear();
            this.lineList.Refresh();
            try
            {
                BusinessTier.Business bizTier = new BusinessTier.Business(this.databaseName.Text);
                var stop = bizTier.GetStopDetails(selectedStop);
                this.handicap.Text = Convert.ToString(stop.ADA);
                this.direction.Text = Convert.ToString(stop.Direction);
                this.location.Text = stop.Location;
                
                foreach (var line in stop.Lines)
                {
                    this.lineList.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error: '{0}'.", ex.Message);
                MessageBox.Show(msg);
            }
        }
        
        // ******* VS is a weirdo and won't let me delete these functions: ******
        private void avgRidership_TextChanged(object sender, EventArgs e)
        {
            // ignore
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // CTA Ridership Label - ignore
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Select a Station Label - ignore
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // some label 9 - ignore
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // ignore
        }

        private void label19_Click(object sender, EventArgs e)
        {
            // ignore
        }

        private void label20_Click(object sender, EventArgs e)
        {
            // ignore
        }

        private void databaseName_TextChanged(object sender, EventArgs e)
        {
            // ignore
        }
    }
}
