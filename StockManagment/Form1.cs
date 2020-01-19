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

namespace StockManagment
{
    public partial class Form1 : Form
    {

        Product p = new Product();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //add
            try
            {
                p.Name = productName.Text;
                p.Pcode = int.Parse(Code.Text);
                p.Status = int.Parse(status.Text);
                p.Quantity = int.Parse(quantity.Text);

                ProductManager.ProductAdd(p, "product.xml");
                MessageBox.Show("data succeddfully saved,");
            }
            catch(Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sell

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update

            if (File.Exists("product.xml"))
            {
                p = ProductManager.ProductRead("product.xml");
                productName.Text = p.Name;
                Code.Text = p.Pcode.ToString();
                status.Text = p.Status.ToString();
                quantity.Text = p.Quantity.ToString();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
