/*Задача 15: 
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int NumberWeek()
{

    bool NumberWeek = true;
    int number = 0;

    while (NumberWeek)
    {
        Console.Write("Введите день недели : ");
        string numbS = Console.ReadLine();

        if (int.TryParse(numbS, out int numbI))
        {
            number = numbI;
            if (number > 7 || number < 1)
                Console.WriteLine("Нет такого дня недели, нужно было ввести от 1 до 7");
            else NumberWeek = false;
        }
        else Console.WriteLine("Вы ввели текст , повторите попытку");
    }
    return number;
}

int number = NumberWeek();

if (number == 7 || number == 6) Console.WriteLine($"{number} - > ДА! это выходной!");
else Console.WriteLine($"{number} - > Нет, ещё не выходной  ");


Console.Write("\n");                  // пустая строка
