using System.Diagnostics;
using System.Drawing.Text;
using System.Reflection.Metadata;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using MTG_DECK_PRINT.Properties;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;


namespace MTG_DECK_PRINT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e) => this.Close();
        private void ExitEvent(object sender, EventArgs e) => this.Close();


        private void Form1_Load(object sender, EventArgs e)
        {

            //label1.Font = DefaultConstants.MtgFont;


        }


        private void button2_Click(object sender, EventArgs e)
        {
            string? path = BaseFolder.GetFolder();
            if (path == null)
            {
                MessageBox.Show("null path");
                return;
            }
            Constants.Path = path;
            Console.WriteLine("path = ", path);
            NextWindow();
        }

        private void NextWindow()
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show(this);
            form2.FormClose += button1_Click;
        }
        Form hoverForm = new Form();
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            hoverForm.Location = new Point(MousePosition.X, MousePosition.Y);
            hoverForm.Show();
             

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            hoverForm.Hide();
        }
    }
}
