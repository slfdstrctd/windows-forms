using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private double price=0, order;
        private int amount;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = 8.50;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            price = 10.00;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            price = 15.50;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            label2.Text = "";
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите только цифры.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            { 
                amount = Int32.Parse(textBox1.Text);
           
                order = amount * price;
              
                label2.Text = "Цена: " + price + " ₽\nКоличество: " + amount + " шт.\n"+
                 "Сумма заказа: " + order + "₽";
                label2.Visible = true;
            }
            else
                MessageBox.Show("Введите количество.");
            
        }

        private void enable_button(object sender, EventArgs e)
        {
            if (price !=0 && textBox1.Text.Length !=0)
                button1.Enabled = true;
        }
    }
}