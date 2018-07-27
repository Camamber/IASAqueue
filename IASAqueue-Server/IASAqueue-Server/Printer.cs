using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IASAqueue_Server
{
    class Printer
    {
        int number = 0;
        string printerName;
        public Printer(string printerName)
        {
            this.printerName = printerName;
        }

        public static string[] GetPrinters()
        {
           List<string> printers = new List<string>();
            foreach (object ps in PrinterSettings.InstalledPrinters)
                printers.Add(ps.ToString());
            return printers.ToArray();
        }
        public void Print(int number)
        {
            this.number = number;
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "IASA Queue #"+number;
            printDoc.PrintPage += PrintPageHandler;
            printDoc.PrintController = new StandardPrintController();

            PrinterSettings ps = new PrinterSettings();
            ps.PrinterName = printerName;
            printDoc.PrinterSettings = ps;
            printDoc.Print();

            //// --------------------------------------

            ////Uncomment if debugging - shows dialog instead
            //PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
            //printPrvDlg.Document = printDoc;
            //printPrvDlg.Width = 228;
            //printPrvDlg.Height = 500;
            //printPrvDlg.ShowDialog();

            //// --------------------------------------

            printDoc.Dispose();
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            //PrivateFontCollection pfc = new PrivateFontCollection();
            //pfc.AddFontFile("BebasNeue.otf");
            FontFamily bebas = new FontFamily("Arial");
            Point center = new Point(0, 0);
            SizeF z = new SizeF();
            Font font;

            z = new SizeF(50, 50);
            center.X = (int)((e.PageBounds.Width - z.Width - e.MarginBounds.Width) / 2);
            e.Graphics.DrawImage(Image.FromFile("logo.png"), center.X, 0, z.Width, z.Height);

            center.Y += (int)(1.1 * z.Height);
            font = new Font(bebas, 14);
            z = e.Graphics.MeasureString("Поздравляем, вы:", font);
            center.X = (int)((e.PageBounds.Width - z.Width - e.MarginBounds.Width) / 2);
            e.Graphics.DrawString("Поздравляем, вы:", font, Brushes.Black, center.X, center.Y);

            center.Y += (int)(0.9 * z.Height);
            font = new Font(bebas, 40, FontStyle.Bold);
            z = e.Graphics.MeasureString(number.ToString(), font);
            center.X = (int)((e.PageBounds.Width - z.Width - e.MarginBounds.Width) / 2);
            e.Graphics.DrawString(number.ToString(), font, Brushes.Black, center.X, center.Y);

            center.Y += (int)(0.9 * z.Height);
            font = new Font(bebas, 11, FontStyle.Italic);
            z = e.Graphics.MeasureString("Хе-хе-хе...", font);
            center.X = (int)((e.PageBounds.Width - z.Width - e.MarginBounds.Width) / 2);
            e.Graphics.DrawString("Хе-хе-хе...", font, Brushes.Black, 0, center.Y);

            font.Dispose();
            bebas.Dispose();
            //pfc.Dispose();
        }
    }
}
