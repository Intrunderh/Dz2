﻿int InputSecondNumber(int num)
{
    int count;
    count = num % 100 / 10;
    return count;
}

Console.Write("Input three-digit nubmer: ");
int num = Convert.ToInt32(Console.ReadLine());
int secondNumber = InputSecondNumber(num);
Console.Write($"The second digit of {num} is {secondNumber}");