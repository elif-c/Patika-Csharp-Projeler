// normally we access functions, variables inside a class by using an
// object instance of that class

// for static elements, we can access them using their class names
// "staticClassName.methodName"
// cannot create object instances !!

class Program
{
    static void Main(string[] args)
    {   
        // can only access the public variables using the class name
        Console.WriteLine("Employee number: {0}", Employee.EmployeeNumber);
        Employee employee1 = new Employee("Angelina", "Jolie", "Marketing");
        // employee1.Name => would not work because the strings are not public
        Console.WriteLine("Employee number: {0}", Employee.EmployeeNumber);

        long sum = Processes.Sum(100, 200);
        Console.WriteLine("The sum is: {0}", sum);
    }
}


class Employee
{
    private static int employeeNumber;

    public static int EmployeeNumber
    {
        get { return employeeNumber; } // no set, changing the value only through the class
        // it will be accessed through the class, and it will always
        // return the last changed value
    }

    private string Name;
    private string LastName;
    private string Department;

    static Employee()
    {
        // static methods don't have access modifiers (public / private)
        // setting employeeNumber to 0 at the start
        employeeNumber = 0;

        // static constructor method only works once at the start

    }

    public Employee(string name, string lastName, string department)
    {   
        // constructor methods are public
        this.Name = name;
        this.LastName = lastName;
        this.Department = department;
        employeeNumber++; // incrementing the private variable by 1
        // accessed every time an object is created
        
    }

}

static class Processes
{
    // static keyword makes the data item non-instantiable
    // everything can only be static
    public static long Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    // also cannot use "this" keyword inside a static method
    // because "this" keyword refers to the current instance of the class
}