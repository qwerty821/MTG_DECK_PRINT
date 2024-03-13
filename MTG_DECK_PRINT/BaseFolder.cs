using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTG_DECK_PRINT
{
    internal static class BaseFolder
    {
        private static string Path;

        


        public static string? GetFolder()
        {
            Path = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select a folder";
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.CheckPathExists = false;
            openFileDialog1.FileName = "move to folder with cards and press Open";
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowHelp = true; // This is the key for enabling folder selection
            openFileDialog1.CustomPlaces.Add(@"C:\"); // You can add custom places if needed

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = openFileDialog1.FileName;
                string t = "";
                bool ok = false;
                for (int i = selectedPath.Length - 1; i >= 0; i--)
                {
                    if (ok)
                    {
                        t += selectedPath[i];
                    }
                    if (selectedPath[i] == '\\') {
                        ok = true;
                    }
                }
                for (int i = t.Length - 1; i >= 0 ; i--)
                {
                    Path += t[i];
                }   
                return Path;
            }
            return null;
        }
 
    }
}
