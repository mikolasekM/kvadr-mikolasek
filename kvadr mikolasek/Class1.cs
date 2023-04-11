using Spectre.Console;
class Projekt {

    private class Kvadr
    {
        public Kvadr(float a, float b, float c)
        {
            A = a;
            B = b;
            C = c;
        }

        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }

        public double vypocetObjemu()
        {
            return A * B * C;
        }
        public double vypocetPovrchu()
        {
            return 2 * (A * B + A * C + B * C);
        }
        public double vypocetTelesoveUhlopricky()
        {
            return Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2) + Math.Pow(C, 2));
        }
        public double vypocetStenoveUhlopricky()
        {
            return Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        }
    }

    public static void Main()
    {
        var input1 = AnsiConsole.Ask<float>("Velikost strany A: ");
        var input2 = AnsiConsole.Ask<float>("Velikost strany B: ");
        var input3 = AnsiConsole.Ask<float>("Velikost strany C: ");

        var kostka = new Kvadr(input1, input2, input3);
        Console.WriteLine("objem je:" + kostka.vypocetObjemu());
        Console.WriteLine("povrch je:" + kostka.vypocetPovrchu());
        Console.WriteLine("tělesová úhlopříčka je:" + kostka.vypocetTelesoveUhlopricky());
        Console.WriteLine("stěnová úhlopříčka je:" + kostka.vypocetStenoveUhlopricky());
    }
}
