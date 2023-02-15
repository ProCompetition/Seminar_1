// Напишите программу, которая выводит случайное число из отрезкка [10, 99] и показывает наибольшую цифру числа.

void MaxDecimal (int num)
{
    int ed = num % 10;
    int dec = num / 10;
    if(ed>dec)
    {
        Console.WriteLine($"Большая цифра числа {num} -> {ed}");
    }
    else
    {
        Console.WriteLine($"Большая цифра числа {num} -> {dec}");
    }
}

int randomnumber = new Random().Next(10, 100);

MaxDecimal(randomnumber);
