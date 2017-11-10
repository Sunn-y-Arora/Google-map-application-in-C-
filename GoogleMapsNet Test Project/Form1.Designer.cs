namespace GoogleMapsNet_Test_Project
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClearRoutes = new System.Windows.Forms.Button();
            this.buttonAddRoute = new System.Windows.Forms.Button();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.textBoxOrigin = new System.Windows.Forms.TextBox();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.buttonClearMarkers = new System.Windows.Forms.Button();
            this.buttonGoToLocation = new System.Windows.Forms.Button();
            this.buttonAddMarker = new System.Windows.Forms.Button();
            this.numericUpDownZoom = new System.Windows.Forms.NumericUpDown();
            this.radioButtonHybridTerrain = new System.Windows.Forms.RadioButton();
            this.radioButtonHybridSatellite = new System.Windows.Forms.RadioButton();
            this.radioButtonTerrain = new System.Windows.Forms.RadioButton();
            this.radioButtonSatellite = new System.Windows.Forms.RadioButton();
            this.radioButtonRoadmap = new System.Windows.Forms.RadioButton();
            this.labelZoom = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxLat = new System.Windows.Forms.TextBox();
            this.labelLat = new System.Windows.Forms.Label();
            this.textBoxLong = new System.Windows.Forms.TextBox();
            this.labelLong = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToRegistryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(344, 615);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(107, 37);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxInfo.Controls.Add(this.dataGridViewDetails);
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Controls.Add(this.label1);
            this.groupBoxInfo.Controls.Add(this.buttonClearRoutes);
            this.groupBoxInfo.Controls.Add(this.buttonAddRoute);
            this.groupBoxInfo.Controls.Add(this.textBoxDestination);
            this.groupBoxInfo.Controls.Add(this.labelDestination);
            this.groupBoxInfo.Controls.Add(this.textBoxOrigin);
            this.groupBoxInfo.Controls.Add(this.labelOrigin);
            this.groupBoxInfo.Controls.Add(this.buttonSaveImage);
            this.groupBoxInfo.Controls.Add(this.buttonClearMarkers);
            this.groupBoxInfo.Controls.Add(this.buttonClose);
            this.groupBoxInfo.Controls.Add(this.buttonGoToLocation);
            this.groupBoxInfo.Controls.Add(this.buttonAddMarker);
            this.groupBoxInfo.Controls.Add(this.numericUpDownZoom);
            this.groupBoxInfo.Controls.Add(this.radioButtonHybridTerrain);
            this.groupBoxInfo.Controls.Add(this.radioButtonHybridSatellite);
            this.groupBoxInfo.Controls.Add(this.radioButtonTerrain);
            this.groupBoxInfo.Controls.Add(this.radioButtonSatellite);
            this.groupBoxInfo.Controls.Add(this.radioButtonRoadmap);
            this.groupBoxInfo.Controls.Add(this.labelZoom);
            this.groupBoxInfo.Controls.Add(this.buttonRefresh);
            this.groupBoxInfo.Controls.Add(this.textBoxLat);
            this.groupBoxInfo.Controls.Add(this.labelLat);
            this.groupBoxInfo.Controls.Add(this.textBoxLong);
            this.groupBoxInfo.Controls.Add(this.labelLong);
            this.groupBoxInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxInfo.Location = new System.Drawing.Point(571, 28);
            this.groupBoxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInfo.Size = new System.Drawing.Size(485, 669);
            this.groupBoxInfo.TabIndex = 2;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Google Maps";
            this.groupBoxInfo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(166, 486);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Route Navigation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(173, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Select Terrain";
            // 
            // buttonClearRoutes
            // 
            this.buttonClearRoutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearRoutes.Location = new System.Drawing.Point(291, 556);
            this.buttonClearRoutes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearRoutes.Name = "buttonClearRoutes";
            this.buttonClearRoutes.Size = new System.Drawing.Size(160, 37);
            this.buttonClearRoutes.TabIndex = 29;
            this.buttonClearRoutes.Text = "Clear Routes";
            this.buttonClearRoutes.UseVisualStyleBackColor = true;
            this.buttonClearRoutes.Click += new System.EventHandler(this.buttonClearRoutes_Click);
            // 
            // buttonAddRoute
            // 
            this.buttonAddRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRoute.Location = new System.Drawing.Point(291, 507);
            this.buttonAddRoute.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddRoute.Name = "buttonAddRoute";
            this.buttonAddRoute.Size = new System.Drawing.Size(160, 37);
            this.buttonAddRoute.TabIndex = 28;
            this.buttonAddRoute.Text = "Add Route";
            this.buttonAddRoute.UseVisualStyleBackColor = true;
            this.buttonAddRoute.Click += new System.EventHandler(this.buttonAddRoute_Click);
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDestination.Location = new System.Drawing.Point(112, 563);
            this.textBoxDestination.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDestination.Multiline = true;
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(145, 40);
            this.textBoxDestination.TabIndex = 27;
            this.textBoxDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(34, 576);
            this.labelDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(41, 17);
            this.labelDestination.TabIndex = 26;
            this.labelDestination.Text = "Dest:";
            // 
            // textBoxOrigin
            // 
            this.textBoxOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrigin.Location = new System.Drawing.Point(112, 514);
            this.textBoxOrigin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOrigin.Multiline = true;
            this.textBoxOrigin.Name = "textBoxOrigin";
            this.textBoxOrigin.Size = new System.Drawing.Size(145, 41);
            this.textBoxOrigin.TabIndex = 25;
            this.textBoxOrigin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(25, 527);
            this.labelOrigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(50, 17);
            this.labelOrigin.TabIndex = 24;
            this.labelOrigin.Text = "Origin:";
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveImage.Location = new System.Drawing.Point(169, 615);
            this.buttonSaveImage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(160, 37);
            this.buttonSaveImage.TabIndex = 23;
            this.buttonSaveImage.Text = "Save Map image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // buttonClearMarkers
            // 
            this.buttonClearMarkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearMarkers.Location = new System.Drawing.Point(264, 142);
            this.buttonClearMarkers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearMarkers.Name = "buttonClearMarkers";
            this.buttonClearMarkers.Size = new System.Drawing.Size(160, 37);
            this.buttonClearMarkers.TabIndex = 21;
            this.buttonClearMarkers.Text = "Clear markers";
            this.buttonClearMarkers.UseVisualStyleBackColor = true;
            this.buttonClearMarkers.Click += new System.EventHandler(this.buttonClearMarkers_Click);
            // 
            // buttonGoToLocation
            // 
            this.buttonGoToLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoToLocation.Location = new System.Drawing.Point(291, 53);
            this.buttonGoToLocation.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGoToLocation.Name = "buttonGoToLocation";
            this.buttonGoToLocation.Size = new System.Drawing.Size(160, 37);
            this.buttonGoToLocation.TabIndex = 18;
            this.buttonGoToLocation.Text = "Go to location";
            this.buttonGoToLocation.UseVisualStyleBackColor = true;
            this.buttonGoToLocation.Click += new System.EventHandler(this.buttonGoToLocation_Click);
            // 
            // buttonAddMarker
            // 
            this.buttonAddMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMarker.Location = new System.Drawing.Point(37, 142);
            this.buttonAddMarker.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddMarker.Name = "buttonAddMarker";
            this.buttonAddMarker.Size = new System.Drawing.Size(160, 37);
            this.buttonAddMarker.TabIndex = 13;
            this.buttonAddMarker.Text = "Add marker";
            this.buttonAddMarker.UseVisualStyleBackColor = true;
            this.buttonAddMarker.Click += new System.EventHandler(this.buttonAddMarker_Click);
            // 
            // numericUpDownZoom
            // 
            this.numericUpDownZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownZoom.Location = new System.Drawing.Point(112, 98);
            this.numericUpDownZoom.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownZoom.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numericUpDownZoom.Name = "numericUpDownZoom";
            this.numericUpDownZoom.ReadOnly = true;
            this.numericUpDownZoom.Size = new System.Drawing.Size(133, 23);
            this.numericUpDownZoom.TabIndex = 12;
            this.numericUpDownZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButtonHybridTerrain
            // 
            this.radioButtonHybridTerrain.AutoSize = true;
            this.radioButtonHybridTerrain.Location = new System.Drawing.Point(264, 257);
            this.radioButtonHybridTerrain.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonHybridTerrain.Name = "radioButtonHybridTerrain";
            this.radioButtonHybridTerrain.Size = new System.Drawing.Size(116, 21);
            this.radioButtonHybridTerrain.TabIndex = 11;
            this.radioButtonHybridTerrain.Text = "HybridTerrain";
            this.radioButtonHybridTerrain.UseVisualStyleBackColor = true;
            // 
            // radioButtonHybridSatellite
            // 
            this.radioButtonHybridSatellite.AutoSize = true;
            this.radioButtonHybridSatellite.Location = new System.Drawing.Point(94, 257);
            this.radioButtonHybridSatellite.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonHybridSatellite.Name = "radioButtonHybridSatellite";
            this.radioButtonHybridSatellite.Size = new System.Drawing.Size(120, 21);
            this.radioButtonHybridSatellite.TabIndex = 10;
            this.radioButtonHybridSatellite.Text = "HybridSatellite";
            this.radioButtonHybridSatellite.UseVisualStyleBackColor = true;
            // 
            // radioButtonTerrain
            // 
            this.radioButtonTerrain.AutoSize = true;
            this.radioButtonTerrain.Location = new System.Drawing.Point(305, 228);
            this.radioButtonTerrain.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonTerrain.Name = "radioButtonTerrain";
            this.radioButtonTerrain.Size = new System.Drawing.Size(75, 21);
            this.radioButtonTerrain.TabIndex = 9;
            this.radioButtonTerrain.Text = "Terrain";
            this.radioButtonTerrain.UseVisualStyleBackColor = true;
            // 
            // radioButtonSatellite
            // 
            this.radioButtonSatellite.AutoSize = true;
            this.radioButtonSatellite.Location = new System.Drawing.Point(176, 228);
            this.radioButtonSatellite.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSatellite.Name = "radioButtonSatellite";
            this.radioButtonSatellite.Size = new System.Drawing.Size(79, 21);
            this.radioButtonSatellite.TabIndex = 8;
            this.radioButtonSatellite.Text = "Satellite";
            this.radioButtonSatellite.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoadmap
            // 
            this.radioButtonRoadmap.AutoSize = true;
            this.radioButtonRoadmap.Checked = true;
            this.radioButtonRoadmap.Location = new System.Drawing.Point(43, 228);
            this.radioButtonRoadmap.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonRoadmap.Name = "radioButtonRoadmap";
            this.radioButtonRoadmap.Size = new System.Drawing.Size(90, 21);
            this.radioButtonRoadmap.TabIndex = 7;
            this.radioButtonRoadmap.TabStop = true;
            this.radioButtonRoadmap.Text = "Roadmap";
            this.radioButtonRoadmap.UseVisualStyleBackColor = true;
            // 
            // labelZoom
            // 
            this.labelZoom.AutoSize = true;
            this.labelZoom.Location = new System.Drawing.Point(55, 101);
            this.labelZoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(48, 17);
            this.labelZoom.TabIndex = 5;
            this.labelZoom.Text = "Zoom:";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(32, 615);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(129, 37);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh Map";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxLat
            // 
            this.textBoxLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLat.Location = new System.Drawing.Point(112, 65);
            this.textBoxLat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLat.Name = "textBoxLat";
            this.textBoxLat.Size = new System.Drawing.Size(132, 23);
            this.textBoxLat.TabIndex = 3;
            this.textBoxLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.Location = new System.Drawing.Point(40, 69);
            this.labelLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(63, 17);
            this.labelLat.TabIndex = 2;
            this.labelLat.Text = "Latitude:";
            // 
            // textBoxLong
            // 
            this.textBoxLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLong.Location = new System.Drawing.Point(112, 33);
            this.textBoxLong.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLong.Name = "textBoxLong";
            this.textBoxLong.Size = new System.Drawing.Size(132, 23);
            this.textBoxLong.TabIndex = 1;
            this.textBoxLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLong
            // 
            this.labelLong.AutoSize = true;
            this.labelLong.Location = new System.Drawing.Point(28, 37);
            this.labelLong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLong.Name = "labelLong";
            this.labelLong.Size = new System.Drawing.Size(75, 17);
            this.labelLong.TabIndex = 0;
            this.labelLong.Text = "Longitude:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mapsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToRegistryToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveAsImageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToRegistryToolStripMenuItem
            // 
            this.saveToRegistryToolStripMenuItem.Name = "saveToRegistryToolStripMenuItem";
            this.saveToRegistryToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.saveToRegistryToolStripMenuItem.Text = "Save State";
            this.saveToRegistryToolStripMenuItem.Click += new System.EventHandler(this.saveToRegistryToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.loadToolStripMenuItem.Text = "Load Last Saved";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.saveAsImageToolStripMenuItem.Text = "Save as Image";
            this.saveAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveAsImageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mapsToolStripMenuItem
            // 
            this.mapsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripMenuItem});
            this.mapsToolStripMenuItem.Name = "mapsToolStripMenuItem";
            this.mapsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.mapsToolStripMenuItem.Text = "Maps";
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.changeToolStripMenuItem.Text = "Change ";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.AllowUserToOrderColumns = true;
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(28, 285);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.RowTemplate.Height = 24;
            this.dataGridViewDetails.Size = new System.Drawing.Size(396, 198);
            this.dataGridViewDetails.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 697);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Map Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox textBoxLong;
        private System.Windows.Forms.Label labelLong;
        private System.Windows.Forms.TextBox textBoxLat;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.RadioButton radioButtonRoadmap;
        private System.Windows.Forms.RadioButton radioButtonHybridSatellite;
        private System.Windows.Forms.RadioButton radioButtonTerrain;
        private System.Windows.Forms.RadioButton radioButtonSatellite;
        private System.Windows.Forms.RadioButton radioButtonHybridTerrain;
        private System.Windows.Forms.NumericUpDown numericUpDownZoom;
        private System.Windows.Forms.Button buttonAddMarker;
        private System.Windows.Forms.Button buttonGoToLocation;
        private System.Windows.Forms.Button buttonClearMarkers;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox textBoxOrigin;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Button buttonAddRoute;
        private System.Windows.Forms.Button buttonClearRoutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToRegistryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
    }
}

