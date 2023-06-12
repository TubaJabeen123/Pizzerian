using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace loginForm
{    
    public partial class RegistrationForm : Form
    {
        String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fatim\source\repos\loginForm\loginForm\registration.mdf;Integrated Security=True";
        SqlConnection con;
        String patternP = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$"; //validation
        string pattern = @"^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public RegistrationForm()
        {
            InitializeComponent();
            this.txtUsrN.Focus();
            con = new SqlConnection(conString);
        }

       
        private void lblGetStrt_Click(object sender, EventArgs e)
        {

        }

        private void lnklblCrtAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String email = txtUsrN.Text;
            String address = text_add.Text;
            String contact = txt_cntct.Text.ToString();
            Form1 login = new Form1(email, address, contact);
            login.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsrN.Text = "";
            txtPass.Text = "";
            txtCnfrmPass.Text = "";
            text_add.Text = "";
            txt_cntct.Text = "";
            txtUsrN.Focus();

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            con.Open();
            String email = txtUsrN.Text;
            String pass = txtPass.Text;
            int contact = int.Parse(txt_cntct.Text);
            String add = text_add.Text;
            
                if (txtUsrN.Text == "" && txtPass.Text == "" && txtCnfrmPass.Text == "" && text_add.Text=="" && txt_cntct.Text =="" )
                
                {
                    MessageBox.Show("Fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPass.Text == txtCnfrmPass.Text)
                {                  
                    String querry = "INSERT INTO Registration VALUES(@Email, @password, @contact, @address)";
                    SqlCommand command = new SqlCommand(querry, con);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@password", pass);
                    command.Parameters.AddWithValue("@contact", contact);
                    command.Parameters.AddWithValue("@address", add);

                    command.ExecuteNonQuery();
                    txtUsrN.Text = "";
                    txtPass.Text = "";
                    txtCnfrmPass.Text = "";
                    text_add.Text = "";
                    txt_cntct.Text = "";
;                    MessageBox.Show("You are successfully registered", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Passwords does not match.Please re-enter your passwords", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Text = "";
                    txtCnfrmPass.Text = "";
                    txtPass.Focus();
                }

            
            con.Close();
        }
        

        private void cBShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cBShowPass.Checked)
            {
                txtPass.PasswordChar = '\0';
                txtCnfrmPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
                txtCnfrmPass.PasswordChar = '*';
            }
        }

        private void txtUsrN_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtUsrN.Text, pattern) == false)
            {
                txtUsrN.Focus();
                errorProvider1.SetError(this.txtUsrN,"Please enter valid email address");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(txtPass.Text, patternP)== false)
            {
                txtPass.Focus();
                errorProvider2.SetError(this.txtPass, "Use strong password(UPPERCASE, LOWERCASE, NUMBERS, SPECIAL CHARACTERS)");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtCnfrmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
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

        private void lblUsrN_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




 /*       public string emailValue
        {
            get { return txtUsrN.Text; }
        }
        public int contactValue
        {
            get { return int.Parse(txt_cntct.Text); }
        }
        public string adressValue
        {
            get { return text_add.Text; }
        }*/

    }
}
