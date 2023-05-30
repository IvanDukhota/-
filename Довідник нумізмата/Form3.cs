using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Довідник_нумізмата.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Довідник_нумізмата.Classes.Collector;
using static Довідник_нумізмата.Form4;

namespace Довідник_нумізмата
{
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();
        }




        private void Form3_Load(object sender, EventArgs e)
        {
            string file = "C:\\Users\\PC\\source\\repos\\Довідник нумізмата\\Довідник нумізмата\\txt files\\datacoin.txt";
            Data.LoadCoinsFromFile(file);
            string file1 = "C:\\Users\\PC\\source\\repos\\Довідник нумізмата\\Довідник нумізмата\\txt files\\datacollector.txt";
            Data.LoadCollectorFromFile(file1);
            PrintCollector();
            PrintCoin();


        }
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        private void PrintCoin()
        {
            dataGridViewCoin.DataSource = null;
            table.Rows.Clear();
            table.Columns.Clear();

            table.Columns.Add("ім'я", typeof(string));
            table.Columns.Add("Країна", typeof(string));
            table.Columns.Add("Рік випуску", typeof(int));
            table.Columns.Add("Кількість випущених монет", typeof(int));
            table.Columns.Add("Номінал", typeof(string));
            table.Columns.Add("Метал або сплав", typeof(string));
            table.Columns.Add("Особливості", typeof(string));

            foreach (Coin coin in CoinList.coinlist)
            {
                table.Rows.Add(coin.name, coin.country, coin.issueOfTheCoin, coin.amount, coin.denomination, coin.metal, coin.feature);
            }


            dataGridViewCoin.AllowUserToAddRows = false;
            dataGridViewCoin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCoin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCoin.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

            dataGridViewCoin.DataSource = table;
            dataGridViewCoin.Refresh();
        }
        private void PrintCollector()
        {
            dataGridViewCollector.DataSource = null;
            table2.Rows.Clear();
            table2.Columns.Clear();

            table2.Columns.Add("ім'я", typeof(string));
            table2.Columns.Add("Країна", typeof(string));
            table2.Columns.Add("Контактні дані", typeof(int));
            table2.Columns.Add("Рідкісні монети", typeof(string));


            foreach (Collector collector in CollectorList.collectorlist)
            {
                table2.Rows.Add(collector.name, collector.country, collector.phone, collector.rarecoins);
            }


            dataGridViewCollector.AllowUserToAddRows = false;
            dataGridViewCollector.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCollector.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCollector.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

            dataGridViewCollector.DataSource = table2;
            dataGridViewCollector.Refresh();
        }



        private void buttonComeBackToMenu_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
            this.Close();
        }

        private void textBoxCoinFind_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxCoinFind.Text.ToLower();


            table.Rows.Clear();




            foreach (Coin coin in CoinList.coinlist)
            {
                if (coin.name.ToLower().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    table.Rows.Add(coin.name, coin.country, coin.issueOfTheCoin, coin.amount, coin.denomination, coin.metal, coin.feature);
                }
            }

        }

        private void textBoxCollectorFind_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxCollectorFind.Text.ToLower();


            table2.Rows.Clear();




            foreach (Collector collector in CollectorList.collectorlist)
            {
                if (collector.name.ToLower().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    table2.Rows.Add(collector.name, collector.country, collector.phone, collector.rarecoins);
                }
            }
        }
    }
}

