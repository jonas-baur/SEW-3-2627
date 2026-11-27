namespace _2_Personenverwaltung;

public class Person(int id, string firstName, string lastName, string? eMail, DateTime birthdate, Address mainResidence)
{
    public int Id = id;
    public string FirstName = firstName;
    public string LastName = lastName;

    public string? EMail
    {
        get;
        set
        {
            if (value == null || value.Contains('@')) field = value;
            else throw new ArgumentException("Invalid EMail format");
        }
    } = eMail;

    public DateTime Birthdate
    {
        get;
        set
        {
            if (DateTime.Compare(value, DateTime.Now) <= 0) field = value;
            else throw new ArgumentException("Birthdate can't be set in the future");
        }
    } = birthdate;
    public Address MainResidence = mainResidence;

    public int GetAge()
    {
        return DateTime.Now.Year - Birthdate.Year;
    }

    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }

    public override string ToString()
    {
        return $"{Id}, {FullName()}{(EMail == null ? "" : $", EMail: {EMail}")}, born {Birthdate}, main residence at: {MainResidence}";
    }
}