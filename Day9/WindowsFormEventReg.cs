using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                string Name = name.Text;
                string Number = number.Text;
                string Mail = mail.Text;
                string Amount = amount.Text;
                string Mode = mode.Text;

                string checkbox = "";
                if (music.Checked) checkbox = "Music";
                else if (dance.Checked) checkbox = "Dance";
                else if (song.Checked) checkbox = " Song";

                string path = @"C:\Myfolder";

                Document doc = new Document();
                string path1 = Path.Combine(path, $"{Name} Form.pdf");
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path1, FileMode.Create));
                doc.Open();

                Paragraph heading = new Paragraph("Event Registration Form\n\n");

                heading.Alignment = Element.ALIGN_CENTER;

                doc.Add(heading);

                doc.Add(new Paragraph("Name: "+Name ));
                doc.Add(new Paragraph("Contact Number: "+Number));
                doc.Add(new Paragraph($"Email:{Mail} \n"));

                doc.Add(new Paragraph("\n\nSelect Any Event\n"));

                PdfContentByte cb = writer.DirectContent;


            float startX = 50;
            float startY = 620;
            float boxSize = 20;
            float spacing = 30;

            // Music checkbox
            DrawCheckBox(cb, startX, startY, boxSize, music.Checked);
            ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT, new Phrase("Music"), startX + 25, startY, 0);

            // Song checkbox
            DrawCheckBox(cb, startX, startY - spacing, boxSize, song.Checked);
            ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT, new Phrase("Song"), startX + 25, startY - spacing, 0);

            // Dance checkbox
            DrawCheckBox(cb, startX, startY - 2 * spacing, boxSize, dance.Checked);
            ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT, new Phrase("Dance"), startX + 25, startY - 2 * spacing, 0);



            doc.Add(new Paragraph("\n\n\n\n\n\nPayment details \n"));
                doc.Add(new Paragraph("Amount paid: "+Amount));
                doc.Add(new Paragraph("Payment mode : "+Mode));

                doc.Close();
                MessageBox.Show("PDF Generated");
            

        }
        private void DrawCheckBox(PdfContentByte cb, float x, float y, float size, bool isChecked)
        {
            // Draw the box
            cb.Rectangle(x, y, size, size);
            cb.Stroke();

            if (isChecked)
            {
                // ZapfDingbats font has a standard checkmark at code 51 ('3')
                BaseFont bf = BaseFont.CreateFont(BaseFont.ZAPFDINGBATS, BaseFont.WINANSI, BaseFont.NOT_EMBEDDED);
                cb.BeginText();
                cb.SetFontAndSize(bf, size);
                cb.ShowTextAligned(Element.ALIGN_CENTER, "3", x + size / 2, y + 1, 0);
                cb.EndText();
            }
        }



    }
}
