namespace _2_Personenverwaltung;

public static class Program
{
    static void Main()
    {
        List<Address> addresses =
        [
            new Address("Hauptstraße", "12a", 3340, "Waidhofen an der Ybbs", "Niederösterreich"),
            new Address("Mariahilfer Straße", " 45", 1060, "Wien", "Wien"),
            new Address("Herrengasse", "8", 8010, "Graz", "Steiermark"),
            new Address("Maria-Theresien-Straße", "21", 6020, "Innsbruck", "Tirol")
        ];

        List<Person> people =
        [
            new Person(1, "Anna", "Huber", "anna.huber@example.at", new DateTime(2009, 3, 12), addresses[0]),
            new Person(2, "Markus", "Huber", "markus.huber@example.at", new DateTime(1980, 7, 5), addresses[0]),
            new Person(3, "Sabine", "Huber", "sabine.huber@example.at", new DateTime(1982, 11, 19), addresses[1]),
            new Person(4, "Lukas", "Gruber", "lukas.gruber@example.at", new DateTime(2001, 1, 23), addresses[1]),
            new Person(5, "Mira", "Yilmaz", "mira.yilmaz@example.at", new DateTime(1999, 9, 14), addresses[2]),
            new Person(6, "Thomas", "Bauer", "thomas.bauer@example.at", new DateTime(1975, 4, 30), addresses[2]),
            new Person(7, "Julia", "Steiner", "julia.steiner@example.at", new DateTime(2004, 12, 8), addresses[3]),
            new Person(8, "Felix", "Moser", "felix.moser@example.at", new DateTime(2003, 6, 17), addresses[3])
        ];

        int totalAge = 0;
        foreach (var person in people)
        {
            Console.WriteLine(person);
            totalAge += person.GetAge();
        }
        Console.WriteLine($"Average Age: {totalAge/people.Count}");

        foreach (var address in addresses)
        {
            List<Person> included = people.Where(person => person.MainResidence == address).ToList();
            
            Console.WriteLine($"{address}: {String.Join(',', included.Select(person => person.FullName()))}");
        }
        
        Console.WriteLine("Filter (by State):");
        string? input = Console.ReadLine();
        if (input != null)
        {
            string inputSaved = input;
            List<Person> included = [.. people.Where(person => person.MainResidence.State == inputSaved)];
            
            Console.WriteLine($"Result: {String.Join(',', included.Select(person => person.FullName()))}");
        }
        else Console.WriteLine("No valid input given, skipping.");
        
        Console.Write("Filter (by shared residence): ");
        for (int i = 0; i < people.Count; i++)
        {
            Console.WriteLine($"({i}){people[i].FullName()}");
        }
        input = Console.ReadLine();
        if (input != null && int.TryParse(input, out var result))
        {
            List<Person> included =
                [.. people.Where(person => person.MainResidence == people[result].MainResidence && person != people[result])];
            Console.WriteLine($"Result: {String.Join(',', included.Select(person => person.FullName()))}");
        }
        else Console.WriteLine("No valid input given, skipping.");

        Console.ReadKey();
    }
}