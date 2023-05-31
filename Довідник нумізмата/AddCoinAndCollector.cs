using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Довідник_нумізмата.Classes;
using static Довідник_нумізмата.Classes.Collector;

namespace Довідник_нумізмата
{
    public partial class AddCoinAndCollector : Form
    {
        public AddCoinAndCollector()
        {
            InitializeComponent();
            this.MinimumSize = new Size(882, 527);
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string coinName = textBox1.Text;
                string coinCountry = textBox2.Text;
                string coinDenomination = textBox5.Text;
                string coinMetal = textBox6.Text;
                string coinFeature = textBox7.Text;

                int coinissueOfTheCoin;
                if (!int.TryParse(textBox3.Text, out coinissueOfTheCoin))
                {
                    MessageBox.Show("Помилка: Введіть числове значення в поле 'Рік випуску'");
                    return;
                }

                int coinAmount;
                if (!int.TryParse(textBox4.Text, out coinAmount))
                {
                    MessageBox.Show("Помилка: Введіть числове значення в поле 'Кількість випущених монет'");
                    return;
                }

                if (coinName.Any(char.IsDigit))
                {
                    MessageBox.Show("Помилка: Введіть текстове значення в поле 'Ім'я'");
                    return;
                }

                if (coinCountry.Any(char.IsDigit))
                {
                    MessageBox.Show("Помилка: Введіть текстове значення в поле 'Країна'");
                    return;
                }

                if (coinDenomination.Any(char.IsDigit))
                {
                    MessageBox.Show("Помилка: Введіть текстове значення в поле 'Номінал'");
                    return;
                }

                if (coinMetal.Any(char.IsDigit))
                {
                    MessageBox.Show("Помилка: Введіть текстове значення в поле 'Метал'");
                    return;
                }

                if (coinFeature.Any(char.IsDigit))
                {
                    MessageBox.Show("Помилка: Введіть текстове значення в поле 'Особливість'");
                    return;
                }

                CoinList.Add(new Coin(coinName, coinCountry, coinissueOfTheCoin, coinAmount, coinDenomination, coinMetal, coinFeature));
                MessageBox.Show("Монета додана");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }





        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string collectorName = textBox8.Text;
                string collectorCountry = textBox9.Text;
                string collectorRareCoins = textBox11.Text;

                int collectorPhone;
                if (!int.TryParse(textBox10.Text, out collectorPhone))
                {
                    MessageBox.Show("Помилка: Введіть числове значення в поле 'Номер телефона'");
                    return;
                }

                if (collectorName.Any(char.IsDigit))
                {
                    MessageBox.Show("Помилка: Введіть текстове значення в поле 'Ім'я колекціонера'");
                    return;
                }

                if (collectorCountry.Any(char.IsDigit))
                {
                    MessageBox.Show("Помилка: Введіть текстове значення в поле 'Країна колекціонера'");
                    return;
                }

                if (collectorRareCoins.Any(char.IsDigit))
                {
                    MessageBox.Show("Помилка: Введіть текстове значення в поле 'Рідкісні монети'");
                    return;
                }

                CollectorList.Add(new Collector(collectorName, collectorCountry, collectorPhone, collectorRareCoins));
                MessageBox.Show("Колекціонер доданий");

                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
}
