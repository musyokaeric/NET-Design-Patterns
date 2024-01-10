namespace SOLID.SingleResponsibility
{
    // Without SRP
    public class Report
    {
        public string Content { get; set; } = "Report Content";

        public void SaveToFile(string fileName)
        {
            // Save the report content to a file
            Console.WriteLine("Saved: " + Content);
        }

        public void Print()
        {
            // Print the report
            Console.WriteLine("Printed: " + Content);
        }

        // In this example, the Report class violates SRP because it has both responsibilities of saving to a file and printing.
    }
}
