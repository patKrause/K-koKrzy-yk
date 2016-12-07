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

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {   
                wygral = true; 
                A1.BackColor = Color.Green; 
                B1.BackColor = Color.Green;
                C1.BackColor = Color.Green;
            } else
                if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                wygral = true;
                A2.BackColor = Color.Green;
                B2.BackColor = Color.Green;
                C2.BackColor = Color.Green;
            } else
                    if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                wygral = true;
                A3.BackColor = Color.Green;
                B3.BackColor = Color.Green;
                C3.BackColor = Color.Green;
            }
            if (wygral)
            {
                string wygrany = "";
                if (tura)
                    wygrany = "O";
                else
                    wygrany = "X";
                MessageBox.Show(wygrany + " Wygrał", "Finito");
            }
            

        }
    }
}