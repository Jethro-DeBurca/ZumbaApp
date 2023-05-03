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
    public partial class Registration : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-P6HLD79\\" +
                                                              "SQLEXPRESS;Initial Catalog=Zumba;" +
                                                              "Integrated Security=True");

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txb_EnterPasswordConfirm.Text != string.Empty || txb_EnterPassword.Text != string.Empty || txb_EnterfName.Text != string.Empty || txb_EnterlName.Text != string.Empty || txb_EnterID.Text != string.Empty)
            {
                if (txb_EnterPassword.Text == txb_EnterPasswordConfirm.Text)
                {
                    SqlCommand cmd = new SqlCommand("select * from Customers where ID='" + txb_EnterID.Text + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("ID Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into Customers values(@ID,@fName,@lName,@Concessions,@Password)", con);
                        cmd.Parameters.AddWithValue("@ID", int.Parse(txb_EnterID.Text));
                        cmd.Parameters.AddWithValue("@fName", txb_EnterfName.Text);
                        cmd.Parameters.AddWithValue("@lName", txb_EnterlName.Text);
                        cmd.Parameters.AddWithValue("@Concessions", 0);
                        cmd.Parameters.AddWithValue("@Password", txb_EnterPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password the same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter values into all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
