// Adapter Pattern:
// ================
// Intent: Convert the interface of a class into another interface clients expect.
// Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

// Usage: Create adapter and place a request
// =========================================
Adaptee adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);
target.Request();

// Real-life Use Case - Legacy System Integration
// ==============================================
// Scenario:
// Imagine you have a legacy system that communicates with an external service using a specific
// interface. However, the new system you are building expects a different interface. To bridge this gap
// without modifying the existing code, you can use the Adapter pattern.

// Example:
// Consider a scenario where the legacy system uses SOAP web services, but your new system expects data
// in JSON format. You can create an adapter to convert the SOAP calls to JSON format.

// Legacy system using SOAP

// Usage:
// ======
var legacy = new LegacySystem();
var jsonAdapter =  new JsonAdapter(legacy);
jsonAdapter.Request();