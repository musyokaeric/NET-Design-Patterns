// Visitor Pattern:
// ================
// Represent an operation to be performed on the elements of an object structure. Visitor
// lets you define a new operation without changing the classes of the elements on which it operates.
// Example in .NET:
// Let's implement a visitor pattern for a document structure where different elements are visited by a printer.

// Element
public interface IElement
{
    void Accept(IVisitor visitor);
}

// Concrete Elements
public class TextElement : IElement
{
    public string Text { get; set; }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitTextElement(this);
    }
}

public class ImageElement : IElement
{
    public string ImagePath { get; set; }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitImageElement(this);
    }
}

// Visitor
public interface IVisitor
{
    void VisitTextElement(TextElement element);
    void VisitImageElement(ImageElement element);
}

// Concrete Visitor
public class DocumentPrinter : IVisitor
{
    public void VisitTextElement(TextElement element)
    {
        Console.WriteLine($"Printing text: {element.Text}");
    }

    public void VisitImageElement(ImageElement element)
    {
        Console.WriteLine($"Printing image: {element.ImagePath}");
    }
}

// Real - life Use Case:  Document Export to Different Formats
// ===========================================================
// Consider a document processing application that allows users to create different types of
// documents (e.g., text documents, spreadsheets, images) and export them to various
// formats (e.g., PDF, HTML, plain text). The Visitor pattern can be applied to implement a document
// export functionality without modifying the structure of the document classes.


// Element interface
public interface IDocument
{
    void Accept(IDocumentExporter exporter);
}

// Concrete Elements
public class TextDocument : IDocument
{
    public string Text { get; set; }

    public void Accept(IDocumentExporter exporter)
    {
        exporter.ExportTextDocument(this);
    }
}

public class SpreadsheetDocument : IDocument
{
    public string Data { get; set; }

    public void Accept(IDocumentExporter exporter)
    {
        exporter.ExportSpreadsheetDocument(this);
    }
}

public class ImageDocument : IDocument
{
    public byte[] ImageData { get; set; }

    public void Accept(IDocumentExporter exporter)
    {
        exporter.ExportImageDocument(this);
    }
}

// Visitor interface
public interface IDocumentExporter
{
    void ExportTextDocument(TextDocument document);
    void ExportSpreadsheetDocument(SpreadsheetDocument document);
    void ExportImageDocument(ImageDocument document);
}

// Concrete Visitor
public class DocumentExporter : IDocumentExporter
{
    public void ExportTextDocument(TextDocument document)
    {
        Console.WriteLine($"Exporting Text Document: {document.Text}");
        // Logic for exporting to specific format (e.g., PDF, HTML, plain text)
    }

    public void ExportSpreadsheetDocument(SpreadsheetDocument document)
    {
        Console.WriteLine($"Exporting Spreadsheet Document: {document.Data}");
        // Logic for exporting to specific format (e.g., Excel, CSV)
    }

    public void ExportImageDocument(ImageDocument document)
    {
        Console.WriteLine("Exporting Image Document");
        // Logic for exporting to specific format (e.g., JPEG, PNG)
    }
}

// Client
public class DocumentProcessingClient
{
    public void Run()
    {
        var documents = new List<IDocument>
        {
            new TextDocument { Text = "Sample text content" },
            new SpreadsheetDocument { Data = "1, 2, 3\n4, 5, 6" },
            new ImageDocument { ImageData = new byte[] { /* Image data */ } }
        };

        var exporter = new DocumentExporter();

        foreach (var document in documents)
        {
            document.Accept(exporter);
            Console.WriteLine(); // Add a separator between documents
        }
    }
}
