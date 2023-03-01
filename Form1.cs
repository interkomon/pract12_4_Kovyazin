using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pract12_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buyer buyer = new Buyer();
            buyer.ProductName = textBox1.Text;
            buyer.Price = double.Parse(textBox2.Text);
            buyer.Quantity = int.Parse(textBox3.Text);
            buyer.Wallet = double.Parse(textBox4.Text);
            buyer.Mood = int.Parse(textBox5.Text);
            if (buyer.Wallet < buyer.Price)
            {
                MessageBox.Show("Количество денег не может быть меньше стоимости товара", "Ошибка");
            }

            Regex regex = new Regex("^[а-яА-Я]+$");
            if (!regex.IsMatch(textBox1.Text))
            {
                MessageBox.Show("Вводите только буквы!");
            }
            Regex regex1 = new Regex("^[0-9]+$");
            if (!regex1.IsMatch(textBox2.Text))
            {
                MessageBox.Show("Вводите только цифры!");
            }
            if (!regex1.IsMatch(textBox3.Text))
            {
                MessageBox.Show("Вводите только цифры!");
            }
            if (!regex1.IsMatch(textBox4.Text))
            {
                MessageBox.Show("Вводите только цифры!");
            }
            if (!regex1.IsMatch(textBox5.Text))
            {
                MessageBox.Show("Вводите только цифры!");
            }

            if(buyer.Price <= 0)
            {
                MessageBox.Show("Цена не может быть меньше нуля");
            }
            if (buyer.Wallet <= 0)
            {
                MessageBox.Show("Кошелек не может быть пустым");
            }
            if (buyer.Quantity <= 0)
            {
                MessageBox.Show("Количество не может быть нрулевым");
            }
            if (buyer.Mood <= 0)
            {
                MessageBox.Show("Настроение не может быть отрицательным или равно нулю");
            }


            buyer.BuyInfo();
            buyer.Buy(buyer.Price, buyer.Quantity);
            buyer.CheckMood();
        }


    }
}
