Employees employee1 = new Employees(); // object instance
employee1.name = "Cara";                // object attributes
employee1.lastName = "Flemings";
employee1.idNumber = 1008;
employee1.department = "HR";

employee1.EmployeeDetails();

Employees employee2 = new Employees();
employee2.name = "Derek";
employee2.lastName = "Chauvin";
employee2.idNumber = 1012;
employee2.department = "Product Management";

employee2.EmployeeDetails();

class Employees
{
    public string name;
    public string lastName;
    public int idNumber;
    public string department;

    public void EmployeeDetails()
    {
        Console.WriteLine("Employee Name: {0}", name);
        Console.WriteLine("Employee Last Name: {0}", lastName);
        Console.WriteLine("Employee ID Number: {0}", idNumber);
        Console.WriteLine("Employee Department: {0}", department);
    }
}