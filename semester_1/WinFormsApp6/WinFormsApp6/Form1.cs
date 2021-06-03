using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private double order;
        public int price, width, height;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            label4.Text = "";
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите только цифры.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            label4.Text = "";
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите только цифры.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            width = Int32.Parse(textBox1.Text);
            height = Int32.Parse(textBox2.Text);
            order = width * height * price / 10000.0 ;
            
            label4.Text = "Размер: "+ width +"x" + height + " см.\n"+ 
                          "Цена (р./м.кв.): " + price + " ₽\n" +
                          "Сумма: " + order + " ₽";
            label4.Visible = true;
        }
           

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case ("пластик"):
                    price = 50;
                    break;
                case ("алюминий"):
                    price = 100;
                    break;
                case ("бамбук"):
                    price = 75;
                    break;
                case ("соломка"):
                    price = 70;
                    break;
                case ("текстиль"):
                    price = 60;
                    break;
            }
        }
        
        private void enable_button(object sender, EventArgs e)
        {
            if (price != 0 && textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
                button1.Enabled = true;
            else button1.Enabled = false;
        }
    }
}