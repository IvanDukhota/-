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

                OwnCollectionList.Add(new Classes.OwnCollection(textBoxName.Text, textBoxCountry.Text, Convert.ToInt32(textBoxYear.Text), Convert.ToInt32(textBoxAmount.Text), textBoxDenomination.Text, textBoxMetal.Text, textBoxFeature.Text));
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
                MessageBox.Show("Помилка " + ex.Message);
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
