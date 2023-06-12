using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace loginForm
{
    public partial class checkOut : Form
    {
        String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fatim\source\repos\loginForm\loginForm\registration.mdf;Integrated Security=True";
        SqlConnection con;
        private string username;
        private string address;
        private string contact;
        private decimal totalP;
        public checkOut(string username, string address, string contact, decimal price)
        {
            InitializeComponent();
            con= new SqlConnection(conString);
            this.username = username;
            textemail.Text = $" {username}";
            this.address = address;
            txtAdd.Text =  $"{address}";
            this.contact= contact;
            txtContact.Text = $" {contact}";
            this.totalP = price;
            textbill.Text = $"{price}";


            /*    ImportTextFieldValue();*/
        }

        private void checkOut_Load(object sender, EventArgs e)
        {

        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {

        }


/*        private void ImportTextFieldValue()
        {
            RegistrationForm regform = new RegistrationForm();
            string email = regform.emailValue;
            textemail.Text = email;

            string add = regform.adressValue;
            txtAdd.Text = add;

            int contact= regform.contactValue;
            txtContact.Text = contact.ToString();
        }
*/


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
