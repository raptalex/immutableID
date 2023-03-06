class Student
{
    // auto-implemented properties
    public int Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // default constructor
    public Student()
    {
        Id = 0;
        FirstName = "";
        LastName = "";
    }
    public Student(int i)
    {
        Id = i;
        FirstName = LastName = "";
    }
    // parameterized constructor
    public Student(int i, string First, string Last)
    {
        Id = i;
        FirstName = First;
        LastName = Last;
    }

}

class Program
{
    public static void Main()
    {
        Student student1 = new Student(77);
        student1.FirstName = "Mike";
        student1.LastName = "Jacobson";

        Student student2 = new Student(180, "Alex", "Steinberg");

        Console.WriteLine("ID: {0}", student1.Id);
        Console.WriteLine("First Name: {0}", student1.FirstName);
        Console.WriteLine("Last Name: {0}", student1.LastName);
        Console.WriteLine();
        Console.WriteLine("ID: {0}", student2.Id);
        Console.WriteLine("First Name: {0}", student2.FirstName);
        Console.WriteLine("Last Name: {0}", student2.LastName);
    }
}