using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
    
class Program
{
    static void Main()
    {
        Document doc = new Document();
        PdfWriter.GetInstance(doc, new FileStream("sample.pdf", FileMode.Create));
        doc.Open();
        doc.Add(new Paragraph("Hello, this is my first PDF using iTextSharp!"));
        doc.Close();
    }
}
