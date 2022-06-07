// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to warehouse app!");
Console.WriteLine("Please let me know what you want to do:");
Console.WriteLine("1. Add Item");
Console.WriteLine("2. Remove Item");
Console.WriteLine("3. Check Item");
Console.WriteLine("Press 1, 2 or 3...");

string? choice = Console.ReadLine();

Console.WriteLine($"YOu have chosen option number: {choice}");

int chosenOption = 0;
int.TryParse(choice, out chosenOption);

Console.WriteLine("Please choose another option...");

choice = Console.ReadLine();
