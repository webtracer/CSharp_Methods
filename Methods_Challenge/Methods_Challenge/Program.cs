using System;

namespace Methods_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Laura";
            string friend2 = "Stew";
            string friend3 = "Kosta";

            Console.WriteLine(GreetFriend(friend1));
            Console.WriteLine(GreetFriend(friend2));
            Console.WriteLine(GreetFriend(friend3));
        }

        static string GreetFriend(string friendsName)
        {
            return $"Hi {friendsName}, my friend!";
        }

    }
}
