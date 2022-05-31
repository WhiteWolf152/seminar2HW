/*
Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


int num()
{
    bool readNum = true;
    int number = 0;

    while (readNum)
    {
        Console.Write("Введите трёхзначное число : ");
        string numbS = Console.ReadLine();

        if (int.TryParse(numbS, out int numbI) && (numbS.Length == 3))
        {
            number = numbI;
            readNum = false;
        }

        else if (int.TryParse(numbS, out numbI) && (numbS.Length != 3))
            Console.WriteLine("Нужно ввести трёхзначное число ");

        else Console.WriteLine("Вы ввели текст, нужно ввести трёхзначное число ");
    }
    return number;
}
int number = num();
int secondCharNumber = (number % 100) / 10;
Console.WriteLine($"{number} -> {secondCharNumber}");

Console.Write("\n");                    // пустая строка
