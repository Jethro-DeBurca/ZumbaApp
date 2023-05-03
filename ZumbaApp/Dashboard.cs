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
    public partial class Dashboard : UserControl
    {
        public static SqlConnection con = new SqlConnection("Data Source=LAPTOP-9JOMFM4Q;Initial Catalog=Zumba;Integrated Security=True");

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            con.Open();

            try
            {
                // Creating a new SqlCommand to add concessions
                SqlCommand command = new SqlCommand("Select fName from Customers Where ID = " + UserSession.CurrentUserID, con);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    lbl_NameDisplay.Text = reader.GetString(0) + "!";
                    reader.Close();
                }
                else
                {
                    reader.Close();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
