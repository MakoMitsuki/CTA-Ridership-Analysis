namespace CTARidershipAnalysis
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.top10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stationList = new System.Windows.Forms.ListBox();
            this.selectedStationLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalRidership = new System.Windows.Forms.Label();
            this.percentRidership = new System.Windows.Forms.Label();
            this.avgRidership = new System.Windows.Forms.Label();
            this.weekday = new System.Windows.Forms.Label();
            this.saturday = new System.Windows.Forms.Label();
            this.sunday = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectedStopLabel = new System.Windows.Forms.Label();
            this.handicap = new System.Windows.Forms.Label();
            this.direction = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lineList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.reportADA = new System.Windows.Forms.Button();
            this.stopList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.top10Panel = new System.Windows.Forms.Panel();
            this.backStations = new System.Windows.Forms.Button();
            this.topTenList = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.noStations = new System.Windows.Forms.Label();
            this.databaseName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.submitFilter = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.TextBox();
            this.unFilter = new System.Windows.Forms.Button();
            this.adaChange = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.noFilteredStationsLabel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.top10Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.loadToolStripMenuItem.Text = "Load File";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InfoText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.top10ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 24;
            // 
            // top10ToolStripMenuItem
            // 
            this.top10ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.top10ToolStripMenuItem.Name = "top10ToolStripMenuItem";
            this.top10ToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.top10ToolStripMenuItem.Text = "Top 10";
            this.top10ToolStripMenuItem.Click += new System.EventHandler(this.top10ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(308, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "CTA Ridership Analysis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search for a Station";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // stationList
            // 
            this.stationList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationList.FormattingEnabled = true;
            this.stationList.ItemHeight = 16;
            this.stationList.Location = new System.Drawing.Point(12, 90);
            this.stationList.Name = "stationList";
            this.stationList.Size = new System.Drawing.Size(298, 308);
            this.stationList.TabIndex = 1;
            this.stationList.SelectedIndexChanged += new System.EventHandler(this.stationList_SelectedIndexChanged);
            // 
            // selectedStationLabel
            // 
            this.selectedStationLabel.AutoSize = true;
            this.selectedStationLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedStationLabel.ForeColor = System.Drawing.Color.DimGray;
            this.selectedStationLabel.Location = new System.Drawing.Point(312, 77);
            this.selectedStationLabel.Name = "selectedStationLabel";
            this.selectedStationLabel.Size = new System.Drawing.Size(174, 24);
            this.selectedStationLabel.TabIndex = 16;
            this.selectedStationLabel.Text = "Selected Station";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Ridership";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Average Ridership";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "% Ridership";
            // 
            // totalRidership
            // 
            this.totalRidership.AutoSize = true;
            this.totalRidership.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRidership.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalRidership.Location = new System.Drawing.Point(3, 6);
            this.totalRidership.Name = "totalRidership";
            this.totalRidership.Size = new System.Drawing.Size(30, 32);
            this.totalRidership.TabIndex = 19;
            this.totalRidership.Text = "0";
            this.totalRidership.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // percentRidership
            // 
            this.percentRidership.AutoSize = true;
            this.percentRidership.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentRidership.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.percentRidership.Location = new System.Drawing.Point(3, 104);
            this.percentRidership.Name = "percentRidership";
            this.percentRidership.Size = new System.Drawing.Size(30, 32);
            this.percentRidership.TabIndex = 21;
            this.percentRidership.Text = "0";
            this.percentRidership.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // avgRidership
            // 
            this.avgRidership.AutoSize = true;
            this.avgRidership.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgRidership.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.avgRidership.Location = new System.Drawing.Point(3, 55);
            this.avgRidership.Name = "avgRidership";
            this.avgRidership.Size = new System.Drawing.Size(30, 32);
            this.avgRidership.TabIndex = 20;
            this.avgRidership.Text = "0";
            this.avgRidership.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // weekday
            // 
            this.weekday.AutoSize = true;
            this.weekday.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekday.ForeColor = System.Drawing.Color.White;
            this.weekday.Location = new System.Drawing.Point(3, 167);
            this.weekday.Name = "weekday";
            this.weekday.Size = new System.Drawing.Size(30, 32);
            this.weekday.TabIndex = 22;
            this.weekday.Text = "0";
            this.weekday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saturday
            // 
            this.saturday.AutoSize = true;
            this.saturday.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturday.ForeColor = System.Drawing.Color.White;
            this.saturday.Location = new System.Drawing.Point(3, 216);
            this.saturday.Name = "saturday";
            this.saturday.Size = new System.Drawing.Size(30, 32);
            this.saturday.TabIndex = 23;
            this.saturday.Text = "0";
            this.saturday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sunday
            // 
            this.sunday.AutoSize = true;
            this.sunday.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunday.ForeColor = System.Drawing.Color.White;
            this.sunday.Location = new System.Drawing.Point(3, 265);
            this.sunday.Name = "sunday";
            this.sunday.Size = new System.Drawing.Size(30, 32);
            this.sunday.TabIndex = 24;
            this.sunday.Text = "0";
            this.sunday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Weekday";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Saturday";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Sunday/Holiday";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.sunday);
            this.panel1.Controls.Add(this.saturday);
            this.panel1.Controls.Add(this.weekday);
            this.panel1.Controls.Add(this.avgRidership);
            this.panel1.Controls.Add(this.percentRidership);
            this.panel1.Controls.Add(this.totalRidership);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(316, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 344);
            this.panel1.TabIndex = 22;
            // 
            // selectedStopLabel
            // 
            this.selectedStopLabel.AutoSize = true;
            this.selectedStopLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedStopLabel.ForeColor = System.Drawing.Color.White;
            this.selectedStopLabel.Location = new System.Drawing.Point(38, 0);
            this.selectedStopLabel.Name = "selectedStopLabel";
            this.selectedStopLabel.Size = new System.Drawing.Size(138, 22);
            this.selectedStopLabel.TabIndex = 27;
            this.selectedStopLabel.Text = "Selected Stop";
            // 
            // handicap
            // 
            this.handicap.AutoSize = true;
            this.handicap.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handicap.ForeColor = System.Drawing.Color.White;
            this.handicap.Location = new System.Drawing.Point(14, 29);
            this.handicap.Name = "handicap";
            this.handicap.Size = new System.Drawing.Size(85, 75);
            this.handicap.TabIndex = 30;
            this.handicap.Text = "╳";
            this.handicap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // direction
            // 
            this.direction.AutoSize = true;
            this.direction.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direction.ForeColor = System.Drawing.Color.White;
            this.direction.Location = new System.Drawing.Point(128, 38);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(94, 72);
            this.direction.TabIndex = 31;
            this.direction.Text = "W";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 44);
            this.label8.TabIndex = 28;
            this.label8.Text = "Handicap \r\nAccessible";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(128, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 44);
            this.label12.TabIndex = 29;
            this.label12.Text = "Direction\r\nof Travel";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(118, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 125);
            this.panel3.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(9, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 18);
            this.label15.TabIndex = 33;
            this.label15.Text = "@";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.ForeColor = System.Drawing.Color.White;
            this.location.Location = new System.Drawing.Point(39, 157);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(121, 18);
            this.location.TabIndex = 34;
            this.location.Text = "(-0.0000, -0000)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(228, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 22);
            this.label17.TabIndex = 35;
            this.label17.Text = "Lines";
            // 
            // lineList
            // 
            this.lineList.BackColor = System.Drawing.Color.SlateGray;
            this.lineList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineList.ForeColor = System.Drawing.Color.White;
            this.lineList.FormattingEnabled = true;
            this.lineList.ItemHeight = 18;
            this.lineList.Location = new System.Drawing.Point(232, 54);
            this.lineList.Name = "lineList";
            this.lineList.Size = new System.Drawing.Size(195, 94);
            this.lineList.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.lineList);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.location);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.direction);
            this.panel2.Controls.Add(this.handicap);
            this.panel2.Controls.Add(this.selectedStopLabel);
            this.panel2.Location = new System.Drawing.Point(542, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 190);
            this.panel2.TabIndex = 23;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(8, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 22);
            this.label21.TabIndex = 39;
            this.label21.Text = ">>";
            // 
            // reportADA
            // 
            this.reportADA.BackColor = System.Drawing.Color.Black;
            this.reportADA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportADA.ForeColor = System.Drawing.Color.White;
            this.reportADA.Location = new System.Drawing.Point(910, 453);
            this.reportADA.Name = "reportADA";
            this.reportADA.Size = new System.Drawing.Size(66, 23);
            this.reportADA.TabIndex = 38;
            this.reportADA.Text = "Change";
            this.reportADA.UseVisualStyleBackColor = false;
            this.reportADA.Click += new System.EventHandler(this.reportADA_Click);
            // 
            // stopList
            // 
            this.stopList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopList.FormattingEnabled = true;
            this.stopList.ItemHeight = 16;
            this.stopList.Location = new System.Drawing.Point(542, 102);
            this.stopList.Name = "stopList";
            this.stopList.Size = new System.Drawing.Size(299, 148);
            this.stopList.TabIndex = 12;
            this.stopList.SelectedIndexChanged += new System.EventHandler(this.stopList_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label7.Location = new System.Drawing.Point(845, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Select one from list";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label6.Location = new System.Drawing.Point(844, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Stop Infos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label13.Location = new System.Drawing.Point(844, 221);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 29);
            this.label13.TabIndex = 27;
            this.label13.Text = "<<<<<<<<";
            // 
            // top10Panel
            // 
            this.top10Panel.AllowDrop = true;
            this.top10Panel.BackColor = System.Drawing.Color.Maroon;
            this.top10Panel.Controls.Add(this.backStations);
            this.top10Panel.Controls.Add(this.topTenList);
            this.top10Panel.Controls.Add(this.label16);
            this.top10Panel.Controls.Add(this.label14);
            this.top10Panel.Location = new System.Drawing.Point(420, 27);
            this.top10Panel.Name = "top10Panel";
            this.top10Panel.Size = new System.Drawing.Size(565, 454);
            this.top10Panel.TabIndex = 28;
            this.top10Panel.Visible = false;
            // 
            // backStations
            // 
            this.backStations.BackColor = System.Drawing.Color.White;
            this.backStations.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backStations.ForeColor = System.Drawing.Color.Maroon;
            this.backStations.Location = new System.Drawing.Point(338, 380);
            this.backStations.Name = "backStations";
            this.backStations.Size = new System.Drawing.Size(296, 31);
            this.backStations.TabIndex = 32;
            this.backStations.Text = "Return to Stations";
            this.backStations.UseVisualStyleBackColor = false;
            this.backStations.Click += new System.EventHandler(this.backStations_Click);
            // 
            // topTenList
            // 
            this.topTenList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topTenList.BackColor = System.Drawing.Color.Black;
            this.topTenList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topTenList.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topTenList.ForeColor = System.Drawing.Color.White;
            this.topTenList.FormattingEnabled = true;
            this.topTenList.ItemHeight = 22;
            this.topTenList.Location = new System.Drawing.Point(109, 107);
            this.topTenList.Margin = new System.Windows.Forms.Padding(20);
            this.topTenList.Name = "topTenList";
            this.topTenList.Size = new System.Drawing.Size(370, 264);
            this.topTenList.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Transparent;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Location = new System.Drawing.Point(334, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(298, 24);
            this.label16.TabIndex = 30;
            this.label16.Text = "Top 10 Stations by Ridership";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Transparent;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(265, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(437, 44);
            this.label14.TabIndex = 29;
            this.label14.Text = "CTA Ridership Analysis";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 407);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 14);
            this.label18.TabIndex = 29;
            this.label18.Text = "Showing";
            // 
            // noStations
            // 
            this.noStations.AutoSize = true;
            this.noStations.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noStations.Location = new System.Drawing.Point(141, 407);
            this.noStations.Name = "noStations";
            this.noStations.Size = new System.Drawing.Size(13, 14);
            this.noStations.TabIndex = 30;
            this.noStations.Text = "0";
            // 
            // databaseName
            // 
            this.databaseName.Location = new System.Drawing.Point(91, 430);
            this.databaseName.Name = "databaseName";
            this.databaseName.Size = new System.Drawing.Size(209, 20);
            this.databaseName.TabIndex = 31;
            this.databaseName.Text = "|DataDirectory|\\CTA.mdf";
            this.databaseName.TextChanged += new System.EventHandler(this.databaseName_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(12, 423);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 30);
            this.label19.TabIndex = 32;
            this.label19.Text = "Specify Custom\r\nDatabase File";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Location = new System.Drawing.Point(12, 453);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(229, 26);
            this.label20.TabIndex = 33;
            this.label20.Text = "*In case of no data on File Load, double check if filename is correct.\r\nLikely to" +
    " default to CTA.mdf when textbox is blank";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // submitFilter
            // 
            this.submitFilter.BackColor = System.Drawing.Color.Maroon;
            this.submitFilter.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.submitFilter.FlatAppearance.BorderSize = 0;
            this.submitFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitFilter.ForeColor = System.Drawing.Color.White;
            this.submitFilter.Location = new System.Drawing.Point(150, 60);
            this.submitFilter.Margin = new System.Windows.Forms.Padding(0);
            this.submitFilter.Name = "submitFilter";
            this.submitFilter.Size = new System.Drawing.Size(75, 21);
            this.submitFilter.TabIndex = 34;
            this.submitFilter.Text = "Filter";
            this.submitFilter.UseVisualStyleBackColor = false;
            this.submitFilter.Click += new System.EventHandler(this.submitFilter_Click);
            // 
            // filter
            // 
            this.filter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.Location = new System.Drawing.Point(12, 60);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(132, 21);
            this.filter.TabIndex = 36;
            // 
            // unFilter
            // 
            this.unFilter.BackColor = System.Drawing.Color.Maroon;
            this.unFilter.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.unFilter.FlatAppearance.BorderSize = 0;
            this.unFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unFilter.ForeColor = System.Drawing.Color.White;
            this.unFilter.Location = new System.Drawing.Point(230, 59);
            this.unFilter.Margin = new System.Windows.Forms.Padding(0);
            this.unFilter.Name = "unFilter";
            this.unFilter.Size = new System.Drawing.Size(75, 21);
            this.unFilter.TabIndex = 37;
            this.unFilter.Text = "Unfilter";
            this.unFilter.UseVisualStyleBackColor = false;
            this.unFilter.Click += new System.EventHandler(this.unFilter_Click);
            // 
            // adaChange
            // 
            this.adaChange.Items.AddRange(new object[] {
            "No Change",
            "Stop is NOT Handicap-Accessible",
            "Stop is Handicap-Accessible"});
            this.adaChange.Location = new System.Drawing.Point(682, 454);
            this.adaChange.Name = "adaChange";
            this.adaChange.Size = new System.Drawing.Size(222, 22);
            this.adaChange.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(544, 456);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 15);
            this.label22.TabIndex = 40;
            this.label22.Text = "Report an ADA Change";
            // 
            // noFilteredStationsLabel
            // 
            this.noFilteredStationsLabel.AutoSize = true;
            this.noFilteredStationsLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noFilteredStationsLabel.Location = new System.Drawing.Point(72, 407);
            this.noFilteredStationsLabel.Name = "noFilteredStationsLabel";
            this.noFilteredStationsLabel.Size = new System.Drawing.Size(13, 14);
            this.noFilteredStationsLabel.TabIndex = 41;
            this.noFilteredStationsLabel.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(100, 407);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 14);
            this.label23.TabIndex = 42;
            this.label23.Text = "out of";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 480);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.noFilteredStationsLabel);
            this.Controls.Add(this.top10Panel);
            this.Controls.Add(this.reportADA);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectedStationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.stopList);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.noStations);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.databaseName);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.unFilter);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.submitFilter);
            this.Controls.Add(this.adaChange);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.stationList);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CTA Ridership Analysis";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.top10Panel.ResumeLayout(false);
            this.top10Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox stationList;
        private System.Windows.Forms.Label selectedStationLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalRidership;
        private System.Windows.Forms.Label percentRidership;
        private System.Windows.Forms.Label avgRidership;
        private System.Windows.Forms.Label weekday;
        private System.Windows.Forms.Label saturday;
        private System.Windows.Forms.Label sunday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label selectedStopLabel;
        private System.Windows.Forms.Label handicap;
        private System.Windows.Forms.Label direction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lineList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox stopList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel top10Panel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox topTenList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem top10ToolStripMenuItem;
        private System.Windows.Forms.Button backStations;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label noStations;
        private System.Windows.Forms.TextBox databaseName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button submitFilter;
        private System.Windows.Forms.TextBox filter;
        private System.Windows.Forms.Button unFilter;
        private System.Windows.Forms.Button reportADA;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox adaChange;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label noFilteredStationsLabel;
        private System.Windows.Forms.Label label23;
    }
}

