using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Довідник_нумізмата.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Довідник_нумізмата
{
    public partial class AddCoinToOwn : Form
    {
        public AddCoinToOwn()
        {
            InitializeComponent();
            this.MinimumSize = new Size(816, 489);


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string coinName = textBoxName.Text;
                string coinCountry = textBoxCountry.Text;
                string coinDenomination = textBoxDenomination.Text;
                string coinMetal = textBoxMetal.Text;
                string coinFeature = textBoxFeature.Text;

                int coinYear;
                if (!int.TryParse(textBoxYear.Text, out coinYear))
                {
                    MessageBox.Show("Помилка: Введіть числове значення в поле 'Рік випуску'");
                    return;
                }

                int coinAmount;
                if (!int.TryParse(textBoxAmount.Text, out coinAmount))
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

                OwnCollectionList.Add(new Classes.OwnCollection(coinName, coinCountry, coinYear, coinAmount, coinDenomination, coinMetal, coinFeature));
                MessageBox.Show("Монета додана");

                textBoxName.Text = "";
                textBoxCountry.Text = "";
                textBoxYear.Text = "";
                textBoxAmount.Text = "";
                textBoxDenomination.Text = "";
                textBoxMetal.Text = "";
                textBoxFeature.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
