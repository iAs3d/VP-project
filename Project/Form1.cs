using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;


namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        SqlConnection connection = new SqlConnection(@"Data Source=ASAAD;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True");

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {
            textPass.UseSystemPasswordChar = true;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username, userpass;

            username = textUser.Text;
            userpass = textPass.Text;

            try
            {
                // Define the SQL query
                string query = "SELECT * FROM Login WHERE username = '" + textUser.Text + "' AND password = '" + textPass.Text + "' ";

                // Create sqlCommand
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to prevent SQL injection
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", userpass);

                // Create data adapter and fill the datatable
                SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                // Check user exist or not
                if(dtable.Rows.Count > 0)
                {

                    //Move to form 2
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password is wrong", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        // To Create Account
        private void label2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
