using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_DECK_PRINT
{
    internal static class DefaultConstants
    {
        public const float CardWidth = 63; // 238px
        public const float CArdHeight = 88; // 332px
        public const Unit UnitOfMeasurement = Unit.Millimetre;
        public const float Spacing = 0F;
        public const string ColorOfSpace = Colors.Red.Medium;
        public const float HeaderHeight = 10;
        public const float FooterHeight = 10;
       
        public static Font MtgFont { get; }
        
        static DefaultConstants()
        {
            PrivateFontCollection font = new PrivateFontCollection();
            font.AddFontFile(@"mtg\Fonts\MtgFont\mtg.ttf");
            MtgFont = new Font(font.Families[0], 12f, FontStyle.Regular);
        }
        
        
    }
}
