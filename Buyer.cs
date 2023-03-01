using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract12_4
{
   public class Buyer
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Wallet { get; set; }
        public int Mood { get; set; }


     

        public void BuyInfo()
        {
            MessageBox.Show($"Вы покупаете {ProductName}" + "\n" + $"{Quantity} штук" + "\n" + $" Цена {Price} ") ;
        }
        public void Buy(double price,int quanity)
        {
            Price = price;
            Quantity = quanity;
            Wallet -= price * quanity;
            MessageBox.Show($"У вас осталось в кошельке {Wallet}");
            if (Wallet >= price * quanity)
            {
                Mood += (int)(price * quanity * 0.5);
            }
            else
            {
                Mood -= (int)(price * quanity - Wallet);
            }
        }
        public void CheckMood()
        {
            if (Mood > 15)
            {
                MessageBox.Show("Твое настроение бодрое");
            }
            else if (Mood > 5 && Mood <= 15)
            {
                MessageBox.Show("Твое настроение нормальное");
            }
            else if (Mood > -10 && Mood <= 5)
            {
                MessageBox.Show("Твое настроение плохое");
            }
            else if(Mood <=-10)
            {
                MessageBox.Show("Твое настроение депрсивное");
            }
        }
    }
}
