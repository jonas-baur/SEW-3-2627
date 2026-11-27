namespace _3_Versicherungen_Klassen;

internal static class Program
{
    static void Main()
    {
        Random random = new Random();
        List<Person> people = [];
        for (int i = 0; i < 5; i++) people.Add(new (i));
        List<InsuranceCompany> companies =
        [
            new ("A1"),
            new ("A2")
        ];
        List<InsuranceContract> contracts = [];
        foreach (var company in companies)
        {
            for (int i = 0; i < 2; i++)
            {
                int policyHolderIndex = random.Next(0, people.Count);
                List<Person> coInsured = [];
                foreach (Person person in people) if (person != people[policyHolderIndex] && random.Next(2) == 1) coInsured.Add(person);
                contracts.Add(new (company, people[policyHolderIndex], coInsured));
            }
        }
        Console.ReadKey();
    }
}