using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Patryk Krause 2016", "O mnie");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Game form2 = new Game();
            form2.ShowDialog();
            this.Close();
        }

    }
}
