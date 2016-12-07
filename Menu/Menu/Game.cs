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


            sprawdzKtoWygr();
        }
        private void sprawdzKtoWygr()
        {
            bool wygral = false;
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text))
                wygral = true;
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text))
                wygral = true;
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text))
                wygral = true;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text))
                wygral = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text))
                wygral = true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text))
                wygral = true;
        }
    }
}