using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZumbaApp
{
    public partial class Form1 : Form
    {
        #region Form1
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region SideBar

        bool sideBarExpand = true;

        private void tmr_SideBar_Tick(object sender, EventArgs e)
        {   
            // If sidebar is expanded, minimize, otherwise expand
            if (sideBarExpand)
            {
                flw_SideBar.Width -= 10;
                if (flw_SideBar.Width <= flw_SideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    tmr_SideBar.Stop();
                }
            }
            else
            {
                flw_SideBar.Width += 10;
                if (flw_SideBar.Width >= flw_SideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    tmr_SideBar.Stop();
                }
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            tmr_SideBar.Start();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            database1.Hide();
            booking1.Hide();
            concessions1.Hide();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            database1.Hide();
            booking1.Hide();
            concessions1.Hide();
            dashboard1.Show();
        }

        private void btn_Database_Click(object sender, EventArgs e)
        {
            booking1.Hide();
            concessions1.Hide();
            dashboard1.Hide();
            database1.Show();
        }

        private void btn_Booking_Click(object sender, EventArgs e)
        {
            database1.Hide();
            concessions1.Hide();
            dashboard1.Hide();
            booking1.Show();
        }

        public void btn_Concessions_Click(object sender, EventArgs e)
        {
            database1.Hide();
            booking1.Hide();
            dashboard1.Hide();
            concessions1.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
