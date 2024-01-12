// Mediator Pattern:
// =================
// Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling
// by keeping objects from referring to each other explicitly.
// Example in .NET:
// Consider a chat room where participants communicate through a mediator.

// Mediator
using System.Runtime.Intrinsics.X86;

public interface IChatMediator
{
    void SendMessage(string message, Participant participant);
}

// Concrete Mediator
public class ChatMediator : IChatMediator
{
    private List<Participant> _participants = new List<Participant>();

    public void RegisterParticipant(Participant participant)
    {
        _participants.Add(participant);
    }

    public void SendMessage(string message, Participant sender)
    {
        foreach (var participant in _participants)
        {
            if (participant != sender)
                participant.Receive(message);
        }
    }
}

// Colleague
public abstract class Participant
{
    protected IChatMediator _mediator;
    public string Name { get; }

    public Participant(string name, IChatMediator mediator)
    {
        Name = name;
        _mediator = mediator;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);
}

// Concrete Colleague
public class ConcreteParticipant : Participant
{
    public ConcreteParticipant(string name, IChatMediator mediator) : base(name, mediator) { }

    public override void Send(string message)
    {
        Console.WriteLine($"{Name} sending message: {message}");
        _mediator.SendMessage(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{Name} received message: {message}");
    }
}

// Real - life Use Case: Air Traffic Control System
// ================================================
// Use Case:
// In an air traffic control system, various aircraft communicate with each other and the
// control center through a mediator. The mediator (air traffic controller) coordinates communication
// between different aircraft without them directly interacting.
// Example in .NET:
// Let's model a simplified air traffic control system where aircraft communicate through a mediator.

// Mediator
public interface IAirTrafficControl
{
    void RegisterAircraft(Aircraft aircraft);
    void SendWarning(Aircraft sender, string message);
}

// Concrete Mediator
public class AirTrafficControl : IAirTrafficControl
{
    private List<Aircraft> _aircraftList = new List<Aircraft>();

    public void RegisterAircraft(Aircraft aircraft)
    {
        _aircraftList.Add(aircraft);
    }

    public void SendWarning(Aircraft sender, string message)
    {
        foreach (var aircraft in _aircraftList)
        {
            if (aircraft != sender)
                aircraft.ReceiveWarning(message);
        }
    }
}

// Colleague
public abstract class Aircraft
{
    protected IAirTrafficControl _atc;

    public Aircraft(IAirTrafficControl atc)
    {
        _atc = atc;
    }

    public abstract void SendWarning(string message);

    public abstract void ReceiveWarning(string message);
}

// Concrete Colleague
public class PassengerAircraft : Aircraft
{
    public PassengerAircraft(IAirTrafficControl atc) : base(atc) { }

    public override void SendWarning(string message)
    {
        _atc.SendWarning(this, message);
    }

    public override void ReceiveWarning(string message)
    {
        Console.WriteLine($"Passenger Aircraft received warning: {message}");
    }
}