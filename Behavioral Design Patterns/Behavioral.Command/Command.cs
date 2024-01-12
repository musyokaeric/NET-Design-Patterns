// Command Pattern:
// ================
// Encapsulate a request as an object, thereby allowing for parameterization of clients
// with different requests, queuing of requests, and providing support for undoable operations.
// Example in .NET:
// Consider a simple remote control system where you can press different buttons to perform various actions.

using System;
using System.Text;

// Command
public interface ICommand
{
    void Execute();
}

// Concrete Commands
public class LightOnCommand : ICommand
{
    private readonly Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }
}

public class LightOffCommand : ICommand
{
    private readonly Light _light;

    public LightOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOff();
    }
}

// Receiver
public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("Light is ON");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light is OFF");
    }
}

// Invoker
public class RemoteControl
{
    private ICommand? _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command?.Execute();
    }
}


// Real - life Use Case: Undo/Redo Mechanism
// =========================================
// Use Case:
// Consider a text editor where users can perform various operations (commands) such as typing,
// deleting, and formatting text. The Command pattern can be used to implement an undo/redo mechanism,
// allowing users to revert or redo previous operations.
// Example in .NET:
// In an interactive application, you could have command classes representing different actions
// (e.g., "InsertTextCommand", "DeleteCommand"). The invoker keeps a history of executed commands,
// allowing for undo and redo operations.

// Command
public interface ICommand2
{
    void Execute();
    void Undo();
}

// Concrete Commands
public class InsertTextCommand : ICommand2
{
    private readonly Document _document;
    private readonly string _text;
    private int _position;

    public InsertTextCommand(Document document, string text, int position)
    {
        _document = document;
        _text = text;
        _position = position;
    }

    public void Execute()
    {
        _document.InsertText(_text, _position);
    }

    public void Undo()
    {
        _document.DeleteText(_position, _text.Length);
    }
}

public class DeleteCommand : ICommand2
{
    private readonly Document _document;
    private readonly string _deletedText;
    private int _position;

    public DeleteCommand(Document document, int position, int length)
    {
        _document = document;
        _position = position;
        _deletedText = document.GetText(position, length);
    }

    public void Execute()
    {
        _document.DeleteText(_position, _deletedText.Length);
    }

    public void Undo()
    {
        _document.InsertText(_deletedText, _position);
    }
}

// Receiver
public class Document
{
    private StringBuilder _content = new StringBuilder();

    public void InsertText(string text, int position)
    {
        _content.Insert(position, text);
    }

    public void DeleteText(int position, int length)
    {
        _content.Remove(position, length);
    }

    public string GetText(int position, int length)
    {
        return _content.ToString().Substring(position, length);
    }

    public void Display()
    {
        Console.WriteLine(_content.ToString());
    }
}

// Invoker
public class CommandHistory
{
    private Stack<ICommand2> _undoStack = new Stack<ICommand2>();
    private Stack<ICommand2> _redoStack = new Stack<ICommand2>();

    public void ExecuteCommand(ICommand2 command)
    {
        command.Execute();
        _undoStack.Push(command);
        _redoStack.Clear();
    }

    public void Undo()
    {
        if (_undoStack.Count > 0)
        {
            var command = _undoStack.Pop();
            command.Undo();
            _redoStack.Push(command);
        }
    }

    public void Redo()
    {
        if (_redoStack.Count > 0)
        {
            var command = _redoStack.Pop();
            command.Execute();
            _undoStack.Push(command);
        }
    }
}
