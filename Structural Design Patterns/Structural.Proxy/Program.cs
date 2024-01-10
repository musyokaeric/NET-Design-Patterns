// Proxy Pattern:
// ==============
// Provides a surrogate or placeholder for another object to control access to it.

// Usage:
// ======
ISubject proxy = new Proxy();
proxy.Request();

// Real-Life Use Case:
// ===================
// Consider a scenario where you are working with large images or documents that take a
// considerable amount of time to load. Instead of loading the entire content upfront,
// a proxy object can be used to represent the image or document. The actual loading
// is deferred until the content is requested.

// Usage:
// ======
IImage image = new ImageProxy("largeImage.jpg");

// Image is not loaded until Display is called
image.Display();

// Image is already loaded, so it won't load again
image.Display();
