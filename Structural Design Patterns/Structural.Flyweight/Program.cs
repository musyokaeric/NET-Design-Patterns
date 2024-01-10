// Flyweight Pattern:
// ==================
// Minimizes memory usage or computational expenses by sharing as much as possible with related objects.
// Use sharing to support large numbers of fine-grained objects efficiently. 

// Usage:
// ======
FlyweightFactory factory = new FlyweightFactory();
IFlyweight flyweight1 = factory.GetFlyweight("A");
IFlyweight flyweight2 = factory.GetFlyweight("B");

flyweight1.Operation();
flyweight2.Operation();

// Real-Life Use Case:
// ===================
// In a document editing application, characters like letters, numbers, and symbols
// can be represented as flyweights. The flyweight pattern helps reduce memory usage by
// sharing common characters across different parts of the document.

// Usage:
// ======
CharacterFactory characterFactory = new CharacterFactory();

string textToDisplay = "Hello, Flyweight Pattern!";
foreach (char c in textToDisplay)
{
    ICharacter character = characterFactory.GetCharacter(c);
    character.Display();
}
