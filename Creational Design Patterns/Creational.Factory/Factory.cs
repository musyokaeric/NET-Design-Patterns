// Factory Method Pattern:
// =======================
// Defines an interface for creating an object, but leaves the choice
// of its type to the subclasses, creating an instance of one of several possible classes.

public interface IProduct
{
    void Display();
}

public class ConcreteProductA : IProduct
{
    public void Display() => Console.WriteLine("Product A");
}

public class ConcreteProductB : IProduct
{
    public void Display() => Console.WriteLine("Product B");
}

public abstract class Creator
{
    public abstract IProduct FactoryMethod();
}

public class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod() => new ConcreteProductA();
}

public class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod() => new ConcreteProductB();
}

// Real-life Use Case: Document Processing in a Word Processing Application:
// =========================================================================
// Consider a word processing application that supports multiple document formats (e.g., DOCX, PDF, TXT).
// The Factory Method pattern can be applied to create document-specific processors.

// Product
public interface IDocument
{
    void Open();
    void Save();
}

// Concrete Products
public class DOCXDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening DOCX document");
    public void Save() => Console.WriteLine("Saving DOCX document");
}

public class PDFDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening PDF document");
    public void Save() => Console.WriteLine("Saving PDF document");
}

// Creator (Factory)
public abstract class DocumentProcessor
{
    public abstract IDocument CreateDocument();
}

// Concrete Creators
public class DOCXDocumentProcessor : DocumentProcessor
{
    public override IDocument CreateDocument() => new DOCXDocument();
}

public class PDFDocumentProcessor : DocumentProcessor
{
    public override IDocument CreateDocument() => new PDFDocument();
}
