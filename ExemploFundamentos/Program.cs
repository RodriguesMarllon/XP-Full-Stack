using ExemploFundamentos.Models;

Console.WriteLine("Type a letter: ");
string letter = Console.ReadLine();

switch (letter)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vowel");
        break;

    default:   
        Console.WriteLine("Is not a vowel");
        break;
}