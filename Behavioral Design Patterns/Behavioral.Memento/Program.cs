// Memento Pattern:
// ================
// Without violating encapsulation, capture and externalize an object's internal state so that
// the object can be restored to this state later.
// Example in .NET:
// Suppose you have an editor with an undo feature.

// Example usage
var textEditor = new TextEditor();
var undoManager = new UndoManager();

textEditor.Content = "First content";
undoManager.SaveMemento(textEditor.CreateMemento());

textEditor.Content = "Updated content";
undoManager.SaveMemento(textEditor.CreateMemento());

textEditor.RestoreMemento(undoManager.Undo());  // Restores to "First content"

// Real - life Use Case:  Browser History in a Web Browser
// =======================================================
// Consider a web browser application that needs to implement a navigation history feature,
// allowing users to navigate back and forth between visited web pages. The Memento pattern
// can be applied to store and manage the browser's navigation history.
// In this example, I'll create a simplified WebBrowser class with support for storing and navigating
// through a browsing history using the Memento pattern:

// Example usage
var client = new BrowserClient();
client.Run();
