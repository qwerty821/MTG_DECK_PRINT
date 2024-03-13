using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_DECK_PRINT
{
    internal class Deck
    {
        private Thread _thread;
        public List<Card> deck;
        private Panel _panelToDraw;
        public Deck() { 
            deck = new List<Card>();
        }

        public void ReadCards(string path)
        {
            List<string> cards_path = new List<string>(); 
            cards_path = CardReader.ReadFromFolder(path);
            
            foreach(string card_file in cards_path) { 
                deck.Add(new Card(card_file));
            }
        }
        public void asyncWriteCards(object? panel)
        {
            foreach (Card card in deck)
            {
                _panelToDraw.Controls.Add(card.GetCard());
            }
        }
        public void WriteCards(Panel panel) 
        {
            _panelToDraw = panel;
            _thread = new Thread(new ParameterizedThreadStart(asyncWriteCards));
            _thread.Start();
        }

        public List<Card> GetDeck() {
            return deck;
        }
    }
}
