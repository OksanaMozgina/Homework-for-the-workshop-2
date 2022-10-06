/*Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine($"{dayNumber} -> да");
    }
    else 
    {
    Console.WriteLine($"{dayNumber} -> нет");
    }
}

CheckingTheDayOfTheWeek(5);
