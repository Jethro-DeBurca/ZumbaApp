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
using static ZumbaApp.Login;

namespace ZumbaApp
{
    public partial class Booking : UserControl
    {
        public Booking()
        {
            InitializeComponent();
        }

        public static bool ConfirmBox()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to book this session?", "Book Class", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else if (dialogResult == DialogResult.No)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        private void Booking_Load(object sender, EventArgs e)
        {   // Load text with date of next Sunday
            DateTime today = DateTime.Today;
            int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)today.DayOfWeek + 7) % 7;
            DateTime nextSunday = today.AddDays(daysUntilSunday);

            Sunday.Text = "Book Next Sunday Class: \n" + nextSunday.ToShortDateString();

            // Load text with date of next Monday
            today = DateTime.Today;
            int daysUntilMonday = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
            DateTime nextMonday = today.AddDays(daysUntilMonday);

            Monday.Text = "Book Next Monday Class: \n" + nextMonday.ToShortDateString();

            // Load text with date of next Tuesday
            today = DateTime.Today;
            int daysUntilTuesday = ((int)DayOfWeek.Tuesday - (int)today.DayOfWeek + 7) % 7;
            DateTime nextTuesday = today.AddDays(daysUntilTuesday);

            Tuesday.Text = "Book Next Tuesday Class: \n" + nextTuesday.ToShortDateString();
        }

        private void Sunday_Click(object sender, EventArgs e)
        {
            bool choice = ConfirmBox();

            if (choice == true)
            {
                try
                {   // Create a new SqlConnection object with the connection string
                    using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-9JOMFM4Q;Initial Catalog=Zumba;Integrated Security=True"))
                    {
                        con.Open();

                        // Set the booking date to the next Sunday
                        DateTime bookingDate = DateTime.Today.AddDays((DayOfWeek.Sunday - DateTime.Today.DayOfWeek + 7) % 7);
                        int ID = UserSession.CurrentUserID;

                        // Create a new SqlCommand to insert values
                        SqlCommand cmd = new SqlCommand("insert into Booking values (@ID,@ClassDate)", con);

                        // Adding parameters to the SqlCommand object
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@ClassDate", bookingDate);

                        cmd.ExecuteNonQuery();

                        SqlCommand command = new SqlCommand("UPDATE Customers SET Concessions = Concessions - 1 WHERE ID = @ID", con);

                        command.Parameters.AddWithValue("@ID", ID);

                        command.ExecuteNonQuery();

                        con.Close();
                        // Show a message box indicating the data was successfully inserted
                        MessageBox.Show("Session Booked!");
                    }
                }
                catch (Exception ex)
                {   // Display error message in pop up
                    MessageBox.Show("Error: " + ex.Message);
                }
            } else
            {
                MessageBox.Show("No Session Booked");
            }
        }

        private void Monday_Click(object sender, EventArgs e)
        {
            bool choice = ConfirmBox();

            if (choice == true)
            {
                try
                {   // Create a new SqlConnection object with the connection string
                    using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-9JOMFM4Q;Initial Catalog=Zumba;Integrated Security=True"))
                    {
                        con.Open();

                        // Set the booking date to the next Monday
                        DateTime bookingDate = DateTime.Today.AddDays((DayOfWeek.Monday - DateTime.Today.DayOfWeek + 7) % 7);
                        int ID = UserSession.CurrentUserID;

                        // Create a new SqlCommand to insert values
                        SqlCommand cmd = new SqlCommand("insert into Booking values (@ID,@ClassDate)", con);

                        // Adding parameters to the SqlCommand object
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@ClassDate", bookingDate);

                        cmd.ExecuteNonQuery();

                        SqlCommand command = new SqlCommand("UPDATE Customers SET Concessions = Concessions - 1 WHERE ID = @ID", con);

                        command.Parameters.AddWithValue("@ID", ID);

                        command.ExecuteNonQuery();

                        con.Close();
                        // Show a message box indicating the data was successfully inserted
                        MessageBox.Show("Session Booked!");
                    }
                }
                catch (Exception ex)
                {   // Display error message in pop up
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No Session Booked");
            }
        }

        private void Tuesday_Click(object sender, EventArgs e)
        {
            bool choice = ConfirmBox();

            if (choice == true)
            {
                try
                {   // Create a new SqlConnection object with the connection string
                    using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-9JOMFM4Q;Initial Catalog=Zumba;Integrated Security=True"))
                    {
                        con.Open();

                        // Set the booking date to the next Tuesday
                        DateTime bookingDate = DateTime.Today.AddDays((DayOfWeek.Tuesday - DateTime.Today.DayOfWeek + 7) % 7);
                        int ID = UserSession.CurrentUserID;

                        // Create a new SqlCommand to insert values
                        SqlCommand cmd = new SqlCommand("insert into Booking values (@ID,@ClassDate)", con);

                        // Adding parameters to the SqlCommand object
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@ClassDate", bookingDate);

                        cmd.ExecuteNonQuery();

                        SqlCommand command = new SqlCommand("UPDATE Customers SET Concessions = Concessions - 1 WHERE ID = @ID", con);

                        command.Parameters.AddWithValue("@ID", ID);

                        command.ExecuteNonQuery();

                        con.Close();
                        // Show a message box indicating the data was successfully inserted
                        MessageBox.Show("Session Booked!");
                    }
                }
                catch (Exception ex)
                {   // Display error message in pop up
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No Session Booked");
            }
        }
    }
}
