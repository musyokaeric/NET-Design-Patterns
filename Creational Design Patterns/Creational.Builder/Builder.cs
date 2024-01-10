// Builder Pattern:
// ================
// Separates the construction of a complex object from its representation,
// so that the same construction process can create different representations.

// Product
public class Pizza
{
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public string Topping { get; set; }

    public void Display()
    {
        Console.WriteLine($"Pizza with {Dough} dough, {Sauce} sauce, and {Topping} topping.");
    }
}

// Builder interface
public interface IPizzaBuilder
{
    void BuildDough();
    void BuildSauce();
    void BuildTopping();
    Pizza GetPizza();
}

// Concrete builder
public class MargheritaPizzaBuilder : IPizzaBuilder
{
    private Pizza pizza = new Pizza();

    public void BuildDough() => pizza.Dough = "Thin";
    public void BuildSauce() => pizza.Sauce = "Tomato";
    public void BuildTopping() => pizza.Topping = "Mozzarella";

    public Pizza GetPizza() => pizza;
}

// Director
public class PizzaDirector
{
    public Pizza BuildPizza(IPizzaBuilder builder)
    {
        builder.BuildDough();
        builder.BuildSauce();
        builder.BuildTopping();
        return builder.GetPizza();
    }
}

// Real-life Use Case: Building a Document Object Model (DOM) for HTML:
// ====================================================================
// Imagine you are designing a system to create HTML documents. Each HTML document
// can have different elements like headers, paragraphs, images, and lists.
// The Builder pattern can be used to create a flexible and extensible way of constructing HTML documents.

// Product
public class HTMLDocument
{
    private List<string> elements = new List<string>();

    public void AddElement(string element)
    {
        elements.Add(element);
    }

    public void Display()
    {
        foreach (var element in elements)
        {
            Console.WriteLine(element);
        }
    }
}

// Builder interface
public interface IHTMLBuilder
{
    void BuildHeader(string text);
    void BuildParagraph(string text);
    void BuildImage(string src);
    void BuildList(List<string> items);
    HTMLDocument GetResult();
}

// Concrete builder
public class HTMLBuilder : IHTMLBuilder
{
    private HTMLDocument document = new HTMLDocument();

    public void BuildHeader(string text)
    {
        document.AddElement($"<h1>{text}</h1>");
    }

    public void BuildParagraph(string text)
    {
        document.AddElement($"<p>{text}</p>");
    }

    public void BuildImage(string src)
    {
        document.AddElement($"<img src='{src}' />");
    }

    public void BuildList(List<string> items)
    {
        var listItems = items.Select(item => $"<li>{item}</li>").ToList();
        document.AddElement($"<ul>{string.Join("", listItems)}</ul>");
    }

    public HTMLDocument GetResult()
    {
        return document;
    }
}

// Director
public class HTMLDirector
{
    public HTMLDocument Construct(IHTMLBuilder builder)
    {
        builder.BuildHeader("Builder Pattern Example");
        builder.BuildParagraph("This is a simple example of using the Builder pattern to create an HTML document.");
        builder.BuildImage("example.jpg");
        builder.BuildList(new List<string> { "Item 1", "Item 2", "Item 3" });

        return builder.GetResult();
    }
}