using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfluxDB
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private String[] deity = new String[] { "Zeus", "Héra", "Poséidon", "Athéna", "Arès", "Déméter", "Apollon", "Artémis", "Héphaïstos", "Aphrodite", "Hermès", "Hestia", "Dionysos" };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            DGVDieux.AllowUserToAddRows = false;
            DGVDieux.ColumnCount = 3;
            DGVDieux.RowCount = 6;

            for(int i = 0; i < deity.Length; i++)
            {
                
            }


        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );


        private void splitContainer1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void splitContainer1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void splitContainer1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void splitContainer1_Panel2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void splitContainer1_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void splitContainer1_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void splitContainer1_Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void splitContainer1_Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void splitContainer1_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
