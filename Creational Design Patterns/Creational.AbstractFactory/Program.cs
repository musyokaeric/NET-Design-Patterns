// Abstract Factory Pattern:
// =========================
// Provides an interface for creating families of related
// or dependent objects without specifying their concrete classes.

// Usage:
// ======
IAbstractFactory factory = new ConcreteFactory1();
IProductA productA = factory.CreateProductA();
IProductB productB = factory.CreateProductB();
productA.Display();
productB.Display();

// Real - life Use Case: GUI Library for Multiple Operating Systems:
// =================================================================
// Consider a GUI library that needs to support different operating
// systems (Windows, macOS, Linux). The Abstract Factory pattern
// can be used to create families of UI components specific to each operating system.

// Usage:
// ======
IGUIFactory windowsFactory = new WindowsFactory();
IButton windowsButton = windowsFactory.CreateButton();
ITextBox windowsTextBox = windowsFactory.CreateTextBox();
windowsButton.Render();
windowsTextBox.Display();

IGUIFactory macosFactory = new MacOSFactory();
IButton macosButton = macosFactory.CreateButton();
ITextBox macosTextBox = macosFactory.CreateTextBox();
macosButton.Render();
macosTextBox.Display();

// In this example, the IGUIFactory is an abstract factory interface,
// and the concrete factories (WindowsFactory and MacOSFactory) implement this interface
// to create families of UI components specific to each operating system. This ensures that
// UI components are compatible and consistent within each operating system.