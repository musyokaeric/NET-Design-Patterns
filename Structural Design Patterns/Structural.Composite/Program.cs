// Composite Pattern:
// ==================
// Compose objects into tree structures to represent part-whole hierarchies.  Composite lets 
// clients treat individual objects and compositions of objects uniformly.

// Usage:
// ======
var composite = new Composite();
composite.Add(new Leaf("Leaf A"));
composite.Add(new Leaf("Leaf B"));

composite.Display();

// Real-Life Use Case:
// ===================
// Consider a file system where directories can contain both files and subdirectories.
// The composite pattern can be used to represent files and directories uniformly, allowing you
// to perform operations on the entire file system or individual files and directories.

// Usage:
// ======
Directory root = new Directory("Root");
root.AddItem(new File("File1.txt"));

Directory subDir = new Directory("Subdirectory");
subDir.AddItem(new File("File2.txt"));
subDir.AddItem(new File("File3.txt"));

root.AddItem(subDir);
root.Display();