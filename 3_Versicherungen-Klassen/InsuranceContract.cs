namespace _3_Versicherungen_Klassen;

public class InsuranceContract(InsuranceCompany insuranceCompany, Person policyHolder, List<Person> coInsured)
{
    private InsuranceCompany _insuranceCompany = insuranceCompany;
    private Person _policyHolder = policyHolder;
    private List<Person> _coInsured = coInsured;
}