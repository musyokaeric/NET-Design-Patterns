// Prototype Pattern:
// ==================
// Creates new objects by copying an existing object, known as the prototype.

// Usage
// =====
ICloneableItem prototypeA = new ConcreteItemA { PropertyA = "ValueA" };
ICloneableItem clonedA = prototypeA.Clone();
clonedA.Display();

ICloneableItem prototypeB = new ConcreteItemB { PropertyB = 42 };
ICloneableItem clonedB = prototypeB.Clone();
clonedB.Display();

// Real-life Use Case: Creating Configurable Objects in a Graphic User Interface (GUI) Library:
// ============================================================================================
// Consider a GUI library where you have predefined UI components like buttons, checkboxes,
// and text fields. Users might want to create variations of these components with different colors,
// sizes, and styles. The Prototype pattern can be applied to clone existing UI components and customize their properties.

// Usage
// =====
IUIComponent prototypeButton = new UIButton { Color = "Red", Size = 20 };
IUIComponent clonedButton = prototypeButton.Clone();
clonedButton.Display();

IUIComponent prototypeCheckbox = new UICheckbox { Style = "Square", IsChecked = true };
IUIComponent clonedCheckbox = prototypeCheckbox.Clone();
clonedCheckbox.Display();

// In this example, the UIButton and UICheckbox classes implement the IUIComponent
// interface to define a prototype for UI components. Users can clone these prototypes
// to create new instances with customized properties, allowing for the creation
// of configurable UI components in a GUI library.