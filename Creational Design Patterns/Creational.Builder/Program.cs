// Builder Pattern:
// ================
// Separates the construction of a complex object from its representation,
// so that the same construction process can create different representations.

// Usage:
// ======

IPizzaBuilder builder = new MargheritaPizzaBuilder();
PizzaDirector director = new PizzaDirector();
Pizza margheritaPizza = director.BuildPizza(builder);
margheritaPizza.Display();

// Real-life Use Case: Building a Document Object Model (DOM) for HTML:
// ====================================================================
// Imagine you are designing a system to create HTML documents. Each HTML document
// can have different elements like headers, paragraphs, images, and lists.
// The Builder pattern can be used to create a flexible and extensible way of constructing HTML documents.

// Usage
// =====
var htmlBuilder = new HTMLBuilder();
var htmlDirector = new HTMLDirector();
var htmlDocument = htmlDirector.Construct(htmlBuilder);
htmlDocument.Display();

// In this example, the "HTMLBuilder" class implements the "IHTMLBuilder" interface to
// construct different HTML elements. The "HTMLDirector" class provides a higher-level
// interface to construct a complete HTML document. This allows for flexibility
// and easy extension of the HTML document structure.