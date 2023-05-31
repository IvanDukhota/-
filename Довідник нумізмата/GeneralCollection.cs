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
using static Довідник_нумізмата.OwnCollection;

namespace Довідник_нумізмата
{
    public partial class GeneralCollection : Form
    {


        public GeneralCollection()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1083, 657);
        }

        private bool deleteColumnAddedCoin = false;
        private bool deleteColumnAddedCollector = false;


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



        private void AddDeleteColumnForCoin()
        {
            if (!deleteColumnAddedCoin)
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.Name = "DeleteColumn";
                deleteColumn.HeaderText = "Видалити";
                deleteColumn.Text = "Видалити";
                deleteColumn.UseColumnTextForButtonValue = true;
                dataGridViewCoin.Columns.Add(deleteColumn);

                dataGridViewCoin.CellContentClick += DataGridViewCoin_CellContentClick;

                deleteColumnAddedCoin = true;
            }
        }

        private void AddDeleteColumnForCollector()
        {
            if (!deleteColumnAddedCollector)
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.Name = "DeleteColumn";
                deleteColumn.HeaderText = "Видалити";
                deleteColumn.Text = "Видалити";
                deleteColumn.UseColumnTextForButtonValue = true;
                dataGridViewCollector.Columns.Add(deleteColumn);

                dataGridViewCollector.CellContentClick += DataGridViewCollector_CellContentClick;

                deleteColumnAddedCollector = true;
            }
        }


        private void DataGridViewCoin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCoin.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                dataGridViewCoin.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void DataGridViewCollector_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCollector.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                dataGridViewCollector.Rows.RemoveAt(e.RowIndex);
            }
        }





        private void PrintCoin()
        {
            dataGridViewCoin.DataSource = null;
            table.Rows.Clear();
            table.Columns.Clear();

            AddDeleteColumnForCoin();
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

            AddDeleteColumnForCollector();
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
            Form Form2 = new menu();
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



        private void button1_Click(object sender, EventArgs e)
        {
            AddCoinAndCollector form6 = new AddCoinAndCollector();
            form6.ShowDialog();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            PrintCollector();
            PrintCoin();
        }
    }
}

