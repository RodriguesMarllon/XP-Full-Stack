using ExemploFundamentos.Models;

bool isOfLegalAge = true;
bool hasAuthorization = false;

if (isOfLegalAge || hasAuthorization)
{
    Console.WriteLine("Access allowed!");
}
else
{
    Console.WriteLine("Access denied!");
}