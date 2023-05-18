using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.Name = "Claire";
        student1.LastName = "Boucher";
        student1.StudentNumber = 305;
        student1.ClassTag = 6;
        student1.FetchStudentInfo();

        student1.ClassDecrement();
        student1.FetchStudentInfo();

        Student student2 = new Student("Robin", "Fenty", 307, 1);
        student2.ClassDecrement();
        student2.ClassDecrement();
        student2.FetchStudentInfo();
    }
}

class Student 
{   
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private string lastName;
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    private int studentNumber;
    public int StudentNumber
    {
        get { return studentNumber; }
        set { studentNumber= value; }
    }

    private int classTag;
    public int ClassTag
    {
        get { return classTag; }
        set
        {
            if (value < 1)
            {
                Console.WriteLine("Class should be at least 1.");
                classTag = 1;
            }
            else
            {
                classTag = value;
            }
        }
    }

    public Student(string name, string lastName, int studentNumber, int classTag) 
    {
        Name = name;
        LastName = lastName;
        StudentNumber = studentNumber;
        ClassTag = classTag;
    }

    public Student(){ }

    public void FetchStudentInfo()
    {
        Console.WriteLine("Student name: {0}", this.Name);
        Console.WriteLine("Student last name: {0}", this.LastName);
        Console.WriteLine("Student number: {0}", this.StudentNumber);
        Console.WriteLine("Student class: {0}", this.ClassTag);
    }

    public void ClassDecrement()
    {
        this.ClassTag = this.classTag - 1;
    }
}