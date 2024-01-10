// Bridge Pattern:
// ===============
// Separates abstraction from implementation so that the two can vary independently.

// Usage:
// ======
IImplementor implementor = new ConcreteImplementorA();
Abstraction abstraction = new RefinedAbstraction(implementor);
abstraction.Operation();
abstraction = new RefinedAbstraction(new ConcreteImplementorB());
abstraction.Operation();

// Real-Life Use Case:
// ===================
// In GUI frameworks, the bridge pattern is often used to separate platform-specific code (e.g., Windows, Linux, macOS)
// from the higher-level user interface code. The platform-specific code serves as the implementor, and the UI code
// acts as the abstraction, allowing the UI to vary independently from the platform.

// Usage:
// ======
IDrawingAPI windowsAPI = new WindowsDrawingAPI();
Circle windowsCircle = new Circle(5, windowsAPI);
windowsCircle.Draw();
IDrawingAPI linuxAPI = new LinuxDrawingAPI();
Circle linuxCircle = new Circle(5, linuxAPI);
linuxCircle.Draw();