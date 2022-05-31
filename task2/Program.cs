/*Задача 13: 
Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int num()
{
    bool readNum = true;
    int number = 0;
    while (readNum)
    {
        Console.Write("Введите число для поиска третьей цифры : ");
        string numbS = Console.ReadLine();

        if (int.TryParse(numbS, out int numbI))        // проверка на текст
        {
            number = numbI;
            readNum = false;
        }
        else Console.WriteLine("вы ввели текст повторите попытку");
    }
    return number;
}

string number = Convert.ToString(num());

// 1

if (number[0] == '-')
{
    if (number.Length >= 4) Console.WriteLine($"{number} - > {number[3]}");
    else Console.WriteLine($"{number} - > нет 3го числа");
}
else
{
    if (number.Length >= 3) Console.WriteLine($"В Вашем числе {number} третья цифра - > {number[2]}");
    else Console.WriteLine($"{number} - > нет 3го числа");
}

Console.Write("\n");                  // пустая строка


