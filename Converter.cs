using System;

public class Converter
{
    public decimal DollarToUah { get; private set; }
    public decimal EuroToUah { get; private set; }

    // Конструктор
    public Converter(decimal dollarRate, decimal euroRate)
    {
        DollarToUah = dollarRate;
        EuroToUah = euroRate;
    }

    // Метод для конвертації гривні в долари
    public decimal ConvertToDollar(decimal amountInUah)
    {
        return amountInUah / DollarToUah;
    }

    // Метод для конвертації гривні в євро
    public decimal ConvertToEuro(decimal amountInUah)
    {
        return amountInUah / EuroToUah;
    }

    // Метод для конвертації доларів в гривню
    public decimal ConvertFromDollar(decimal amountInDollar)
    {
        return amountInDollar * DollarToUah;
    }

    // Метод для конвертації євро в гривню
    public decimal ConvertFromEuro(decimal amountInEuro)
    {
        return amountInEuro * EuroToUah;
    }
}
