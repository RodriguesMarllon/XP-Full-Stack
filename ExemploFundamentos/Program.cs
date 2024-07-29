using ExemploFundamentos.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Person p = new()
        {
            Name = "Marllon",
            Age = 19
        };

        p.Apresentar();
    }
}