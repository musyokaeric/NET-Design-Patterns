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
