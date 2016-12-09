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
        bool komp = false;
        int tura = 0;
        public Game()
        {
            InitializeComponent();
        }


        private void click_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (ruch)
                b.Text = "O";
            else
                b.Text = "X";
            tura++;
            ruch = !ruch;
            b.Enabled = false;


            sprawdzKtoWygr();
            czyKomp();
            if ((!ruch) && (komp))
            {
                ruchKomp();
            }
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
                    wygrany = nick2.Text;
                    p2.Text = (Int32.Parse(p2.Text) + 1).ToString();   
                }
                else
                {
                    wygrany = nick1.Text;
                    p1.Text = (Int32.Parse(p1.Text) + 1).ToString();
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
            ruch = !ruch;
            foreach (Control x in Controls)
            {
                ruch = !ruch;
                if (x is Button)
                {
                    Button b = (Button)x;
                    b.Enabled = true;
                    b.BackColor = System.Drawing.Color.Transparent;
                    if (b.Text == "Restart") continue;
                    if (b.Text == "Powrót") continue;
                    b.Text = "";
                    tura = 0;
                }
            }
        }


        private void wynikRestart(object sender, EventArgs e)
        {
            p1.Text = "0";
            p2.Text = "0";
            liczRemis.Text = "0";
        }

        private void pokazWej(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (ruch)
                    b.Text = "O";
                else
                    b.Text = "X";
            }
            
        }

        private void ukryjWej(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (ruch)
                    b.Text = "";
                else
                    b.Text = "";
            }

        }

        private void Powrot_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu form1 = new Menu();
            form1.ShowDialog();
            
            this.Close();

        }

        private void czyKomp()
        {
            if (nick2.Text == "Komputer") komp = true; else komp = false;
        }

        private void ruchKomp()
        {
            Button ustaw = null;
            ustaw = wygrajZablokuj("O");
            if (ustaw == null)
            {
                    ustaw = doKata();
                    if (ustaw == null)
                    {
                        ustaw = wolneMiejsce();
                    }
                }
            ustaw.PerformClick();
         }
    
            
        
        private Button wygrajZablokuj(string znak)
        {
            //POZIOMO
            if ((A1.Text == znak) && (A2.Text == znak) && (A3.Text == ""))
                return A3; 
            if ((A2.Text == znak) && (A3.Text == znak) && (A1.Text == ""))
                return A1; 
            if ((A1.Text == znak) && (A3.Text == znak) && (A2.Text == ""))
                return A2; 
            if ((B1.Text == znak) && (B2.Text == znak) && (B3.Text == ""))
                return B3; 
            if ((B2.Text == znak) && (B3.Text == znak) && (B1.Text == ""))
                return B1; 
            if ((B1.Text == znak) && (B3.Text == znak) && (B2.Text == ""))
                return B2; 
            if ((C1.Text == znak) && (C2.Text == znak) && (C3.Text == ""))
                return C3; 
            if ((C2.Text == znak) && (C3.Text == znak) && (C1.Text == ""))
                return C1; 
            if ((C1.Text == znak) && (C3.Text == znak) && (C2.Text == ""))
                return C2; 
            //SKOS
            if ((A1.Text == znak) && (B2.Text == znak) && (C3.Text == ""))
                return C3;
            if ((A3.Text == znak) && (B2.Text == znak) && (C1.Text == ""))
                return C1;
            if ((B2.Text == znak) && (C3.Text == znak) && (A1.Text == ""))
                return A1;
            if ((B2.Text == znak) && (C1.Text == znak) && (A3.Text == ""))
                return A3;
            if ((A1.Text == znak) && (C3.Text == znak) && (B2.Text == ""))
                return B2;
            if ((A3.Text == znak) && (C1.Text == znak) && (B2.Text == ""))
                return B2;
            // PION
            if ((A1.Text == znak) && (B1.Text == znak) && (C1.Text == ""))
                return C1;
            if ((A1.Text == znak) && (C1.Text == znak) && (B1.Text == ""))
                return B1;
            if ((B1.Text == znak) && (C1.Text == znak) && (A1.Text == ""))
                return A1;
            if ((A2.Text == znak) && (B2.Text == znak) && (C2.Text == ""))
                return C2;
            if ((A2.Text == znak) && (C3.Text == znak) && (B2.Text == ""))
                return B2;
            if ((B2.Text == znak) && (C2.Text == znak) && (A2.Text == ""))
                return A2;
            if ((A3.Text == znak) && (B3.Text == znak) && (C3.Text == ""))
                return C3;
            if ((A3.Text == znak) && (C3.Text == znak) && (B3.Text == ""))
                return B3;
            if ((B3.Text == znak) && (C3.Text == znak) && (A3.Text == ""))
                return A3; 
           
            
            return null;
        }
        private Button wolneMiejsce()
        {
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }

         return null;
        }
        private Button doKata()
        {
            if (A1.Text == "O")
            {
                if (C1.Text == "") return C1;
                if (A3.Text == "") return A3;
                if (C3.Text == "") return C3;
            }
            if (A3.Text == "O")
            {
                if (A1.Text == "") return A1;
                if (C1.Text == "") return C1;
                if (C3.Text == "") return C3;
            }
            if (C1.Text == "O")
            {
                if (A1.Text == "") return A1;
                if (A3.Text == "") return A3;
                if (C3.Text == "") return C3;
            }
            if (C3.Text == "O")
            {
                if (A1.Text == "") return A1;
                if (A3.Text == "") return A3;
                if (C1.Text == "") return C1;
            }
            return null;
        }
    }
}