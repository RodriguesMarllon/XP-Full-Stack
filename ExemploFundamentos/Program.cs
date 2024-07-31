using ExemploFundamentos.Models;

int quantityInStock = 10;
int quantityPurchase = 0;
bool isPossibleSale = quantityPurchase > 0 && quantityInStock >= quantityPurchase;

Console.WriteLine($"Quantity in stock: {quantityInStock}");
Console.WriteLine($"Quantity purchase: {quantityPurchase}");
Console.WriteLine($"Is it possible to make the sale? {isPossibleSale} ");


if(quantityPurchase == 0)
{
    Console.WriteLine("Invalid sale.");
}
else if (isPossibleSale)
{
    Console.WriteLine("Sale made.");
}
else
{
    Console.WriteLine("Sorry. We do not have de desired quantity in stock.");
}