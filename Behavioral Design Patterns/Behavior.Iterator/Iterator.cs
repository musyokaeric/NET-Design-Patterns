// Iterator Pattern:
// =================
// Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
// Example in .NET:
// Suppose you have a custom collection and you want to iterate through its elements.

// Aggregate
using System.Collections;

public class MyCollection<T> : IEnumerable<T>
{
    private List<T> _items = new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new MyIterator<T>(_items);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

// Iterator
public class MyIterator<T> : IEnumerator<T>
{
    private List<T> _items;
    private int _currentIndex = -1;

    public MyIterator(List<T> items)
    {
        _items = items;
    }

    public T Current => _items[_currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose() { }

    public bool MoveNext()
    {
        _currentIndex++;
        return _currentIndex < _items.Count;
    }

    public void Reset()
    {
        _currentIndex = -1;
    }
}

// Real - life Use Case: Collection Iteration
// ==========================================
// In.NET, the iterator pattern is commonly used when iterating over collections, such as arrays, lists,
// or custom data structures. The IEnumerable and IEnumerator interfaces in .NET represent the iterator pattern.
// Example in .NET:
// Consider a custom collection where you want to provide a way to iterate over its elements.

// Aggregate
public class CustomCollection<T> : IEnumerable<T>
{
    private List<T> _items = new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new CustomIterator<T>(_items);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

// Iterator
public class CustomIterator<T> : IEnumerator<T>
{
    private List<T> _items;
    private int _currentIndex = -1;

    public CustomIterator(List<T> items)
    {
        _items = items;
    }

    public T Current => _items[_currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose() { }

    public bool MoveNext()
    {
        _currentIndex++;
        return _currentIndex < _items.Count;
    }

    public void Reset()
    {
        _currentIndex = -1;
    }
}