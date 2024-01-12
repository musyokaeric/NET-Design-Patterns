// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Hello, World!");

// Example usage
var light = new Light();
var lightOnCommand = new LightOnCommand(light);
var lightOffCommand = new LightOffCommand(light);

var remote = new RemoteControl();
remote.SetCommand(lightOnCommand);
remote.PressButton(); // Light is ON

remote.SetCommand(lightOffCommand);
remote.PressButton(); // Light is OFF

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

// Example usage
var document = new Document();
var commandHistory = new CommandHistory();

var insertCommand = new InsertTextCommand(document, "Hello", 0);
commandHistory.ExecuteCommand(insertCommand);  // Document content: Hello

var deleteCommand = new DeleteCommand(document, 0, 3);
commandHistory.ExecuteCommand(deleteCommand);  // Document content: lo

commandHistory.Undo();  // Document content: Hello

