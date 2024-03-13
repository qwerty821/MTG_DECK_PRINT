using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_DECK_PRINT
{
    public partial class Form2
    {
        public delegate void FormHandler(object sender, EventArgs e);
        public event FormHandler? FormClose;

        private bool mouseDown;
        private Point lastLocation;

        private void Form2_MouseUp(object sender, MouseEventArgs e) => mouseDown = false;
        
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}
