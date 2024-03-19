using System.Collections;
using System.Linq;

namespace MTG_DECK_PRINT
{
    static class CardReader
    {

        static CardReader() { }

        public static List<string> ReadFromFolder(string folder)
        {
            List<string> cards = new List<string>();
            DirectoryInfo directoryInfo = new DirectoryInfo(folder);
            cards.AddRange(Directory.GetFiles(folder, "*.*")
                .Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".bmp")));
            
            return cards; 
        }
    }
}
