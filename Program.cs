namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose the first number: ");
        var a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Choose the second number: ");
        var b = Convert.ToInt32(Console.ReadLine());

        char op;

        while (true)
        {
            Console.WriteLine("Choose the operation: (+, -, *, /)");
            op = Convert.ToChar(Console.ReadLine());

            if (op == '+' || op == '-' || op == '*' || op == '/')
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong Operation! please try again!");
            }
        }

        switch (op)
        {
            case '+':
                var AddResult = a + b;
                Console.WriteLine("The result of adding your two numbers is: " + AddResult);
                break;
            case '-':
                var SubResult = a - b;
                Console.WriteLine("The result of subtracting your two numbers is: " + SubResult);
                break;
            case '*':
                var MultiplyResult = a * b;
                Console.WriteLine("The result of multiplying your two numbers is: " + MultiplyResult);
                break;
            case '/':
                var DivideResult = a / b;
                Console.WriteLine("The result of divide your two numbers is: " + DivideResult);
                break;
        }
    }
}