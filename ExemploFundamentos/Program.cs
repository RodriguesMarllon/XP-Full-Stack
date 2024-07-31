using ExemploFundamentos.Models;

int quantityInStock = 10;
int quantityPurchase = 11;
bool isPossibleSale = quantityInStock >= quantityPurchase;

Console.WriteLine($"Quantity in stock: {quantityInStock}");
Console.WriteLine($"Quantity purchase: {quantityPurchase}");
Console.WriteLine($"Is it possible to make the sale? {isPossibleSale} ");


if (isPossibleSale)
{
    Console.WriteLine("Sale made.");
}
else
{
    Console.WriteLine("Sorry. We do not have de desired quantity in stock.");
}