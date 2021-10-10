// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record

Person person1 = new("Nancy", "Davolio");

Console.WriteLine(person1);

Person person2 = person1 with { FirstName = "John" };

Console.WriteLine(person2);

Point point1 = new(1, 2, 3);

Console.WriteLine(point1);

Point point2 = point1 with { X = 4 };

Console.WriteLine(point2);

public record Person(string FirstName, string LastName);

public readonly record struct Point(double X, double Y, double Z);

