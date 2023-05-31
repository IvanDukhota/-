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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            this.MinimumSize = new Size(816, 489);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Open1Button_Click(object sender, EventArgs e)
        {
            Form Form3 = new GeneralCollection();
            Form3.Show();
            this.Close();

        }

        private void Open2Button_Click(object sender, EventArgs e)
        {
            Form Form4 = new OwnCollection();
            Form4.Show();
            this.Close();

        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
