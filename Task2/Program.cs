/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите число: ");
int anyNumber = int.Parse(Console.ReadLine());
string anyNumberText = anyNumber.ToString();
int result = int.Parse(anyNumberText[2].ToString());
if (anyNumberText.Length > 2)
{
    Console.WriteLine($"{result}");
}
else
{
    Console.WriteLine($"третьей цифры нет");
}

