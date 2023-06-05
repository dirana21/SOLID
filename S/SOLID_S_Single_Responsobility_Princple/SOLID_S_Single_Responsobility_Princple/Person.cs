namespace SOLID_S_Single_Responsobility_Princple;

public class Person
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public DateTime dateOfBirth { get; set; }

    public override string ToString()
    {
        return $"\nFirstName: {firstName}\nLastName: {lastName}\nDateOfBirthday: {dateOfBirth}";
    }
}