while (true)
{
    Console.Write("Enter the first number: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the second number: ");
    double num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2} ");
    Console.WriteLine($"The substraction of {num1} and {num2} is {num1 - num2} ");
    Console.WriteLine($"The multiplication of {num1} and {num2} is {num1 * num2} ");
    Console.WriteLine($"The division of {num1} and {num2} is {num1 / num2} ");
}