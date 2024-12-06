using System;

class Program
{
    static void Main(string[] args)
    {
        // Введення курсів валют
        Console.Write("Enter the dollar rate (UAH to 1 Dollar): ");
        decimal dollarRate = decimal.Parse(Console.ReadLine());

        Console.Write("Enter the euro rate (UAH to 1 Euro): ");
        decimal euroRate = decimal.Parse(Console.ReadLine());

        // Створення об'єкта Converter
        Converter converter = new Converter(dollarRate, euroRate);

        Console.WriteLine("\nChoose conversion option:");
        Console.WriteLine("1. Convert from UAH to Dollar");
        Console.WriteLine("2. Convert from UAH to Euro");
        Console.WriteLine("3. Convert from Dollar to UAH");
        Console.WriteLine("4. Convert from Euro to UAH");

        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.Write("Enter amount in UAH: ");
                decimal amountInUahToDollar = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"{amountInUahToDollar} UAH = {converter.ConvertToDollar(amountInUahToDollar)} Dollars");
                break;
            case 2:
                Console.Write("Enter amount in UAH: ");
                decimal amountInUahToEuro = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"{amountInUahToEuro} UAH = {converter.ConvertToEuro(amountInUahToEuro)} Euros");
                break;
            case 3:
                Console.Write("Enter amount in Dollars: ");
                decimal amountInDollarToUah = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"{amountInDollarToUah} Dollars = {converter.ConvertFromDollar(amountInDollarToUah)} UAH");
                break;
            case 4:
                Console.Write("Enter amount in Euros: ");
                decimal amountInEuroToUah = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"{amountInEuroToUah} Euros = {converter.ConvertFromEuro(amountInEuroToUah)} UAH");
                break;
            default:
                Console.WriteLine("Invalid option!");
                break;
        }
    }
}
