namespace SOLID_S_Single_Responsobility_Princple;

public static class AddingANewPerson
{
    private static Person AddNewPerson(string firstName, string lastName, int year, int month, int day)
    {
        DateTime dateOfBirth = new DateTime(year, month, day);
        return new Person()
        {
            firstName = firstName,
            lastName = lastName,
            dateOfBirth = dateOfBirth
        };
    }

    public static Person AddPersonToList(string firstName, string lastName, int year, int month, int day)
    {
        return AddNewPerson(firstName, lastName, year, month, day);
    }
}