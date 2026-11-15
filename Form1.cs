using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            decimal precio1, precio2, total;

            if (decimal.TryParse(textprecio1.Text, out precio1) &&
                decimal.TryParse(textprecio2.Text, out precio2))
            {
                total = precio1 + precio2;
                textventa.Text = total.ToString("N2");
            }
            else
            {
                MessageBox.Show("Ingrese precios validos.");
            }

        }
    }

        }


