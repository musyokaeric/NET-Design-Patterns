// Factory Method Pattern:
// =======================
// Defines an interface for creating an object, but leaves the choice
// of its type to the subclasses, creating an instance of one of several possible classes.

// Usage:
// ======
Creator creator = new ConcreteCreatorA();
IProduct product = creator.FactoryMethod();
product.Display();

// Real-life Use Case: Document Processing in a Word Processing Application:
// =========================================================================
// Consider a word processing application that supports multiple document formats (e.g., DOCX, PDF, TXT).
// The Factory Method pattern can be applied to create document-specific processors.

// Usage:
// ======
DocumentProcessor docxProcessor = new DOCXDocumentProcessor();
IDocument docxDocument = docxProcessor.CreateDocument();
docxDocument.Open();
docxDocument.Save();

DocumentProcessor pdfProcessor = new PDFDocumentProcessor();
IDocument pdfDocument = pdfProcessor.CreateDocument();
pdfDocument.Open();
pdfDocument.Save();

// In this example, the "DocumentProcessor" is a Factory (Creator) providing a method "CreateDocument()",
// and the concrete creators ("DOCXDocumentProcessor" and "PDFDocumentProcessor") implement this method
// to create specific document types. This allows the application to add support for new document
// formats without modifying existing code.
