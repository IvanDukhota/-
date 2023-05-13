using System.CodeDom.Compiler;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;

namespace Довідник_нумізмата
{
    public partial class Form1 : Form
    {


        public struct user
        {
            public string name;
            public string country;
            public int issueOfTheCoin;
            public int amount;
            public string denomination;
            public string metal;
            public string feature;




            public user(string _name, string _country, int _issueOfTheCoin, int _amount, string _denomination, string _metal, string _feature)
            {
                name = _name;
                issueOfTheCoin = _issueOfTheCoin;
                amount = _amount;
                denomination = _denomination;
                metal = _metal;
                feature = _feature;
                country = _country;



            }
        }
        public struct Collector
        {
            public string Name;
            public string Country;
            public int Phone;
            public string Rarecoins;

            public Collector(string name, string country, int phone, string rarecoins)
            {
                Name = name;
                Country = country;
                Phone = phone;
                Rarecoins = rarecoins;
            }
        }
        List<Collector> collectorsList = new List<Collector>();
        List<user> users = new List<user>();





        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.AllowUserToAddRows = false;
            users.Add(new user("Silver dollar", "Uk", 1834, 10, "cent", "metal", "Krutaya"));
            users.Add(new user("5 Cents", "Uk", 2010, 14, "cent", "metal", "Krutaya"));
            users.Add(new user("Gold doubloon", "Uk", 1787, 67, "cent", "metal", "Krutaya"));
            users.Add(new user("Brazilian gold coin", "Uk", 1851, 94, "cent", "metal", "Krutaya"));
            users.Add(new user("Silver dollar 1st class", "Uk", 1834, 10, "cent", "metal", "Krutaya"));
            users.Add(new user("Kopiyka", "Ukraine", 1992, 10000, "Kopiyka", "metal", "Krutaya"));
            users.Add(new user("Australian penny", "Australia", 1930, 100, "penny", "metal", "Krutaya"));
            users.Add(new user("Dinar Hashimi", "Uk", 737, 10, "cent", "metal", "Krutaya"));

            DataTable table = new DataTable();
            table.Columns.Add("Ім'я монети", typeof(string));
            table.Columns.Add("Країна", typeof(string));
            table.Columns.Add("Рік випуску", typeof(int));
            table.Columns.Add("Кількість випущених монет", typeof(int));
            table.Columns.Add("Номінал", typeof(string));
            table.Columns.Add("Метал або сплав", typeof(string));
            table.Columns.Add("Особливості", typeof(string));
            for (int i = 0; i < users.Count; i++)
            {
                table.Rows.Add(users[i].name, users[i].country, users[i].issueOfTheCoin, users[i].amount, users[i].denomination, users[i].metal, users[i].feature);

            }
            dataGridView.DataSource = table;


            dataGridView1.AllowUserToAddRows = false;
            collectorsList.Add(new Collector("John Doe", "USA", 123456789, "kopiyka, Dinar Hashimi"));
            collectorsList.Add(new Collector("Jane Smith", "Canada", 987654321, "5 Cents"));
            collectorsList.Add(new Collector("Ivan Ivanovich", "Ukraine", 0663456754, "Kopiyka"));
            collectorsList.Add(new Collector("Maria Wowka", "Spain", 776935636, "Australian penny"));
            collectorsList.Add(new Collector("Serhiy Wowka", "Spain", 384673481, "Brazilian gold coin"));
            collectorsList.Add(new Collector("Marik Sigma", "Canada", 991698321, "Silver dollar 1st class"));
            collectorsList.Add(new Collector("Volodymir Makrovko", "Germany", 620664321, "5 Cents"));
            collectorsList.Add(new Collector("Icon Heetsovich", "Netherlands", 987678011, "Silver dollar"));
            DataTable collectorsTable = new DataTable();
            collectorsTable.Columns.Add("Ім'я", typeof(string));
            collectorsTable.Columns.Add("Країна проживання", typeof(string));
            collectorsTable.Columns.Add("Номер телефону", typeof(int));
            collectorsTable.Columns.Add("Рідкісні монети", typeof(string));
            foreach (Collector collector in collectorsList)
            {
                collectorsTable.Rows.Add(collector.Name, collector.Country, collector.Phone, collector.Rarecoins);
            }
            dataGridView1.DataSource = collectorsTable;

        }
        private void buttonShowCoinInfo_Click(object sender, EventArgs e)
        {
            string coinName = textBoxCoinName.Text;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Ім'я монети"].Value.ToString() == coinName)
                {
                    string coinInfo = "Назва: " + row.Cells["Ім'я монети"].Value.ToString() + "\n" +
                                   "Країна: " + row.Cells["Країна"].Value.ToString() + "\n" +
                                   "Рік випуску: " + row.Cells["Рік випуску"].Value.ToString() + "\n" +
                                   "Кількість випущенних монет: " + row.Cells["Кількість випущених монет"].Value.ToString() + "\n" +
                                   "Номінал: " + row.Cells["Номінал"].Value.ToString() + "\n" +
                                   "Метал або сплав: " + row.Cells["Метал або сплав"].Value.ToString() + "\n" +
                                   "Особливості: " + row.Cells["Особливості"].Value.ToString();
                    richTextBox1.Text = coinInfo;
                    break;
                }
                else
                {
                    richTextBox1.Text = "Монета с названием \"" + coinName + "\" не найдена.";
                }
            }











        }

        private void buttonShowCollectorInfo_Click(object sender, EventArgs e)
        {
            string collectorName = textBoxCollectorName.Text;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Ім'я"].Value.ToString() == collectorName)
                {
                    string collectorInfo = "Ім'я: " + row.Cells["Ім'я"].Value.ToString() + "\n" +
                                   "Країна: " + row.Cells["Країна проживання"].Value.ToString() + "\n" +
                                   "Номер телефону: " + row.Cells["Номер телефону"].Value.ToString() + "\n" +                                
                                   "Рідкісні монети: " + row.Cells["Рідкісні монети"].Value.ToString();
                    richTextBox2.Text = collectorInfo;
                    break;
                }
                else
                {
                    richTextBox2.Text = "Колекціонер  з ім'ям \"" + collectorName + "\" не знайден.";
                }
            }
        }
    }
}
