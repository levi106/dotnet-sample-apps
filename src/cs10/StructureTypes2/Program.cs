using System;

namespace StructureTypes2
{
    public readonly struct Measurement
    {
        public double Value { get; init; }
        public string Description { get; init; }

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

    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}

