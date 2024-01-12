// Chain of Responsibility Pattern:
// ================================
// Avoid coupling the sender of a request to its receiver by giving more than one object a
// chance to handle the request.  Chain the receiving objects and pass the request along the 
// chain until an object handles it. Consider a logging system where different loggers handle
// messages based on their severity.

// Example usage
var consoleLogger = new ConsoleLogger();
var fileLogger = new FileLogger();
var emailLogger = new EmailLogger();

consoleLogger.SetNextLogger(fileLogger);
fileLogger.SetNextLogger(emailLogger);

consoleLogger.LogMessage("This is an info message.", LogLevel.Info);

// Real - life Use Case: Approval Workflow in an Expense Reimbursement System:
// ===========================================================================
// Imagine you are developing an expense reimbursement system where employees submit expense reports for approval.
// The approval process involves multiple levels of authority, such as team lead, department manager, and finance
// manager. The Chain of Responsibility pattern can be applied to create a chain of handlers, each responsible
// for approving expenses up to a certain limit.

// Example usage
var expenseSystem = new ExpenseApprovalSystem();

var expense1 = new Expense { Amount = 800m };
expenseSystem.SubmitExpense(expense1);
var expense2 = new Expense { Amount = 3500m };
expenseSystem.SubmitExpense(expense2);
var expense3 = new Expense { Amount = 10000m };
expenseSystem.SubmitExpense(expense3);

// In this example, the "ExpenseHandler" class represents the handler in the chain.
// Concrete handlers ("TeamLeadHandler", "DepartmentManagerHandler", "FinanceManagerHandler")
// decide whether they can approve an expense based on their approval limit. If a handler
// can't approve the expense, it passes it to the next handler in the chain.

// The "ExpenseApprovalSystem" class serves as the client, and it uses the chain of handlers
// to process expense approvals through the defined workflow.