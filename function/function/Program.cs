
bool continueCalculating = true;

while (continueCalculating)
{


    Console.WriteLine("Please Enter First Number");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please Enter Second Number");
    int y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please Enter the operation (+, -, *, /)");
    string op = Console.ReadLine();


    Calculate(x, y, op);


    Console.WriteLine("Did you want another Operation? (yes/no)");
    string response = Console.ReadLine().ToLower();

    if (response == "yes" || response == "y")
    {
        continueCalculating = true;
    }
    else
    {
        continueCalculating = false;
        Console.WriteLine("Thank you for using the calculator!");
    }
}


void Calculate(int num1, int num2, string operation)
{
    if (operation == "+")
    {
        Console.WriteLine($"Result: {num1 + num2}");
    }
    else if (operation == "-")
    {
        Console.WriteLine($"Result: {num1 - num2}");
    }
    else if (operation == "*")
    {
        Console.WriteLine($"Result: {num1 * num2}");
    }
    else if (operation == "/")
    {
        // تصحيح: التحقق من أن المقام (num2) لا يساوي صفر
        if (num2 != 0)
            Console.WriteLine($"Result: {(double)num1 / num2}");
        else
            Console.WriteLine("Error: Cannot divide by zero.");
    }
    else
    {
        Console.WriteLine("Invalid Operation.");
    }
}