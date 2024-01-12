// Mediator Pattern:
// =================
// Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling
// by keeping objects from referring to each other explicitly.
// Example in .NET:
// Consider a chat room where participants communicate through a mediator.

// Example usage
var mediator = new ChatMediator();

var participant1 = new ConcreteParticipant("User1", mediator);
var participant2 = new ConcreteParticipant("User2", mediator);
var participant3 = new ConcreteParticipant("User3", mediator);

mediator.RegisterParticipant(participant1);
mediator.RegisterParticipant(participant2);
mediator.RegisterParticipant(participant3);

participant1.Send("Hello, everyone!");

// Real - life Use Case: Air Traffic Control System
// ================================================
// Use Case:
// In an air traffic control system, various aircraft communicate with each other and the
// control center through a mediator. The mediator (air traffic controller) coordinates communication
// between different aircraft without them directly interacting.
// Example in .NET:
// Let's model a simplified air traffic control system where aircraft communicate through a mediator.

// Example usage
var airTrafficControl = new AirTrafficControl();
var aircraft1 = new PassengerAircraft(airTrafficControl);
var aircraft2 = new PassengerAircraft(airTrafficControl);

airTrafficControl.RegisterAircraft(aircraft1);
airTrafficControl.RegisterAircraft(aircraft2);

aircraft1.SendWarning("Traffic alert!");

// Both aircraft will receive the warning message

