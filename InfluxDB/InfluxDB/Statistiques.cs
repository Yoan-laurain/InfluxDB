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
    public partial class Statistiques : Form
    {

        private bool mouseDown;
        private Point lastLocation;

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

        public Statistiques()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnl_Nav.Height = btn_Stat.Height;
            pnl_Nav.Top = btn_Stat.Top;
            pnl_Nav.Left = btn_Stat.Left;
            btn_Stat.BackColor = Color.FromArgb(46, 51, 73);

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
            Close();
        }

        private void RArrow_MouseEnter(object sender, EventArgs e)
        {
            Zoom(sender, 48, 46);
        }

        private void RArrow_MouseLeave(object sender, EventArgs e)
        {
            Zoom(sender, 44, 42);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Zoom(sender, 48, 46);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Zoom(sender, 44, 42);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Zoom(sender, 28, 32);
        }

        public void Zoom(object sender, int height, int width)
        {
            PictureBox img = sender as PictureBox;
            img.Size = new Size(height, width);
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Zoom(sender, 21, 26);
        }

        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            pnl_Nav.Height = Btn_Dashboard.Height;
            pnl_Nav.Top = Btn_Dashboard.Top;
            pnl_Nav.Left = Btn_Dashboard.Left;
            Btn_Dashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_Stat_Click(object sender, EventArgs e)
        {
            pnl_Nav.Height = btn_Stat.Height;
            pnl_Nav.Top = btn_Stat.Top;
            btn_Stat.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            pnl_Nav.Height = btn_Settings.Height;
            pnl_Nav.Top = btn_Settings.Top;
            btn_Settings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Btn_Dashboard_Leave(object sender, EventArgs e)
        {
            Btn_Dashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_Stat_Leave(object sender, EventArgs e)
        {
            btn_Stat.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_Settings_Leave(object sender, EventArgs e)
        {
            btn_Settings.BackColor = Color.FromArgb(24, 30, 54);
        }


    }
}
