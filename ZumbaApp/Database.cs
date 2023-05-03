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
    public partial class Database : UserControl
    {
        public Database()
        {
            InitializeComponent();
        }

        #region Insert Button
        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {   // Create a new SqlConnection object with the connection string
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-9JOMFM4Q;Initial Catalog=Zumba;Integrated Security=True"))
                {
                    con.Open();

                    // Create a new SqlCommand to insert values
                    SqlCommand cmd = new SqlCommand("insert into Customers values (@ID,@fname,@lname,@Concessions,@Password)", con);

                    // Adding parameters to the SqlCommand object
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txb_ID.Text));
                    cmd.Parameters.AddWithValue("@fname", txb_fName.Text);
                    cmd.Parameters.AddWithValue("@lname", txb_lName.Text);
                    cmd.Parameters.AddWithValue("@Concessions", int.Parse(txb_Concessions.Text));
                    cmd.Parameters.AddWithValue("@Password", "User");

                    cmd.ExecuteNonQuery();

                    con.Close();
                    // Show a message box indicating the data was successfully inserted
                    MessageBox.Show("Data successfully inserted");
                }
            }
            catch (Exception ex)
            {   // Display error message in pop up
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion

        #region Update Button
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {   // Create a new SqlConnection object with the connection string
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-9JOMFM4Q;Initial Catalog=Zumba;Integrated Security=True"))
                {
                    con.Open();

                    // Create a new SqlCommand to update values
                    SqlCommand cmd = new SqlCommand("update Customers set ID=@ID, fName=@fName, " +
                                                    "lName=@lName, Concessions=@Concessions where ID = @ID", con);

                    // Adding parameters to the SqlCommand object
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txb_ID.Text));
                    cmd.Parameters.AddWithValue("@fName", txb_fName.Text);
                    cmd.Parameters.AddWithValue("@lName", txb_lName.Text);
                    cmd.Parameters.AddWithValue("@Concessions", int.Parse(txb_Concessions.Text));

                    cmd.ExecuteNonQuery();

                    con.Close();
                    // Show a message box indicating the data was successfully updated
                    MessageBox.Show("Data successfully updated");
                }
            }
            catch (Exception ex)
            {   // Display error message in pop up
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion

        #region Delete Button
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {   // Create a new SqlConnection object with the connection string
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-9JOMFM4Q;Initial Catalog=Zumba;Integrated Security=True"))
                {
                    con.Open();

                    // Create a new SqlCommand to delete customers with corresponding ID
                    SqlCommand cmd = new SqlCommand("delete Customers where ID=@ID", con);

                    // Adding parameters to the SqlCommand object
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txb_ID.Text));

                    cmd.ExecuteNonQuery();

                    con.Close();
                    // Show a message box indicating the data was successfully deleted
                    MessageBox.Show("Customer successfully deleted");
                }
            }
            catch (Exception ex)
            {   // Display error message in pop up
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion

        #region Search ID Button
        private void Search_Click(object sender, EventArgs e)
        {
            try
            {   // Create a new SqlConnection object with the connection string
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-9JOMFM4Q;Initial Catalog=Zumba;Integrated Security=True"))
                {
                    con.Open();

                    // Create a new SqlCommand to display customer details with corresponding ID
                    SqlCommand cmd = new SqlCommand("select * from Customers where ID=@ID", con);

                    // Adding parameters to the SqlCommand object
                    cmd.Parameters.AddWithValue("ID", int.Parse(txb_ID.Text));

                    // Filling the dataGridView panel in order to display customers details corresponding ID
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    con.Close();
                }
            }
            catch (Exception ex)
            {   // Display error message in pop up
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion

        #region View All Button
        private void View_Click(object sender, EventArgs e)
        {
            try
            {   // Create a new SqlConnection object with the connection string
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-9JOMFM4Q;Initial Catalog=Zumba;Integrated Security=True"))
                {
                    con.Open();

                    // Create a new SqlCommand to display all customers details
                    SqlCommand cmd = new SqlCommand("select * from Customers", con);

                    // Filling the dataGridView panel in order to display customers details
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    con.Close();
                }
            }
            catch (Exception ex)
            {   // Display error message in pop up
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion
    }
}
