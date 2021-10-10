// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct#parameterless-constructors-and-field-initializers
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/with-expression

var m1 = new Measurement();
Console.WriteLine(m1);

var m2 = default(Measurement);
Console.WriteLine(m2);

var ms = new Measurement[2];
Console.WriteLine(String.Join(", ", ms));

var m3 = new Measurement2(5);
Console.WriteLine(m3);

var m4 = new Measurement2();
Console.WriteLine(m4);

var m5 = new Measurement3();
Console.WriteLine(m5);

var p1 = new Coords();
Console.WriteLine(p1);

var p2 = default(Coords);
Console.WriteLine(p2);

var ps = new Coords[3];
Console.WriteLine(string.Join(", ", ps));

NamedPoint np1 = new("A", 0, 0);
Console.WriteLine($"{nameof(np1)}: {np1}");

// Build Error on C# 9.0 (CS8773)
var np2 = np1 with { Name = "B", X = 5 };
Console.WriteLine($"{nameof(np2)}: {np2}");

// Build Error on C# 9.0 (CS8773)
var np3 = np1 with
{
    Name = "C",
    Y = 4
};
Console.WriteLine($"{nameof(np3)}: {np3}");

Console.WriteLine($"{nameof(np1)}: {np1}");

public readonly struct Measurement
{
    public double Value { get; init; }
    public string Description { get; init; }

    // Build Error on C# 9.0 (CS8773)
    public Measurement()
    {
        Value = double.NaN;
        Description = "Undefined";
    }

    public Measurement(double value, string description)
    {
        Value = value;
        Description = description;
    }

    public override string ToString() => $"{Value} ({Description})";
}

public readonly struct Measurement2
{
    public double Value { get; init; }
    // Build Error on C# 9.0 (CS8773)
    public string Description { get; init; } = "Ordinary measurement";

    public Measurement2(double value)
    {
        Value = value;
    }

    public Measurement2(double value, string description)
    {
        Value = value;
        Description = description;
    }

    public override string ToString() => $"{Value} ({Description})";
}

public readonly struct Measurement3
{
    public double Value { get; init; }
    public string Description { get; init; }

    public Measurement3(double value, string description)
    {
        Value = value;
        Description = description;
    }
}

public struct Coords
{
    public double X = double.NaN;
    public double Y = double.NaN;

    public override string ToString() => $"({X}, {Y})";
}

public struct NamedPoint
{
    public string Name { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public NamedPoint(string name, int x, int y)
    {
        Name = name;
        X = x;
        Y = y;
    }

    public override string ToString() => $"Name = {Name}, X = {X}, Y = {Y}";
}
