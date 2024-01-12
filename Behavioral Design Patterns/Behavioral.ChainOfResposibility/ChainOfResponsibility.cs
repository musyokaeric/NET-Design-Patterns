// Chain of Responsibility Pattern:
// ================================
// Avoid coupling the sender of a request to its receiver by giving more than one object a
// chance to handle the request.  Chain the receiving objects and pass the request along the 
// chain until an object handles it. Consider a logging system where different loggers handle
// messages based on their severity.

// Handler

public abstract class Logger
{
    protected Logger? _nextLogger;

    public void SetNextLogger(Logger nextLogger)
    {
        _nextLogger = nextLogger;
    }

    public abstract void LogMessage(string message, LogLevel severity);
}

// Concrete Handlers
public class ConsoleLogger : Logger
{
    public override void LogMessage(string message, LogLevel severity)
    {
        if (severity <= LogLevel.Info)
            Console.WriteLine($"Console: {message}");
        _nextLogger?.LogMessage(message, severity);
    }
}

public class FileLogger : Logger
{
    public override void LogMessage(string message, LogLevel severity)
    {
        if (severity <= LogLevel.Warning)
            Console.WriteLine($"File: {message}");
        _nextLogger?.LogMessage(message, severity);
    }
}

public class EmailLogger : Logger
{
    public override void LogMessage(string message, LogLevel severity)
    {
        if (severity <= LogLevel.Error)
            Console.WriteLine($"Email: {message}");
        _nextLogger?.LogMessage(message, severity);
    }
}

public enum LogLevel
{
    Info,
    Warning,
    Error
}

// Real - life Use Case: Approval Workflow in an Expense Reimbursement System:
// ===========================================================================
// Imagine you are developing an expense reimbursement system where employees submit expense reports for approval.
// The approval process involves multiple levels of authority, such as team lead, department manager, and finance
// manager. The Chain of Responsibility pattern can be applied to create a chain of handlers, each responsible
// for approving expenses up to a certain limit.

// Handler
public abstract class ExpenseHandler
{
    protected ExpenseHandler? _nextHandler;
    protected decimal _approvalLimit;

    public void SetNextHandler(ExpenseHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public void ProcessExpense(Expense expense)
    {
        if (expense.Amount <= _approvalLimit)
        {
            ApproveExpense(expense);
        }
        else if (_nextHandler != null)
        {
            _nextHandler.ProcessExpense(expense);
        }
        else
        {
            Console.WriteLine("Expense cannot be approved at any level.");
        }
    }

    protected abstract void ApproveExpense(Expense expense);
}

// Concrete Handlers
public class TeamLeadHandler : ExpenseHandler
{
    public TeamLeadHandler()
    {
        _approvalLimit = 1000m;
    }

    protected override void ApproveExpense(Expense expense)
    {
        Console.WriteLine($"Team Lead approved expense of {expense.Amount:C}");
    }
}

public class DepartmentManagerHandler : ExpenseHandler
{
    public DepartmentManagerHandler()
    {
        _approvalLimit = 5000m;
    }

    protected override void ApproveExpense(Expense expense)
    {
        Console.WriteLine($"Department Manager approved expense of {expense.Amount:C}");
    }
}

public class FinanceManagerHandler : ExpenseHandler
{
    public FinanceManagerHandler()
    {
        _approvalLimit = decimal.MaxValue; // No limit for Finance Manager
    }

    protected override void ApproveExpense(Expense expense)
    {
        Console.WriteLine($"Finance Manager approved expense of {expense.Amount:C}");
    }
}

// Expense class
public class Expense
{
    public decimal Amount { get; set; }
    // Additional properties for expense details
}

// Client
public class ExpenseApprovalSystem
{
    private readonly ExpenseHandler _approvalWorkflow;

    public ExpenseApprovalSystem()
    {
        // Creating the chain of handlers
        var teamLeadHandler = new TeamLeadHandler();
        var departmentManagerHandler = new DepartmentManagerHandler();
        var financeManagerHandler = new FinanceManagerHandler();

        teamLeadHandler.SetNextHandler(departmentManagerHandler);
        departmentManagerHandler.SetNextHandler(financeManagerHandler);

        _approvalWorkflow = teamLeadHandler;
    }

    public void SubmitExpense(Expense expense)
    {
        _approvalWorkflow.ProcessExpense(expense);
    }
}

// In this example, the "ExpenseHandler" class represents the handler in the chain.
// Concrete handlers ("TeamLeadHandler", "DepartmentManagerHandler", "FinanceManagerHandler")
// decide whether they can approve an expense based on their approval limit. If a handler
// can't approve the expense, it passes it to the next handler in the chain.

// The "ExpenseApprovalSystem" class serves as the client, and it uses the chain of handlers
// to process expense approvals through the defined workflow.