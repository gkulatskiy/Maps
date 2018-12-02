using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.WindowsForms.Markers;

namespace Maps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Настройки для компонента GMap.
            gmap.Bearing = 0;
                       
            gmap.CanDragMap = true;

            gmap.DragButton = MouseButtons.Left;

            gmap.GrayScaleMode = true;
            
            gmap.MarkersEnabled = true;

            gmap.MaxZoom = 18;
                       
            gmap.MinZoom = 2;
                      
            gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            
            gmap.NegativeMode = false;
                        
            gmap.PolygonsEnabled = true;
                        
            gmap.RoutesEnabled = true;
                        
            gmap.ShowTileGridLines = false;
                        
            gmap.Zoom = 14;
                       
            gmap.Dock = DockStyle.Fill;
            double s = double.Parse(textBox1.Text);
            double v = double.Parse(textBox2.Text);
            //Указываем что будем использовать карты Google.
            gmap.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            gmap.Position = new PointLatLng(s, v);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "48,465180";
            textBox2.Text = "35,045371";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double s = double.Parse(textBox1.Text);
            double v = double.Parse(textBox2.Text);
            gmap.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap; 
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            gmap.Position = new PointLatLng(s, v);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "50,447899";
            textBox2.Text = "30,522158";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "40,16685";
            textBox2.Text = "-3,704263";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "48,854923";
            textBox2.Text = "2,347838";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "52,518315";
            textBox2.Text = "13,406977";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "52,226442";
            textBox2.Text = "21,013567";
        }
    }
}
