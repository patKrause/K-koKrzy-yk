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
    public partial class Game : Form
    {
        bool tura = true;
        public Game()
        {
            InitializeComponent();
        }


        private void click_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (tura)
                b.Text = "X";
            else
                b.Text = "O";
            tura = !tura;
            b.Enabled = false;

            Winner.sprawdzKtoWygr();

        }

    }
}
