// Template Method Pattern:
// ========================
// Define the skeleton of an algorithm in the superclass but let subclasses override specific
// steps of the algorithm without changing its structure.
// Example in .NET:
// Let's implement a template method for building houses with different construction steps.

// Example usage
var woodenHouseBuilder = new WoodenHouseBuilder();
woodenHouseBuilder.BuildHouse();
/* Output:
   Building wooden foundation.
   Building wooden walls.
   Building wooden roof.
   Adding luxurious wooden interior.
   House construction completed.
*/

var concreteHouseBuilder = new ConcreteHouseBuilder();
concreteHouseBuilder.BuildHouse();
/* Output:
   Building concrete foundation.
   Building concrete walls.
   Building concrete roof.
   Adding basic interior.
   House construction completed.
*/

// Real - life Use Case: Data Processing Algorithm
// ===============================================
// Use Case:
// In scenarios where you have a common algorithm with certain steps, but the implementation
// of some steps can vary. The template method pattern defines the skeleton of an algorithm
// but lets subclasses override specific steps.

// Example usage
var csvProcessor = new CsvDataProcessor();
csvProcessor.ProcessData();
/* Output:
   Extracting data from CSV file.
   Transforming CSV data.
   Loading CSV data into database.
*/

var xmlProcessor = new XmlDataProcessor();
xmlProcessor.ProcessData();
/* Output:
   Extracting data from XML file.
   Transforming XML data.
   Loading XML data into database.
*/

