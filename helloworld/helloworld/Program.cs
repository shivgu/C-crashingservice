using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write your name");
            var name = Console.ReadLine();
            Console.WriteLine(name);


            Console.WriteLine("Please write your age");
            var age = Console.ReadLine();
            Console.WriteLine(age);


            Console.WriteLine("Please write your month of birth");
            var month = Console.ReadLine();
            Console.WriteLine("your month birth is {0}",month);

            if (month == "March")
            {
                Console.WriteLine("you are aries");

            }


        }
    }
}
