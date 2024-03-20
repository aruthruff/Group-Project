using System;

public class Park
{
    // Data members
    private string name;
    private string location;
    private string typeOfFacility;
    private double fee;
    private int numberOfEmployees;
    private int numberOfVisitors;
    private double annualBudget;

    // Constructor
    public Park(string name, string location, string typeOfFacility, double fee, int numberOfEmployees, int numberOfVisitors, double annualBudget)
    {
        this.name = name;
        this.location = location;
        this.typeOfFacility = typeOfFacility;
        this.fee = fee;
        this.numberOfEmployees = numberOfEmployees;
        this.numberOfVisitors = numberOfVisitors;
        this.annualBudget = annualBudget;
    }

    // Instance methods
    public string GetName()
    {
        return name;
    }

    public string GetParkInfo()
    {
        return $"Park Name: {name}\nLocation: {location}\nFacility Type: {typeOfFacility}";
    }

    public double ComputeCostPerVisitor()
    {
        return annualBudget / numberOfVisitors;
    }

    public double ComputeRevenueFromFees()
    {
        return numberOfVisitors * fee;
    }

    public override string ToString()
    {
        return $"Park Name: {name}\nLocation: {location}\nFacility Type: {typeOfFacility}\nFee: {fee}\nNumber of Employees: {numberOfEmployees}\nNumber of Visitors: {numberOfVisitors}\nAnnual Budget: {annualBudget}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Testing Park class
        Park centralPark = new Park("Central Park", "New York", "Local", 10.50, 100, 1000000, 5000000);

        Console.WriteLine(centralPark.GetName());
        Console.WriteLine(centralPark.GetParkInfo());
        Console.WriteLine($"Cost Per Visitor: ${centralPark.ComputeCostPerVisitor():F2}");
        Console.WriteLine($"Revenue from Fees: ${centralPark.ComputeRevenueFromFees():F2}");
        Console.WriteLine(centralPark.ToString());
    }
}
