// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record#inheritance

using System.Text;

Person1 person1 = new("Nancy", "Davolio");
Console.WriteLine(person1);

Teacher1 teacher1 = new("Nancy", "Davolio", 3);
Console.WriteLine(teacher1);

Person2 person2 = new("Nancy", "Davolio");
Console.WriteLine(person2);

Teacher2 teacher2 = new("Nancy", "Davolio", 3);
Console.WriteLine(teacher2);

public record Person1(string FirstName, string LastName)
{
    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append("Person😀");
        builder.Append(" { ");
        if (PrintMembers(builder))
        {
            builder.Append(" ");
        }
        builder.Append("}");
        return builder.ToString();        
    }
}

public record Teacher1(string FirstName, string LastName, int Grade)
    : Person1(FirstName, LastName);

public record Person2(string FirstName, string LastName)
{
    public sealed override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append("Person🥲");
        builder.Append(" { ");
        if (PrintMembers(builder))
        {
            builder.Append(" ");
        }
        builder.Append("}");
        return builder.ToString();
    }
}

public record Teacher2(string FirstName, string LastName, int Grade)
    : Person2(FirstName, LastName);
