/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

void AnswerToTask(int number)
{
    string numericAsString = number.ToString();
    int result = int.Parse(numericAsString[1].ToString());
    Console.WriteLine($"Result numeric: {result}");
}
AnswerToTask(567);
