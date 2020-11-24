using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             double price = 309000.00;
             double discount = 0.01;
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                price += 8390.00 + 5990.00 + 7590.00;
                double dPrice = Math.Round(price * discount,2);

                label3.Text = "Цена в выбранной комплектации: " + price + " ₽\n"
                    + "Скидка (1%): " + dPrice + " ₽\n"
                    + "Итого: " + (price - dPrice) + " ₽";
                label3.Visible = true;
                
            }
            else
            {
                if (checkBox1.Checked)
                {
                    price += 8390.00;
                }

                if (checkBox2.Checked)
                {
                    price += 5990.00;
                }

                if (checkBox3.Checked)
                {
                    price += 7590.00;
                }
                
                label3.Text = "Цена в выбранной комплектации: " + price + " ₽\n";
                label3.Visible = true;
            }

        }
    }
}