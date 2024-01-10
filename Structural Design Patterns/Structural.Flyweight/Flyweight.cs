// Flyweight Pattern:
// ==================
// Minimizes memory usage or computational expenses by sharing as much as possible with related objects.
// Use sharing to support large numbers of fine-grained objects efficiently. 

// Flyweight interface
public interface IFlyweight
{
    void Operation();
}

// ConcreteFlyweight
public class ConcreteFlyweight : IFlyweight
{
    private string intrinsicState;

    public ConcreteFlyweight(string intrinsicState)
    {
        this.intrinsicState = intrinsicState;
    }

    public void Operation()
    {
        Console.WriteLine($"ConcreteFlyweight: {intrinsicState}");
    }
}

// FlyweightFactory
public class FlyweightFactory
{
    private Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();

    public IFlyweight GetFlyweight(string key)
    {
        if (!flyweights.TryGetValue(key, out IFlyweight flyweight))
        {
            flyweight = new ConcreteFlyweight(key);
            flyweights.Add(key, flyweight);
        }
        return flyweight;
    }
}

// Real-Life Use Case:
// ===================
// In a document editing application, characters like letters, numbers, and symbols
// can be represented as flyweights. The flyweight pattern helps reduce memory usage by
// sharing common characters across different parts of the document.

// Flyweight interface
public interface ICharacter
{
    void Display();
}

// ConcreteFlyweight for Character
public class Character : ICharacter
{
    private char symbol;

    public Character(char symbol)
    {
        this.symbol = symbol;
    }

    public void Display()
    {
        Console.Write(symbol);
    }
}

// FlyweightFactory
public class CharacterFactory
{
    private Dictionary<char, ICharacter> characters = new Dictionary<char, ICharacter>();

    public ICharacter GetCharacter(char symbol)
    {
        if (!characters.TryGetValue(symbol, out ICharacter character))
        {
            character = new Character(symbol);
            characters.Add(symbol, character);
        }
        return character;
    }
}


