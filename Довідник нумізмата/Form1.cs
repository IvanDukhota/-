using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Довідник_нумізмата
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "admin" & PasswordTextBox.Text == "1111")
            {
                Form Form2 = new Form2();
                Form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильний пароль або логін.");
            }


        }

        
    }
}
