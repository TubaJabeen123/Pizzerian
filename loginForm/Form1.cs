using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Linq.Expressions;


namespace loginForm
{

    public partial class Form1 : Form
    {
        String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fatim\source\repos\loginForm\loginForm\registration.mdf;Integrated Security=True";
        private String email;
        private String address;
        private String contact;

        public Form1(string email, string address, string contact)
        {
            InitializeComponent();
            this.email = email;
            this.address = address;
            this.contact = contact;
            txtUsrN.Focus();
           
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
           
            /*con.Open();*/
            string email= txtUsrN.Text;
            string pass= txtPass.Text;
            
            if (txtUsrN.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("User Name and Password fields are empty", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {


                        string query = "SELECT COUNT(*) FROM Registration WHERE Email = @email AND password = @password";
                        SqlCommand command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", pass);

                        con.Open();
                        int count = (int)command.ExecuteScalar();
                        con.Close();

                        if (count > 0)
                        {
                            MessageBox.Show("Loged in successfully", "Login Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            menu menuform = new menu(email, address, contact);
                            menuform.Show();
                            this.Hide();

                        }
                    
                        else
                        {
                            MessageBox.Show("Invalid Username or Password!", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsrN.Text = "";
                            txtPass.Text = "";

                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database connection error"
                        , MessageBoxButtons.OK);
                }

            }
           

        }

        private void lnklblCrtAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegistrationForm().Show();
            this.Hide();
        }

        private void cBShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cBShowPass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsrN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;
            int centerX = (screenWidth - formWidth) / 2;
            int centerY = (screenHeight - formHeight) / 2;

            // Set the form's position to the center of the screen
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(centerX, centerY);
        }


   
    }
}
