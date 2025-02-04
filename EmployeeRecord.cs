
using System;
class Employee
{

    public int EmployeeID { get; set; }
    protected string Department { get; set; }
    private decimal Salary { get; set; }

    // Constructor to initialize Employee details
    public Employee(int employeeID, string department, decimal salary)
    {
        EmployeeID = employeeID;
        Department = department;
        Salary = salary;
    }

    public decimal GetSalary() => Salary;
    public void SetSalary(decimal salary) => Salary = salary;

    // Method to display employee details
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee ID: {EmployeeID}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Salary: ${Salary}");
    }
}

class Manager : Employee
{
    // Constructor to initialize Manager details, calling base class constructor
    public Manager(int employeeID, string department, decimal salary)
        : base(employeeID, department, salary) { }

    public void DisplayManagerDetails()
    {
        Console.WriteLine($"Manager Employee ID: {EmployeeID}");
        Console.WriteLine($"Department: {Department}");
    }
}

class Program
{
    static void Main()
    {
        // Create an Employee instance
        Employee employee1 = new Employee(1001, "HR", 50000);
        employee1.DisplayEmployeeDetails();

        employee1.SetSalary(55000);
        Console.WriteLine($"Updated Salary: ${employee1.GetSalary()}");
        Console.WriteLine();

        Manager manager1 = new Manager(2001, "IT", 80000);
        manager1.DisplayManagerDetails();
        manager1.DisplayEmployeeDetails();
        Console.ReadLine();
    }
}

