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
    public partial class Login : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=LAPTOP-9JOMFM4Q;Initial Catalog=Zumba;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        public static class UserSession
        {   // Creating a global user session to record who is logged-in
            public static int CurrentUserID { get; set; }
            public static int CurrentUserConcessions { get; set; }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select Concessions from Customers Where ID = " + txb_ID.Text, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                UserSession.CurrentUserConcessions = reader.GetInt32(0);
                reader.Close();
            }
            else
            {
                reader.Close();
            }

            if (txb_Password.Text != string.Empty || txb_ID.Text != string.Empty)
            {
                SqlCommand cmd = new SqlCommand("select * from Customers where ID='" + txb_ID.Text + "' and Password='" + txb_Password.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    UserSession.CurrentUserID = int.Parse(txb_ID.Text);
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this ID and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter values in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
