using System;

namespace StructureTypes3
{
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

    class Program
    {
        static void Main(string[] args)
        {
            NamedPoint np1 = new("A", 0, 0);
            Console.WriteLine($"{nameof(np1)}: {np1}");

            var np2 = np1 with { Name = "B", X = 5 };
            Console.WriteLine($"{nameof(np2)}: {np2}");

            var np3 = np1 with
            {
                Name = "C",
                Y = 4
            };
            Console.WriteLine($"{nameof(np3)}: {np3}");

            Console.WriteLine($"{nameof(np1)}: {np1}");
        }
    }
}

