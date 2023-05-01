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
        List<user> users = new List<user>();





        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            users.Add(new user("Silver dollar", "Uk", 1834, 10, "cent", "metal", "Krutaya"));
            users.Add(new user("5 Cents", "Uk", 2010, 14, "cent", "metal", "Krutaya"));
            users.Add(new user("Gold doubloon", "Uk", 1787, 67, "cent", "metal", "Krutaya"));
            users.Add(new user("Brazilian gold coin", "Uk", 1851, 94, "cent", "metal", "Krutaya"));
            users.Add(new user("Silver dollar 1st class", "Uk", 1834, 10, "cent", "metal", "Krutaya"));

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
            dataGridView1.DataSource = table;


        }
    }
}
