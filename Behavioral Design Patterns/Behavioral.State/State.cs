// State Pattern:
// ==============
// Allow an object to alter its behavior when its internal state changes.The object will appear to change its class.
// Example in .NET:
// Consider a simple vending machine that changes its behavior based on its state.

// Context
public class VendingMachine
{
    private VendingMachineState _state;

    public VendingMachine()
    {
        _state = new NoCoinState();
    }

    public void InsertCoin()
    {
        _state.InsertCoin(this);
    }

    public void EjectCoin()
    {
        _state.EjectCoin(this);
    }

    public void DispenseItem()
    {
        _state.DispenseItem(this);
    }

    public void SetState(VendingMachineState state)
    {
        _state = state;
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}

// State
public interface VendingMachineState
{
    void InsertCoin(VendingMachine vendingMachine);
    void EjectCoin(VendingMachine vendingMachine);
    void DispenseItem(VendingMachine vendingMachine);
}

// Concrete States
public class NoCoinState : VendingMachineState
{
    public void InsertCoin(VendingMachine vendingMachine)
    {
        vendingMachine.SetState(new HasCoinState());
        vendingMachine.DisplayMessage("Coin inserted. Please select an item.");
    }

    public void EjectCoin(VendingMachine vendingMachine)
    {
        vendingMachine.DisplayMessage("No coin to eject.");
    }

    public void DispenseItem(VendingMachine vendingMachine)
    {
        vendingMachine.DisplayMessage("Please insert a coin first.");
    }
}

public class HasCoinState : VendingMachineState
{
    public void InsertCoin(VendingMachine vendingMachine)
    {
        vendingMachine.DisplayMessage("Coin already inserted.");
    }

    public void EjectCoin(VendingMachine vendingMachine)
    {
        vendingMachine.SetState(new NoCoinState());
        vendingMachine.DisplayMessage("Coin ejected.");
    }

    public void DispenseItem(VendingMachine vendingMachine)
    {
        vendingMachine.SetState(new NoCoinState());
        vendingMachine.DisplayMessage("Item dispensed. Thank you!");
    }
}

// Real - life Use Case:  Document Approval Workflow
// =================================================
// Use Case:
// In a document approval system, the state pattern can be used to model the different states
// a document can be in (e.g., Draft, Pending Approval, Approved, Rejected). The behavior of the document
// varies based on its current state.
// Example in .NET:
// Let's model a document approval system using the state pattern.

// Context
public class Document
{
    private IApprovalState _state;

    public Document()
    {
        _state = new DraftState();
    }

    public void SetState(IApprovalState state)
    {
        _state = state;
    }

    public void SubmitForApproval()
    {
        _state.SubmitForApproval(this);
    }

    public void Approve()
    {
        _state.Approve(this);
    }

    public void Reject()
    {
        _state.Reject(this);
    }

    public void PrintStatus()
    {
        Console.WriteLine($"Document is {_state.GetType().Name}");
    }
}

// State
public interface IApprovalState
{
    void SubmitForApproval(Document document);
    void Approve(Document document);
    void Reject(Document document);
}

// Concrete States
public class DraftState : IApprovalState
{
    public void SubmitForApproval(Document document)
    {
        Console.WriteLine("Submitting document for approval.");
        document.SetState(new PendingApprovalState());
    }

    public void Approve(Document document)
    {
        Console.WriteLine("Cannot approve a draft document.");
    }

    public void Reject(Document document)
    {
        Console.WriteLine("Cannot reject a draft document.");
    }
}

public class PendingApprovalState : IApprovalState
{
    public void SubmitForApproval(Document document)
    {
        Console.WriteLine("Document is already pending approval.");
    }

    public void Approve(Document document)
    {
        Console.WriteLine("Approving document.");
        document.SetState(new ApprovedState());
    }

    public void Reject(Document document)
    {
        Console.WriteLine("Rejecting document.");
        document.SetState(new RejectedState());
    }
}

public class ApprovedState : IApprovalState
{
    public void SubmitForApproval(Document document)
    {
        Console.WriteLine("Cannot submit an approved document for approval.");
    }

    public void Approve(Document document)
    {
        Console.WriteLine("Document is already approved.");
    }

    public void Reject(Document document)
    {
        Console.WriteLine("Cannot reject an approved document.");
    }
}

// Concrete State
public class RejectedState : IApprovalState
{
    public void SubmitForApproval(Document document)
    {
        Console.WriteLine("Cannot submit a rejected document for approval.");
    }

    public void Approve(Document document)
    {
        Console.WriteLine("Cannot approve a rejected document.");
    }

    public void Reject(Document document)
    {
        Console.WriteLine("Document is already rejected.");
    }
}
