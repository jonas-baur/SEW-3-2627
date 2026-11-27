namespace _2_Personenverwaltung;

public class Address (string street, string houseNumber, int postalCode, string location, string state, string? country = null)
{
    public string Street = street;
    public string HouseNumber = houseNumber;

    public int PostalCode
    {
        get;
        set
        {
            if (value is >= 1000 and < 10000) field = value;
            else throw new ArgumentException("Postal Code not in valid range, can only be values from 1000 to 9999");
        }
    } = postalCode;

    public string Location = location;
    public string State = state;
    public string Country = country ?? "Austria";

    public override string ToString()
    {
        return $"{Location} {PostalCode}, {Street} {HouseNumber}, {State}, {Country}";
    }
}