// Facade Pattern:
// ===============
// Provides a simplified interface to a set of interfaces in a subsystem. Façade defines
// a higherlevel interface that makes the subsystem easier to use.

// Usage:
// ======
Facade facade = new Facade();
facade.Operation();

// Real-Life Use Case:
// ===================
// In a multimedia application, you might have complex subsystems for handling audio,
// video, and graphics. A facade can simplify the process of playing a multimedia file
// by providing a single interface that internally handles the complexities of each subsystem.

// Usage:
// ======
MultimediaFacade multimediaFacade = new MultimediaFacade();
multimediaFacade.PlayMultimediaFile("video.mp4");