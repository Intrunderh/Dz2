﻿Console.Write("Input three-digit nubmer: ");
int num = Convert.ToInt32(Console.ReadLine());
int cifra;
if (cifra >= num % 100 % 10)
{
    Console.Write($"The third digit of {num} is {cifra}");
}
else if (cifra < num % 100 % 10)
{
    Console.WriteLine("No third digit");
}