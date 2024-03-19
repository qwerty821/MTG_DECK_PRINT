using Microsoft.AspNetCore.Components;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using Document = QuestPDF.Fluent.Document;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;


namespace MTG_DECK_PRINT
{
    public partial class Form2 : Form
    {
        const float w = 63;
        const float h = 88;
        const Unit unit = Unit.Millimetre;
        const float spacing = DefaultConstants.Spacing;
        const string color = Colors.White;
        const float marginTop = 10;
        const float marginBottom = 10;

        Deck cards;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClose?.Invoke(sender, e);
        }
        
        private void pdfButton_Click(object sender, EventArgs e)
        {





            //-------------------------------------


            int nr = cards.nrCards;
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Header().Height(10, unit).Column(col =>
                    {
                        //col.Item().AlignCenter().Row(row =>
                        //{
                        //    row.ConstantItem(spacing, unit).Background(color);
                        //    row.ConstantItem(w, unit).Height(10, unit).Background(Colors.Transparent);
                        //    row.ConstantItem(spacing, unit).Background(color);
                        //    row.ConstantItem(w, unit).Height(10, unit).Background(Colors.Transparent);
                        //    row.ConstantItem(spacing, unit).Background(color);
                        //    row.ConstantItem(w, unit).Height(10, unit).Background(Colors.Transparent);
                        //    row.ConstantItem(spacing, unit).Background(color);
                        //});
                    });

                    page.Content().Column(col =>
                    {
                        col.Item().Height(spacing, unit).Background(color).Width(210, unit);
                        for (int i = 0; i < nr; i++)
                        {
                            col.Item().AlignCenter().Row(row =>
                            {
                                row.ConstantItem(spacing, unit).Background(color);
                                for (int j = 0; j < 3 && i < nr; j++, i++)
                                {
                                    row.ConstantItem(w, unit).Image(cards.GetCardByIndex(i)._path);
                                    row.ConstantItem(spacing, unit).Background(color);
                                    Console.WriteLine(i);
                                }
                                i--;
                            });
                            col.Item().Height(spacing, unit).Background(color).Width(210, unit);
                            if (i == nr - 1)
                            {
                                for (int j = i; j % 3 != 0; j++)
                                {

                                }
                            }
                        }
                    });

                });
                //}).ShowInPreviewer();
            }).GeneratePdf("deck.pdf");
        }

        public void Draw()
        {
            if (cardsView.InvokeRequired)
            {
                cardsView.BeginInvoke((MethodInvoker)delegate ()
                {
                    foreach (Card card in cards.GetDeck())
                    {
                        cardsView.Controls.Add((card).GetCardAsPanel());
                    }
                });
            }
            else
            {
                foreach (Card card in cards.GetDeck())
                {
                    cardsView.Controls.Add((card).GetCardAsPanel());
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cards = new Deck();
            cards.ReadCards(Constants.Path);
            //Thread t = new Thread(new ThreadStart(Draw));
            //t.Start();
          
        }
    }
}
