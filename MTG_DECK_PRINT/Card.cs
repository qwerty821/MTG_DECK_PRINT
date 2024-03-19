using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_DECK_PRINT
{
    internal class Card
    {
        private int _width = 238; // px * 1.7
        private int _height = 332;
        public string _path;

        public float Coef
        {
            set
            {
                if (value > 0)
                {
                    _width = (int)(DefaultConstants.CardWidth * 3.7 * value);
                    _height = (int)(DefaultConstants.CardHeight * 3.7 * value);
                }

            }
            get => Coef;
        }
        public Card(string path) { 
            _path = path;
            Coef = 1.7F;
        }

        public Panel GetCardAsPanel()
        {
            Panel cardPanel = new Panel();
            cardPanel.AutoSize = true;
            
            PictureBox pictureBox = new PictureBox();
            Image image = Image.FromFile(_path);
            pictureBox.Image = image.Resize(_width, _height);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

            cardPanel.Controls.Add(pictureBox);

            return cardPanel;
        }
    }
}
