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

namespace Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            string username, userpass;

            username = textBox_username.Text;
            userpass = textBox_password.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(userpass))
            {
                MessageBox.Show("Username and Password cannot be empty!", "Sign-Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=ASAAD;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True"))
                {
                    connection.Open();

                    // check if the username exists or no
                    string checkQuery = "SELECT COUNT(*) FROM Login WHERE username = @username";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@username", username);

                    int userExists = (int)checkCommand.ExecuteScalar();

                    if (userExists > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.", "Sign-Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // new user insertion
                    string insertQuery = "INSERT INTO Login (username, password) VALUES (@username, @password)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@password", userpass);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account Created Successful!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Redirect to Form3
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textBox_password.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true; // Hide password
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
        }
    }
}
