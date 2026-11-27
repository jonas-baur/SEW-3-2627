namespace _3_Versicherungen_Klassen;

public class Person(int id)
{
    public int Id = id;
    private List<InsuranceContract> _insurances = [];
    private List<InsuranceContract> _coInsured = [];

    public void SignInsurance(InsuranceContract insuranceContract)
    {
        _insurances.Add(insuranceContract);
    }

    public void JoinInsurance(InsuranceContract insuranceContract)
    {
        _coInsured.Add(insuranceContract);
    }
}