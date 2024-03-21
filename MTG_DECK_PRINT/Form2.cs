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
using System.Threading;
using Microsoft.Extensions.Primitives;


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
        int timePerPage = 3;
        Deck cards;


        public delegate void PrintEventHandler();
        private event PrintEventHandler printIsDone;

        bool buttonPrintIsPressed = false;

        public Form2()
        {
            InitializeComponent();
        }


        private CancellationTokenSource _cancelToken = null;

        private void Form2_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClose?.Invoke(sender, e);
        }

        private async Task printCards()
        {
            await Task.Run(() =>
            {

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
                            }
                        });

                    });
                }).GeneratePdf("deck.pdf");

                printIsDone.Invoke();

            });
        }

        private async Task progressBar()
        {
            try
            {
                await Task.Run(() =>
                 {
                     for (int i = 0; i < progressBar1.Maximum - 5; i++)
                     {
                         Thread.Sleep(1);
                         _cancelToken.Token.ThrowIfCancellationRequested();
                         progressBar1.Value += 1;
                     }
                 });
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync("aaasdasdasd");
            }
        }
        private async Task DrawAsync()
        {
            foreach (Card card in cards.GetDeck())
            {
                await Draww(card);
            }

        }

        private async Task Draww(Card card)
        {

            await Task.Run(() =>
            {
                cardsView.Invoke((MethodInvoker)delegate
                {
                    cardsView.Controls.Add((card).GetCardAsPanel());
                });
            });

        }
 
       

        private async void buttonPrint_Click(object sender, EventArgs e)
        {
            buttonPrint.Enabled = false;

            _cancelToken = new CancellationTokenSource();
            Task taskPrint = printCards();
            Task taskPogressBar = progressBar();

            await Task.WhenAll(taskPrint, taskPogressBar);
            
            buttonPrint.Enabled = true;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (buttonPrintIsPressed)
            {
                _cancelToken.Cancel();
            }
        }

        private async void buttonLoad_Click(object sender, EventArgs e)
        {
            if (!buttonPrintIsPressed)
            {
                buttonPrintIsPressed = true;

                buttonLoad.Enabled = false;

                cards = new Deck();
                cards.ReadCards(Constants.Path);

                progressBar1.Maximum = (cards.nrCards / 9) * timePerPage * 100;
                progressBar1.Minimum = 0;
                progressBar1.Value = 0;
                
                await DrawAsync();

                printIsDone += () =>
                {
                    _cancelToken.Cancel();
                    progressBar1.Value = progressBar1.Maximum;
                    MessageBox.Show("Completed");
                };

                buttonPrintIsPressed = true;
            }
        }
    }
}
