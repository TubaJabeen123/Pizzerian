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

namespace loginForm
{
    public partial class menu : Form
    {
 

        private List<CartItems> CartList = new List<CartItems>();
        String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fatim\source\repos\loginForm\loginForm\Menu.mdf;Integrated Security=True";
        SqlConnection con;
        private string username;
        private string address;
        private string contact;
        private Decimal amountPrice;

        public menu(string username, string address, string contact)
        {
            InitializeComponent();
            con= new SqlConnection(conString);
            this.username = username;
            this.address = address;
            this.contact = contact;
        }

        private void menu_Load(object sender, EventArgs e)
        {

            comboboxfaj.SelectedValueChanged -= comboboxfaj_SelectedValueChanged;
            comboboxfaj.DataSource = GetProductDetails();
            comboboxfaj.DisplayMember = "Size";
            comboboxfaj.ValueMember = "Price";
            comboboxfaj.SelectedValueChanged += comboboxfaj_SelectedValueChanged;
            comboboxfaj.SelectedIndex = -1;

            comboBoxbbq.SelectedValueChanged -= comboBoxbbq_SelectedValueChanged;
            comboBoxbbq.DataSource = GetProductDetails();
            comboBoxbbq.DisplayMember = "Size";
            comboBoxbbq.ValueMember = "Price";
            comboBoxbbq.SelectedValueChanged += comboBoxbbq_SelectedValueChanged;
            comboBoxbbq.SelectedIndex = -1;



            comboBoxTand.SelectedValueChanged -= comboBoxTand_SelectedValueChanged;
            comboBoxTand.DataSource = GetProductDetails();
            comboBoxTand.DisplayMember = "Size";
            comboBoxTand.ValueMember = "Price";
            comboBoxTand.SelectedValueChanged += comboBoxTand_SelectedValueChanged;
            comboBoxTand.SelectedIndex = -1;

            comboboxpep.SelectedValueChanged -= comboboxpep_SelectedValueChanged;
            comboboxpep.DataSource = GetProductDetails();
            comboboxpep.DisplayMember = "Size";
            comboboxpep.ValueMember = "Price";
            comboboxpep.SelectedValueChanged += comboboxpep_SelectedValueChanged;
            comboboxpep.SelectedIndex = -1;


            comboboxgril.SelectedValueChanged -= comboboxgril_SelectedValueChanged;
            comboboxgril.DataSource = GetProductDetails();
            comboboxgril.DisplayMember = "Size";
            comboboxgril.ValueMember = "Price";
            comboboxgril.SelectedValueChanged += comboboxgril_SelectedValueChanged;
            comboboxgril.SelectedIndex = -1;







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



        private void comboboxfaj_SelectedValueChanged(object sender, EventArgs e)
        {
            int productPrice = Convert.ToInt32(comboboxfaj.SelectedValue);
            txtBoxPriceFaj.Text = productPrice.ToString();
        }
        private void txtBoxFajQuan_TextChanged(object sender, EventArgs e)
        {
            int productQuan = Convert.ToInt32(txtBoxFajQuan.Text);
            int price = Convert.ToInt32(txtBoxPriceFaj.Text);
            int totalPrice = productQuan * price;
            txtBoxPriceFaj.Text = totalPrice.ToString();
        }
        private void cknFajitaChkBox_Click(object sender, EventArgs e)
        {
            if (comboboxfaj.SelectedIndex == -1)
            {
                MessageBox.Show("Please select pizza type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtBoxFajQuan.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter quatity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cknFajitaChkBox.Checked == true)
            {
                CartItems items = new CartItems() {
                    ProductName = "Chicken Fajita",
                    ProductSize = comboboxfaj.Text,
                    Quantity = Convert.ToByte(txtBoxFajQuan.Text.Trim()),
                    unitPrice = Convert.ToDecimal(txtBoxPriceFaj.Text.Trim()),
                    TotalPrice = Convert.ToDecimal(Convert.ToInt32(txtBoxPriceFaj.Text.Trim())) * Convert.ToInt32(txtBoxFajQuan.Text.Trim())
                };


                CartList.Add(items);
                // view in grid view
                cartgrid.DataSource = null;
                cartgrid.DataSource = CartList;

                // Shpw total price of all items:
                decimal amountPrice = CartList.Sum(x => x.TotalPrice);

            }
        }







        private void comboBoxbbq_SelectedValueChanged(object sender, EventArgs e)
        {
            int productPrice = Convert.ToInt32(comboBoxbbq.SelectedValue);
            txtBoxPricebbq.Text = productPrice.ToString();
        }
        private void txtBoxbbQuan_TextChanged(object sender, EventArgs e)
        {
            int productQuan = Convert.ToInt32(txtBoxbbQuan.Text);
            int price = Convert.ToInt32(txtBoxPricebbq.Text);
            int totalPrice = productQuan * price;
            txtBoxPricebbq.Text = totalPrice.ToString();
        }



        private void comboBoxTand_SelectedValueChanged(object sender, EventArgs e)
        {
            int productPrice = Convert.ToInt32(comboBoxTand.SelectedValue);
            txtBoxpriceTand.Text = productPrice.ToString();
        }
        private void txtBoxquanTand_TextChanged(object sender, EventArgs e)
        {
            int productQuan = Convert.ToInt32(txtBoxquanTand.Text);
            int price = Convert.ToInt32(txtBoxpriceTand.Text);
            int totalPrice = productQuan * price;
            txtBoxpriceTand.Text = totalPrice.ToString();
        }


        private void comboboxpep_SelectedValueChanged(object sender, EventArgs e)
        {
            int productPrice = Convert.ToInt32(comboboxpep.SelectedValue);
            txtBoxPricepep.Text = productPrice.ToString();
        }
        private void txtBoxquanpep_TextChanged(object sender, EventArgs e)
        {
            int productQuan = Convert.ToInt32(txtBoxquanpep.Text);
            int price = Convert.ToInt32(txtBoxPricepep.Text);
            int totalPrice = productQuan * price;
            txtBoxPricepep.Text = totalPrice.ToString();
        }
       



        private void comboboxgril_SelectedValueChanged(object sender, EventArgs e)
        {
            int productPrice = Convert.ToInt32(comboboxgril.SelectedValue);
            txtBoxPricegril.Text = productPrice.ToString();
        }
        private void txtBoxQuangril_TextChanged(object sender, EventArgs e)
        {
            int productQuan = Convert.ToInt32(txtBoxQuangril.Text);
            int price = Convert.ToInt32(txtBoxPricegril.Text);
            int totalPrice = productQuan * price;
            txtBoxPricegril.Text = totalPrice.ToString();
        }


        private DataTable GetProductDetails()
        {
            DataTable dataTb = new DataTable();
            con.Open();                     
            String querry = "SELECT * FROM Pizza";
            SqlCommand cmd= new SqlCommand(querry, con);
            SqlDataReader reader = cmd.ExecuteReader();

            dataTb.Load(reader);
            return dataTb;

        }

        private void lblsize_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbqfaj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkOut checkoutForm = new checkOut(username, address, contact, amountPrice);
            checkoutForm.Show();
            this.Hide();

           /* new checkOut().Show();
            this.Hide();*/
        }

        private void blbBBq_Click(object sender, EventArgs e)
        {

        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            cknFajitaChkBox.Checked = false;
            comboboxfaj.SelectedIndex = -1;
            txtBoxPriceFaj.Clear();
            txtBoxFajQuan.Clear();

            cknBBqChkBox.Checked = false;
            comboBoxbbq.SelectedIndex = -1;
            txtBoxPricebbq.Clear();
            txtBoxbbQuan.Clear();

            cbCkntandooriCkBox.Checked = false;
            comboBoxTand.SelectedIndex = -1;
            txtBoxquanTand.Clear();
            txtBoxpriceTand.Clear();

            chkBoxbpap.Checked = false;
            comboboxpep.SelectedIndex = -1;
            txtBoxPricepep.Clear();
            txtBoxquanpep.Clear();

            ckbgril.Checked = false;
            comboboxgril.SelectedIndex = -1;
            txtBoxQuangril.Clear();
            txtBoxPricegril.Clear();

        }


    }
}
