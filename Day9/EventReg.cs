using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

public class EventReg
{
    static void Main(string[] args)
    {
        string path = @"C:\Myfolder1";

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Console.WriteLine("Folder created successfully");

            Document doc = new Document();
            string path1 = Path.Combine(path, "EventReg.pdf");
            PdfWriter writer= PdfWriter.GetInstance(doc, new FileStream(path1, FileMode.Create));
            doc.Open();

            Paragraph heading = new Paragraph("Event Registration Form\n\n",
                               new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD));

            
            heading.Alignment = Element.ALIGN_CENTER;

            doc.Add(heading);

            doc.Add(new Paragraph("Name: _______________________________"));
            doc.Add(new Paragraph("Contact Number: _______________________________"));
            doc.Add(new Paragraph("Email: _______________________________\n"));

            doc.Add(new Paragraph("\n\nSelect Any Event\n"));

            PdfContentByte cb = writer.DirectContent;

            
            cb.Rectangle(50, 620, 20, 20);
            cb.Stroke();

            cb.Rectangle(50, 590, 20, 20);
            cb.Stroke();

            cb.Rectangle(50, 560, 20, 20);
            cb.Stroke();

            
            ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT, new Paragraph("Music"), 80, 620, 0);
            ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT, new Phrase("Song"), 80, 590, 0);
            ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT, new Phrase("Dance"), 80, 560, 0);





            doc.Add(new Paragraph("\n\n\n\n\n\nPayment details \n"));
            doc.Add(new Paragraph("Amount paid: ________________________"));
            doc.Add(new Paragraph("Payment mode (Gpay , Cash , Card : __________________"));


            doc.Add(new Paragraph("\n\n Signature: ______________________"));



            doc.Close();
    }
        else
        {
            string choose;
            Console.WriteLine("The folder already exist");
            Console.WriteLine("Do you want to delete the folder and the files (y/n)");
            choose = Console.ReadLine();
            if (choose == "y")
            {
                Directory.Delete(path, true);
                Console.WriteLine("Folder deleted successfully ");
            }
            else
            {
                Console.WriteLine("Folder Not deleted");
            }

        }
    }
}

