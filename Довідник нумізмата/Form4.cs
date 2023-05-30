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
using static Довідник_нумізмата.Form3;

namespace Довідник_нумізмата
{
    public partial class Form4 : Form
    {




        public Form4()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            string file2 = "C:\\Users\\PC\\source\\repos\\Довідник нумізмата\\Довідник нумізмата\\txt files\\owncollection.txt";
            Data.LoadOwnCollectionFromFile(file2);
            PrintOwnCollection();

        }
        DataTable table2 = new DataTable();

        private void PrintOwnCollection()
        {
            dataGridViewOwnCoinInfo.DataSource = null;
            table2.Rows.Clear();
            table2.Columns.Clear();
            table2.Columns.Add("ім'я", typeof(string));
            table2.Columns.Add("Країна", typeof(string));
            table2.Columns.Add("Рік випуску", typeof(int));
            table2.Columns.Add("Кількість випущених монет", typeof(int));
            table2.Columns.Add("Номінал", typeof(string));
            table2.Columns.Add("Метал або сплав", typeof(string));
            table2.Columns.Add("Особливості", typeof(string));

            foreach (OwnCollection owncollection in OwnCollectionList.owncollectionlist)
            {
                table2.Rows.Add(owncollection.name1, owncollection.country1, owncollection.issueOfTheCoin1, owncollection.amount1, owncollection.denomination1, owncollection.metal1, owncollection.feature1);
            }
            dataGridViewOwnCoinInfo.AllowUserToAddRows = false;
            dataGridViewOwnCoinInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewOwnCoinInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewOwnCoinInfo.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

            dataGridViewOwnCoinInfo.DataSource = table2;
            dataGridViewOwnCoinInfo.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();


            table2.Rows.Clear();




            foreach (OwnCollection owncollection in OwnCollectionList.owncollectionlist)
            {
                if (owncollection.name1.ToLower().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    table2.Rows.Add(owncollection.name1, owncollection.country1, owncollection.issueOfTheCoin1, owncollection.amount1, owncollection.denomination1, owncollection.metal1, owncollection.feature1);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
            this.Close();
        }
    }

}


