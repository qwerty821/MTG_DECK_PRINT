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
        public int nrCards { private set; get; }
        
        public Deck() { 
            deck = new List<Card>();
        }

        public void ReadCards(string path)
        {
            List<string> cards_path = new List<string>(); 
            cards_path = CardReader.ReadFromFolder(path);
            
            foreach(string card_file in cards_path) { 
                deck.Add(new Card(card_file));
                nrCards++;
            }
        }

        public Card GetCardByIndex(int index)
        {   
            try
            {
                return deck.ElementAt(index);
            } catch (Exception e) { 
                MessageBox.Show("Out of Range");
            }
            return null;
        }

        public List<Card> GetDeck() {
            return deck;
        }

      
    }
}
