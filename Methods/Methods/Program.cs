using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Exanple
            /// public int Add(int num1, int num2)
            /// {
            ///     int result = num1 + num2;
            ///     return result;
            ///  }    
            ///   Can also be done as return num1 + num2

            WriteSomething();
            WriteSomethingSpecific("I am an argument and am called from a method");
            Console.WriteLine(Add(15, 31)); // can use the method call as an argument
            Console.WriteLine(Add(Add(2,1),Add(4,3)));
            Console.WriteLine(Multiplier(9,9));
            Console.WriteLine(Division(144,12));
            Console.Read();
        }

        public static void WriteSomething()
        {
            // Must be static to be called from static Method like Main
            Console.WriteLine("I an called from a method");
            //Console.Read();
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            //Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiplier(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
