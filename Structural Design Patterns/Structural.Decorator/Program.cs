// Decorator Pattern:
// ==================
// Attach additional responsibilities to an object dynamically. Decorators provide a flexible 
// alternative to subclassing for extending functionality.

// Usage:
// ======
IComponent component = new ConcreteComponent();
Decorator decorator = new ConcreteDecorator(component);

decorator.Operation();
(decorator as ConcreteDecorator)?.AdditionalOperation();

// Real-Life Use Case:
// ===================
// Consider a text processing application where you want to provide additional formatting options
// for text. Decorators can be used to add features like bold, italic, or underline to the base text
// without creating a complex hierarchy of classes.

// Usage:
// ======
IText plainText = new PlainText("Hello, World!");
plainText.Display();

IText boldText = new BoldText(plainText);
boldText.Display();

IText italicText = new ItalicText(plainText);
italicText.Display();

IText boldItalicText = new BoldText(italicText);
boldItalicText.Display();