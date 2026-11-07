namespace _3_Versicherungen_Klassen;

public class Person(InsuranceContract insurances, InsuranceContract coInsured)
{
    private InsuranceContract _insurances = insurances;
    private InsuranceContract _coInsured = coInsured;
}