// Template Method Pattern:
// ========================
// Define the skeleton of an algorithm in the superclass but let subclasses override specific
// steps of the algorithm without changing its structure.
// Example in .NET:
// Let's implement a template method for building houses with different construction steps.

// Abstract Class
using static System.Runtime.InteropServices.JavaScript.JSType;

public abstract class HouseBuilder
{
    // Template Method
    public void BuildHouse()
    {
        BuildFoundation();
        BuildWalls();
        BuildRoof();
        AddInterior();
        Console.WriteLine("House construction completed.");
    }

    protected abstract void BuildFoundation();
    protected abstract void BuildWalls();
    protected abstract void BuildRoof();

    // Hook method (optional step, subclasses can override)
    protected virtual void AddInterior()
    {
        Console.WriteLine("Adding basic interior.");
    }
}

// Concrete Class
public class WoodenHouseBuilder : HouseBuilder
{
    protected override void BuildFoundation()
    {
        Console.WriteLine("Building wooden foundation.");
    }

    protected override void BuildWalls()
    {
        Console.WriteLine("Building wooden walls.");
    }

    protected override void BuildRoof()
    {
        Console.WriteLine("Building wooden roof.");
    }

    protected override void AddInterior()
    {
        Console.WriteLine("Adding luxurious wooden interior.");
    }
}

// Concrete Class
public class ConcreteHouseBuilder : HouseBuilder
{
    protected override void BuildFoundation()
    {
        Console.WriteLine("Building concrete foundation.");
    }

    protected override void BuildWalls()
    {
        Console.WriteLine("Building concrete walls.");
    }

    protected override void BuildRoof()
    {
        Console.WriteLine("Building concrete roof.");
    }
}

// Real - life Use Case: Data Processing Algorithm
// ===============================================
// Use Case:
// In scenarios where you have a common algorithm with certain steps, but the implementation
// of some steps can vary. The template method pattern defines the skeleton of an algorithm
// but lets subclasses override specific steps.

// Template Method
public abstract class DataProcessor
{
    public void ProcessData()
    {
        ExtractData();
        TransformData();
        LoadData();
    }

    protected abstract void ExtractData();
    protected abstract void TransformData();
    protected abstract void LoadData();
}

// Concrete Class
public class CsvDataProcessor : DataProcessor
{
    protected override void ExtractData()
    {
        Console.WriteLine("Extracting data from CSV file.");
    }

    protected override void TransformData()
    {
        Console.WriteLine("Transforming CSV data.");
    }

    protected override void LoadData()
    {
        Console.WriteLine("Loading CSV data into database.");
    }
}

// Concrete Class
public class XmlDataProcessor : DataProcessor
{
    protected override void ExtractData()
    {
        Console.WriteLine("Extracting data from XML file.");
    }

    protected override void TransformData()
    {
        Console.WriteLine("Transforming XML data.");
    }

    protected override void LoadData()
    {
        Console.WriteLine("Loading XML data into database.");
    }
}
