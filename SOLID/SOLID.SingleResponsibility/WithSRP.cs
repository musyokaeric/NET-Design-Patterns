namespace SOLID.SingleResponsibility
{
    // With SRP
    public class Report2
    {
        public string Content { get; set; } = "Report Content";
    }

    public class ReportSaver
    {
        public void SaveToFile(Report2 report, string fileName)
        {
            // Save the report content to a file
            Console.WriteLine("Saved: " + report.Content);
        }
    }

    public class ReportPrinter
    {
        public void Print(Report2 report)
        {
            // Print the report
            Console.WriteLine("Printed: " + report.Content);
        }
    }

    // Now, each class has a single responsibility: one for holding report data, one for saving to a file, and one for printing.
}
