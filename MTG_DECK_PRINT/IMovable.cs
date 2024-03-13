using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_DECK_PRINT
{
    internal interface IMovable
    {
        public void Form1_MouseDown(object sender, MouseEventArgs e);
        public void Form1_MouseMove(object sender, MouseEventArgs e);
        public void Form1_MouseUp(object sender, MouseEventArgs e);
    }
}
