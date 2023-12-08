namespace Mostenire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File f = new File("fisier1", "txt");
            f.Open();

            ExcelFile excelFile1 = new ExcelFile("Workbook", "2023");
            excelFile1.Open();
            excelFile1.PerformCalculation("a = b + c");

            PdfFile pdfFile1 = new PdfFile("Declaratie", true);
            pdfFile1.Open();
            pdfFile1.AttemptEdit();
        }
    }
}
