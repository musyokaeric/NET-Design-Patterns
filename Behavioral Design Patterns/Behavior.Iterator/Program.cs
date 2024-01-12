// Iterator Pattern:
// =================
// Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
// Example in .NET:
// Suppose you have a custom collection and you want to iterate through its elements.

// Example usage
var collection = new MyCollection<int>();
collection.Add(1);
collection.Add(2);
collection.Add(3);

foreach (var item in collection)
{
    Console.WriteLine(item);
}

// Real - life Use Case: Collection Iteration
// ==========================================
// In.NET, the iterator pattern is commonly used when iterating over collections, such as arrays, lists,
// or custom data structures. The IEnumerable and IEnumerator interfaces in .NET represent the iterator pattern.
// Example in .NET:
// Consider a custom collection where you want to provide a way to iterate over its elements.

// Example usage
var collection2 = new CustomCollection<int>();
collection2.Add(1);
collection2.Add(2);
collection2.Add(3);

foreach (var item in collection2)
{
    Console.WriteLine(item);
}
// Output: 1 2 3
