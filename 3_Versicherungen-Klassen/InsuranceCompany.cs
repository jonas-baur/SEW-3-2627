namespace _3_Versicherungen_Klassen;

public class InsuranceCompany(string name)
{
    public string Name = name;
    private List<InsuranceContract> _contracts = [];
}