using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Winner
    {
        
        public static void sprawdzKtoWygr(Game game)
        {
            bool wygrany = false;
            if ((game.A1.Text == game.B1.Text) && (game.B1.Text == game.C1.Text)) 
                wygrany = true;

        }
    }
}
