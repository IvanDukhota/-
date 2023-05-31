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
                CoinList.Add(new Coin(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), textBox5.Text, textBox6.Text, textBox7.Text));
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
                MessageBox.Show("Помилка " + ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CollectorList.Add(new Collector(textBox8.Text, textBox9.Text, Convert.ToInt32(textBox10.Text), textBox11.Text));
                MessageBox.Show("Колекціонер додан");
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка " + ex.Message);
            }
        }
    }
}
