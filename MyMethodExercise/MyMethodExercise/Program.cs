using System;

namespace MyMethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Story();
            Add();
            Console.WriteLine("WOW that was the price you would of grabbed that record for!");
            Console.WriteLine($"Too bad your favoritate animal destoryed the all");
            Multiply();
            Console.WriteLine("This is how much of a profit you COULD of made");
            Console.WriteLine("If only you got here sooner");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("Anywho, you may have figured it out but a talking calculator");
            Console.WriteLine("Whats my purpose? who knows");
            Console.WriteLine("I guess ill continue... how about some division!");
            Divide();
            Console.WriteLine("Now do me a fovor, run me again! i want to live!!");
            Addition(5, 6);
            
            
            
                
            
            
        }

        public static void Story()
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("what is your Favorite Color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("Last but not least! Who is your favorite band?!");
            string favBand = Console.ReadLine();
            Console.WriteLine($"{name} the color {color} is a great color!");
            Console.WriteLine($"The {favAnimal} is pretty cool, but have you seen a Dinosaur?");
            Console.WriteLine($"{favBand} has signed records for sale, but a {color} {favAnimal}");
            Console.WriteLine($"broke into the store and destroyed them all!");
        }

        public static void Add()
        {
            Console.WriteLine("Put in any two numbers to add them together.");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int s = (x + y);
            Console.WriteLine($"The Sum of {x} and {y} is {s}");


        }

        public static void Multiply()
        {
            Console.WriteLine("Now I the Comptuer will Multiply any THREE numbers you enter!");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"okay {a} another number please?");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"okay so {a} time {b}...okay got it one more number!");
            int c = Convert.ToInt32(Console.ReadLine());
            int product = (a * b * c);
            Console.WriteLine($"The Product of {a},{b}, and {c} is {product}");

        }

        public static void Divide()
        {
            Console.WriteLine("Maybe i not the best at division... throw me some numbers!");
            double a = (double)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{a} okay one more please");
            double b = (double)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{a} divided by {b}");
            double q = (a / b);
            Console.WriteLine($"{q}! The Answer is {q}!");
            Console.WriteLine("WOW i feel so smart!");

        }

        public static void Addition(int x, int y)
        {

            Console.WriteLine("put in two numbers to add them together i hope");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{x+y}");


        }


        
    }
}
