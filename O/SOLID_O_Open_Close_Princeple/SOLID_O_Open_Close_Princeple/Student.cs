namespace SOLID_O_Open_Close_Princeple;

public class Student : Person
{
    public string faculty { get; set; }
    
    public override void Print()
    {
        Console.WriteLine($"{lastname}, {firstName}, {age}, {faculty}");
    }
}