using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GoogleMaps;
using Microsoft.Win32;


namespace GoogleMapsNet_Test_Project
{
    public partial class Form1 : Form
    {
        private GoogleMapsNet googleMapsNet1 = null;

        public Form1()
        {
            InitializeComponent();

            googleMapsNet1 = new GoogleMapsNet();
            googleMapsNet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            googleMapsNet1.Latitude = 20.5937;
            googleMapsNet1.Location = new System.Drawing.Point(20, 20);
            googleMapsNet1.Longitude = 78.9629;
            googleMapsNet1.Name = "googleMapsNet1";
            googleMapsNet1.ShowGrid = false;
            googleMapsNet1.Size = new System.Drawing.Size(1376, 768);
            googleMapsNet1.TabIndex = 1;
            googleMapsNet1.LongitudeChanged += new System.EventHandler(this.googleMapsNet1_LongitudeChanged);
            googleMapsNet1.LatitudeChanged += new System.EventHandler(this.googleMapsNet1_LatitudeChanged);
            googleMapsNet1.ZoomChanged += new System.EventHandler(this.googleMapsNet1_ZoomChanged);
            googleMapsNet1.Dock = DockStyle.Left;
            this.Controls.Add(googleMapsNet1);


            textBoxLong.Text = "78.9629";
            textBoxLat.Text = "20.5937";
            numericUpDownZoom.Value = 5;
            MapType mapType = MapType.MapTypeRoadmap;

            googleMapsNet1.ShowMap(mapType, Convert.ToDouble(textBoxLong.Text.Trim()), Convert.ToDouble(textBoxLat.Text.Trim()), Convert.ToDouble(numericUpDownZoom.Value));


        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (textBoxLong.Text.Trim() != "")
            {
                if (textBoxLat.Text.Trim() != "")
                {
                    MapType mapType = MapType.MapTypeRoadmap;
                    if (radioButtonSatellite.Checked == true)
                    {
                        mapType = MapType.MapTypeSatellite;
                    }
                    else if (radioButtonTerrain.Checked == true)
                    {
                        mapType = MapType.MapTypeTerrain;
                    }
                    else if (radioButtonHybridSatellite.Checked == true)
                    {
                        mapType = MapType.MapTypeHybridSatellite;
                    }
                    else if (radioButtonHybridTerrain.Checked == true)
                    {
                        mapType = MapType.MapTypeHybridTerrain;
                    }
                    googleMapsNet1.ShowMap(mapType, Convert.ToDouble(textBoxLong.Text.Trim()), Convert.ToDouble(textBoxLat.Text.Trim()), Convert.ToDouble(numericUpDownZoom.Value));
                }
                else
                {
                    MessageBox.Show("Enter the latitude !!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter the longitude !!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddMarker_Click(object sender, EventArgs e)
        {
            if (textBoxLong.Text.Trim() != "")
            {
                if (textBoxLat.Text.Trim() != "")
                {
                    googleMapsNet1.AddMarker(Convert.ToDouble(textBoxLong.Text.Trim()), Convert.ToDouble(textBoxLat.Text.Trim()), Convert.ToDouble(numericUpDownZoom.Value));
                }
                else
                {
                    MessageBox.Show("Enter the latitude !!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter the longitude !!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGoToLocation_Click(object sender, EventArgs e)
        {
            if (!textBoxLat.Text.Trim().Equals("0") || !textBoxLong.Text.Trim().Equals("0") || textBoxLat.Text.Length != 0 || textBoxLong.Text.Length != 0)
            {
                MapType mapType = MapType.MapTypeRoadmap;
                if (radioButtonSatellite.Checked == true)
                {
                    mapType = MapType.MapTypeSatellite;
                }
                else if (radioButtonTerrain.Checked == true)
                {
                    mapType = MapType.MapTypeTerrain;
                }
                else if (radioButtonHybridSatellite.Checked == true)
                {
                    mapType = MapType.MapTypeHybridSatellite;
                }
                else if (radioButtonHybridTerrain.Checked == true)
                {
                    mapType = MapType.MapTypeHybridTerrain;
                }

                // Show map
                googleMapsNet1.ShowMap(mapType, Convert.ToDouble(textBoxLong.Text.Trim()), Convert.ToDouble(textBoxLat.Text.Trim()), Convert.ToDouble(numericUpDownZoom.Value));
            }
            else
            {
                MessageBox.Show("Enter Latitude and Longitude", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonClearMarkers_Click(object sender, EventArgs e)
        {
            googleMapsNet1.ClearMarkers();
        }

        private void googleMapsNet1_LongitudeChanged(object sender, EventArgs e)
        {
            textBoxLong.Text = googleMapsNet1.Longitude.ToString();
        }

        private void googleMapsNet1_LatitudeChanged(object sender, EventArgs e)
        {
            textBoxLat.Text = googleMapsNet1.Latitude.ToString();
        }

        private void googleMapsNet1_ZoomChanged(object sender, EventArgs e)
        {
            numericUpDownZoom.Value = Convert.ToDecimal(googleMapsNet1.Zoom.ToString());
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = googleMapsNet1.GetMap();
            String s = "Map.png";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\Users\Sunny\Desktop";
            saveFileDialog1.Title = "Save Map Image";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "png";
            saveFileDialog1.Filter = "Image File |*.jpg|Image File |*.png|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                s = saveFileDialog1.FileName;
                bitmap.Save(s);
            }
            else
            {
                MessageBox.Show("Failed to Save");
            }
        }

        private void buttonAddRoute_Click(object sender, EventArgs e)
        {
            // Check params
            if (textBoxOrigin.Text.Trim() != "")
            {
                if (textBoxDestination.Text.Trim() != "")
                {
                    // Add route
                    DataTable table = googleMapsNet1.AddRoute(textBoxOrigin.Text.Trim(), textBoxDestination.Text.Trim());
                    dataGridViewDetails.DataSource = table;
                }
                else
                {
                    MessageBox.Show("You have to enter the destination !!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You have to enter the origin !!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void buttonClearRoutes_Click(Object sender, EventArgs e)
        {
            googleMapsNet1.ClearRoutes();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBoxInfo.Visible == true)
                groupBoxInfo.Visible = false;
            else
                groupBoxInfo.Visible = true;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
               Close();
        }

        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = googleMapsNet1.GetMap();
            String s = "Map.png";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\Users\Sunny\Desktop";
            saveFileDialog1.Title = "Save Map Image";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "png";
            saveFileDialog1.Filter = "Image File |*.jpg|Image File |*.png|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                s = saveFileDialog1.FileName;
                bitmap.Save(s);
            }
            else
            {
                MessageBox.Show("Failed to Save");
            }
        }

        private void saveToRegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("Software\\DotNet Project", true);
            if (rk == null)
            {
                rk = Registry.CurrentUser.CreateSubKey("Software\\DotNet Project");
            }
            if (textBoxDestination.Text.Length == 0 || textBoxOrigin.Text.Length == 0 || textBoxLong.Text.Length == 0 || textBoxLat.Text.Length == 0)
            {
                MessageBox.Show("Enter the values first");
            }
            else
            {
                
                rk.SetValue("lati", textBoxLat.Text);
                rk.SetValue("long", textBoxLong.Text);
                rk.SetValue("origin", textBoxOrigin.Text);
                rk.SetValue("Dest", textBoxDestination.Text);
                rk.SetValue("zoom", numericUpDownZoom.Value.ToString());
            }
            rk.Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("Software\\DotNet Project", true);
            if (rk == null)
            {
                MessageBox.Show("No Saved State Available");
            }
            else {
                textBoxDestination.Text = rk.GetValue("Dest").ToString();
                textBoxOrigin.Text = rk.GetValue("origin").ToString();
                textBoxLong.Text = rk.GetValue("long").ToString();
                textBoxLat.Text = rk.GetValue("lati").ToString();
                numericUpDownZoom.Value = Convert.ToDecimal(rk.GetValue("zoom").ToString());
                rk.Close();
                MapType mapType = MapType.MapTypeRoadmap;
               googleMapsNet1.ShowMap(mapType, Convert.ToDouble(textBoxLong.Text.Trim()), Convert.ToDouble(textBoxLat.Text.Trim()), Convert.ToDouble(numericUpDownZoom.Value));
               DataTable table = googleMapsNet1.AddRoute(textBoxOrigin.Text.Trim(), textBoxDestination.Text.Trim());
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s="Developed By-\n\t15BIT0196\tSunny Arora\n\t15BIT0226\tSwarnim Gupta.";
            MessageBox.Show(s);
        }
    }
}
