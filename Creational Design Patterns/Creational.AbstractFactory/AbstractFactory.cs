// Abstract Factory Pattern:
// =========================
// Provides an interface for creating families of related
// or dependent objects without specifying their concrete classes.

using System.Runtime.Intrinsics.X86;
using System;

public interface IAbstractFactory
{
    IProductA CreateProductA();
    IProductB CreateProductB();
}

public interface IProductA
{
    void Display();
}

public interface IProductB
{
    void Display();
}

public class ConcreteFactory1 : IAbstractFactory
{
    public IProductA CreateProductA() => new ConcreteProductA1();
    public IProductB CreateProductB() => new ConcreteProductB1();
}

public class ConcreteFactory2 : IAbstractFactory
{
    public IProductA CreateProductA() => new ConcreteProductA2();
    public IProductB CreateProductB() => new ConcreteProductB2();
}

public class ConcreteProductA1 : IProductA
{
    public void Display() => Console.WriteLine("Product A1");
}

public class ConcreteProductB1 : IProductB
{
    public void Display() => Console.WriteLine("Product B1");
}

public class ConcreteProductA2 : IProductA
{
    public void Display() => Console.WriteLine("Product A2");
}

public class ConcreteProductB2 : IProductB
{
    public void Display() => Console.WriteLine("Product B2");
}

// Real - life Use Case: GUI Library for Multiple Operating Systems:
// =================================================================
// Consider a GUI library that needs to support different operating
// systems (Windows, macOS, Linux). The Abstract Factory pattern
// can be used to create families of UI components specific to each operating system.

// Abstract Product A
public interface IButton
{
    void Render();
}

// Concrete Products A
public class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("Rendering Windows button");
}

public class MacOSButton : IButton
{
    public void Render() => Console.WriteLine("Rendering MacOS button");
}

// Abstract Product B
public interface ITextBox
{
    void Display();
}

// Concrete Products B
public class WindowsTextBox : ITextBox
{
    public void Display() => Console.WriteLine("Displaying Windows text box");
}

public class MacOSTextBox : ITextBox
{
    public void Display() => Console.WriteLine("Displaying MacOS text box");
}

// Abstract Factory
public interface IGUIFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
}

// Concrete Factories
public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ITextBox CreateTextBox() => new WindowsTextBox();
}

public class MacOSFactory : IGUIFactory
{
    public IButton CreateButton() => new MacOSButton();
    public ITextBox CreateTextBox() => new MacOSTextBox();
}
