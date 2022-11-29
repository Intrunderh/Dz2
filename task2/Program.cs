Console.Write("Input three-digit nubmer: ");
int num = Convert.ToInt32(Console.ReadLine());
int count;
if (count >= num % 100 % 10)
{
    Console.Write($"The third digit of {num} is {count}");
}
else
{
    Console.WriteLine("No third digit");
}


// int InputSecondNumber(int num)
// {
//     int count;
//     count = num % 100 / 10;
//     return count;
// }

// Console.Write("Input three-digit nubmer: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int secondNumber = InputSecondNumber(num);
// Console.Write($"The second digit of {num} is {secondNumber}");