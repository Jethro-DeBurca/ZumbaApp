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
using static ZumbaApp.Concessions;
using static ZumbaApp.Login;

namespace ZumbaApp
{
    public partial class BankCard : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=LAPTOP-9JOMFM4Q;Initial Catalog=Zumba;Integrated Security=True");

        public BankCard()
        {
            InitializeComponent();
        }

        private void BankCard_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            try
            {   // Creating a new SqlCommand to add concessions
                SqlCommand cmd = new SqlCommand("update Customers set Concessions=@Concessions where ID = @ID", con);

                // Adding parameters to the SqlCommand object
                cmd.Parameters.AddWithValue("@ID", UserSession.CurrentUserID);
                cmd.Parameters.AddWithValue("@Concessions", UserConBuyAmount.ConBuyAmount);

                cmd.ExecuteNonQuery();

                con.Close();

                UserSession.CurrentUserConcessions = UserConBuyAmount.ConBuyAmount;

                Form1 form1 = new Form1();
                form1.Refresh();

                // Show a message box indicating the data was successfully inserted
                MessageBox.Show("Concessions Bought");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            this.Hide();
        }
    }
}
