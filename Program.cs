using System;

class Calculator
{
    static void Main(string[] args)
    {
        double a, b;
        char op;
        Console.WriteLine("Enter first number");
        a = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter second number");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Note: Enter operators between +, -, *, /");
        Console.Write("Enter operator\n");
        op = Convert.ToChar(Console.ReadLine());

        if (op == '+')
        {
            Console.WriteLine($"Results of {a} + {b} = {a+b}");
        }
        else if (op == '-')
        {
            Console.WriteLine($"Results of {a} - {b} = {a-b}");
        }
        else if (op == '*')
        {
            Console.WriteLine($"Results of {a} * {b} = {a*b}");
        }
        else if (op == '/')
        {
            Console.WriteLine($"Results of {a} / {b} = {a/b}");
        }
        else
        {
            Console.WriteLine("Wrong operator");
        }
    }
}
