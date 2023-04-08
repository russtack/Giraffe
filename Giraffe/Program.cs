internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("enr operator: ");
        string op = Console.ReadLine();
        Console.WriteLine("enr sec numbah: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (op == "-")
        {
            Console.WriteLine(num1 - num2);
        }
        else if (op == "+") { Console.WriteLine(num1 + num2); }
        else if(op == "*") { Console.WriteLine(num1 * num2); }
        else if (op == "/") { Console.WriteLine(num1 / num2); }
        else { Console.WriteLine("invalid operator"); }

        
        
    }
   
}