namespace _3_Versicherungen_Klassen;

public class InsuranceContract
{
    private InsuranceCompany _insuranceCompany;
    private readonly Person _policyHolder;
    private readonly List<Person> _coInsured;

    public InsuranceContract(InsuranceCompany insuranceCompany, Person policyHolder, List<Person> coInsured)
    {
        _insuranceCompany = insuranceCompany;
        _policyHolder = policyHolder;
        _coInsured = coInsured;
        
        _insuranceCompany.ProvideInsurance(this);
        _policyHolder.SignInsurance(this);
        foreach (Person person in _coInsured) person.JoinInsurance(this);
    }
}