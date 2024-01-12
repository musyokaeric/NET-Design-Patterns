// Memento Pattern:
// ================
// Without violating encapsulation, capture and externalize an object's internal state so that
// the object can be restored to this state later.
// Example in .NET:
// Suppose you have an editor with an undo feature.

// Memento
public class EditorMemento
{
    public string Content { get; }

    public EditorMemento(string content)
    {
        Content = content;
    }
}

// Originator
public class TextEditor
{
    private string _content;

    public string Content
    {
        get => _content;
        set
        {
            _content = value;
            Console.WriteLine($"Content set: {_content}");
        }
    }

    public EditorMemento CreateMemento()
    {
        return new EditorMemento(_content);
    }

    public void RestoreMemento(EditorMemento memento)
    {
        _content = memento.Content;
        Console.WriteLine($"Content restored: {_content}");
    }
}

// Caretaker
public class UndoManager
{
    private Stack<EditorMemento> _mementoStack = new Stack<EditorMemento>();

    public void SaveMemento(EditorMemento memento)
    {
        _mementoStack.Push(memento);
    }

    public EditorMemento Undo()
    {
        if (_mementoStack.Count > 1)
        {
            _mementoStack.Pop();  // Discard the current state
            return _mementoStack.Peek();
        }

        return null;  // No more undo steps
    }
}

// Real - life Use Case:  Browser History in a Web Browser
// =======================================================
// Consider a web browser application that needs to implement a navigation history feature,
// allowing users to navigate back and forth between visited web pages. The Memento pattern
// can be applied to store and manage the browser's navigation history.
// In this example, I'll create a simplified WebBrowser class with support for storing and navigating
// through a browsing history using the Memento pattern:

// Memento
public class BrowserHistoryMemento
{
    public string Url { get; }

    public BrowserHistoryMemento(string url)
    {
        Url = url;
    }
}

// Originator
public class WebBrowser
{
    private string _currentUrl;
    private Stack<BrowserHistoryMemento> _backStack = new Stack<BrowserHistoryMemento>();
    private Stack<BrowserHistoryMemento> _forwardStack = new Stack<BrowserHistoryMemento>();

    public string CurrentUrl
    {
        get => _currentUrl;
        private set
        {
            _currentUrl = value;
            Console.WriteLine($"Current URL: {_currentUrl}");
        }
    }

    public void NavigateTo(string url)
    {
        _backStack.Push(new BrowserHistoryMemento(CurrentUrl));
        _forwardStack.Clear(); // Clear forward stack when navigating to a new page

        CurrentUrl = url;
    }

    public void NavigateBack()
    {
        if (_backStack.Count > 0)
        {
            var previousState = _backStack.Pop();
            _forwardStack.Push(new BrowserHistoryMemento(CurrentUrl));

            CurrentUrl = previousState.Url;
        }
        else
        {
            Console.WriteLine("Cannot navigate back. No history available.");
        }
    }

    public void NavigateForward()
    {
        if (_forwardStack.Count > 0)
        {
            var nextState = _forwardStack.Pop();
            _backStack.Push(new BrowserHistoryMemento(CurrentUrl));

            CurrentUrl = nextState.Url;
        }
        else
        {
            Console.WriteLine("Cannot navigate forward. No history available.");
        }
    }
}

// Client
public class BrowserClient
{
    public void Run()
    {
        var webBrowser = new WebBrowser();

        webBrowser.NavigateTo("https://www.example.com");
        webBrowser.NavigateTo("https://www.example.com/page1");
        webBrowser.NavigateTo("https://www.example.com/page2");

        Console.WriteLine("Navigate Back:");
        webBrowser.NavigateBack(); // Navigates back to "https://www.example.com/page1"

        Console.WriteLine("Navigate Forward:");
        webBrowser.NavigateForward(); // Navigates forward to "https://www.example.com/page2"
    }
}