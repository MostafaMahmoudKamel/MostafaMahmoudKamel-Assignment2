

while (true)
{
    //Reading input from the user
    Console.Write("Enter the first number: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the second number: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    //catching the divide by zero 
    if (num2 == 0)
    {
        Console.WriteLine("Cannot divide by zero.");
        continue;
    }
    else
    {
        Console.WriteLine($"The division of {num1} and {num2} is {num1 / num2}");
    }

    //result
    Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2} ");
    Console.WriteLine($"The substraction of {num1} and {num2} is {num1 - num2} ");
    Console.WriteLine($"The multiplication of {num1} and {num2} is {num1 * num2} ");
    Console.WriteLine($"The division of {num1} and {num2} is {num1 / num2} ");
}
