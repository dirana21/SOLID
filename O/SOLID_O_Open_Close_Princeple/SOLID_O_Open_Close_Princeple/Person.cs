namespace SOLID_O_Open_Close_Princeple;

public abstract class Person
{
    public string firstName { get; set; }
    public string lastname { get; set; }
    public int age { get; set; }
    
    public virtual void Print()
    {
        Console.WriteLine($"{lastname}, {firstName}, {age}");
    }
}