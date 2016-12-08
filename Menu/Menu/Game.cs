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
        bool ruch = true;
        int tura = 0;
        public Game()
        {
            InitializeComponent();
        }


        private void click_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (ruch)
                b.Text = "X";
            else
                b.Text = "O";
            tura++;
            ruch = !ruch;
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
            } else
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                wygral = true;
                A1.BackColor = Color.Green;
                A2.BackColor = Color.Green;
                A3.BackColor = Color.Green;
            } else
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                wygral = true;
                B1.BackColor = Color.Green;
                B2.BackColor = Color.Green;
                B3.BackColor = Color.Green;
            } else
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                wygral = true;
                C1.BackColor = Color.Green;
                C2.BackColor = Color.Green;
                C3.BackColor = Color.Green;
            } else
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                wygral = true;
                A1.BackColor = Color.Green;
                B2.BackColor = Color.Green;
                C3.BackColor = Color.Green;
            } else
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                wygral = true;
                A3.BackColor = Color.Green;
                B2.BackColor = Color.Green;
                C1.BackColor = Color.Green;
            } 
            
            if (wygral)
            {
                string wygrany = "";
                if (ruch)
                {
                    wygrany = nick1.Text;
                    p1.Text = (Int32.Parse(p1.Text) + 1).ToString();
                }
                else
                {
                    wygrany = nick2.Text;
                    p2.Text = (Int32.Parse(p2.Text) + 1).ToString();
                }
                MessageBox.Show(wygrany + " Wygrał", "Finito!");
                zerowanie();
            }
            else
            {
                if (tura == 9)
                {
                    MessageBox.Show("Remis!", "Opps!");
                    liczRemis.Text = (Int32.Parse(liczRemis.Text) + 1).ToString();
                    zerowanie();
                }
            }
            

        }
        private void zerowanie()
        {
            foreach (Control x in Controls)
            {
                if (x is Button)
                {
                    Button b = (Button)x;
                    b.Enabled = true;
                    b.BackColor = System.Drawing.Color.Transparent;
                    if (b.Text == "Restart") b.Text = "Restart"; else b.Text = "";
                    tura = 0;
                }
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void wynikRestart(object sender, EventArgs e)
        {
            p1.Text = "0";
            p2.Text = "0";
            liczRemis.Text = "0";
        }
    }
}