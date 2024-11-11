namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Basic Calculator(Press 'q' for quit.))");
            Console.WriteLine("*******************************");

            while (true)
            {
                Console.WriteLine("+,-,*,/:");

                string ope = Console.ReadLine();

                if (ope == "q")
                {
                    break;
                }
                
                if (ope == "+")
                {
                    Console.WriteLine("1.Number:");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("2.Number:");
                    double y = double.Parse(Console.ReadLine());
                    
                    double sum = x + y;
                    
                    Console.WriteLine($"{x} + {y} = {sum}");
                }

                else if (ope == "-")
                {
                    Console.WriteLine("1.Number:");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("2.Number:");
                    double y = double.Parse(Console.ReadLine());

                    double sum = x - y;

                    Console.WriteLine($"{x} - {y} = {sum}");
                }

                else if (ope == "*")
                {
                    Console.WriteLine("1.Number:");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("2.Number:");
                    double y = double.Parse(Console.ReadLine());
                    
                    double sum = x * y;
                    
                    Console.WriteLine($"{x} * {y} = {sum}");
                }

                else if (ope == "/")
                {
                    Console.WriteLine("1.Number:");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("2.Number:");
                    double y = double.Parse(Console.ReadLine());
                    
                    double sum = x / y;
                    
                    Console.WriteLine($"{x} / {y} = {sum}");
                }

                else
                {
                    Console.WriteLine("İnvalid transaction");
                }
            }
        }
    }
}