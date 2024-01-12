// Visitor Pattern:
// ================
// Represent an operation to be performed on the elements of an object structure. Visitor
// lets you define a new operation without changing the classes of the elements on which it operates.
// Example in .NET:
// Let's implement a visitor pattern for a document structure where different elements are visited by a printer.

// Example usage
var document = new List<IElement>
{
    new TextElement { Text = "Hello, Visitor Pattern!" },
    new ImageElement { ImagePath = "/path/to/image.jpg" }
};

var documentPrinter = new DocumentPrinter();
foreach (var element in document)
{
    element.Accept(documentPrinter);
}
/* Output:
   Printing text: Hello, Visitor Pattern!
   Printing image: /path/to/image.jpg
*/

// Real - life Use Case:  Document Export to Different Formats
// ===========================================================
// Consider a document processing application that allows users to create different types of
// documents (e.g., text documents, spreadsheets, images) and export them to various
// formats (e.g., PDF, HTML, plain text). The Visitor pattern can be applied to implement a document
// export functionality without modifying the structure of the document classes.

// Example usage
var client = new DocumentProcessingClient();
client.Run();

