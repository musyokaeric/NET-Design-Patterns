// State Pattern:
// ==============
// Allow an object to alter its behavior when its internal state changes.The object will appear to change its class.
// Example in .NET:
// Consider a simple vending machine that changes its behavior based on its state.

// Example usage
var vendingMachine = new VendingMachine();
vendingMachine.InsertCoin();        // Coin inserted. Please select an item.
vendingMachine.DispenseItem();      // Please insert a coin first.
vendingMachine.EjectCoin();         // Coin ejected.

// Real - life Use Case:  Document Approval Workflow
// =================================================
// Use Case:
// In a document approval system, the state pattern can be used to model the different states
// a document can be in (e.g., Draft, Pending Approval, Approved, Rejected). The behavior of the document
// varies based on its current state.
// Example in .NET:
// Let's model a document approval system using the state pattern.

// Example usage
var document = new Document();

document.PrintStatus();  // Document is Draft

document.SubmitForApproval();
document.PrintStatus();  // Document is PendingApproval

document.Approve();
document.PrintStatus();  // Document is Approved

document.Reject();
document.PrintStatus();  // Document is Rejected