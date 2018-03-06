using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
         
           
            const Byte sample1 = 0x3A;
            Byte sample2 = 58;
            int hearRate = 85;
            double deposits = 135002796;
            float acceleration = 9.800f;
            float mass = 14.6f;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const string greeting = "Hello";
            string name = "Karen";
             if(sample1 == sample2)
            {
                Console.Write("The samples are equal\n");
            }
             else
            {
                Console.Write("The samples are not equal\n");
            }
             if(40<= hearRate && hearRate <= 80)
            {
                Console.Write("Heart rate is normal\n");
            }
            else
            {
                Console.Write("Heart rate is not normal\n");
            }
            if(deposits >= 100000000)
            {
                Console.Write("You are exceedingly wealthy\n");
            }
            else
            {
                Console.Write("Sorry you are so poor\n");
            }
            float force = mass * acceleration;
            Console.Write("force = {0}\n", force);
            Console.Write("{0} is the distance\n", distance);
            if(lost == true && expensive == true)
            {
                Console.Write("I am really sorry! I will get the manager\n");
            }
            if(lost == true && expensive != true)
            {
                Console.Write("Here is coupon for 10% off\n");
            }
            switch (choice)
            {
                case 1: Console.Write("You chose 1\n");
                    break;
                case 2: Console.Write("You chose 2\n");
                    break;
                case 3: Console.Write("You chose 3\n");
                    break;
            }
            Console.Write("{0} is an integral\n", integral);
            for( int i = 5; i <=10; i++)
            {
                Console.Write("i= {0}\n", i);
            }
            int age = 0;
            while(age < 6)
            {
                Console.Write("age = {0}\n", age);
                age++;
            }
            Console.Write("{0} {1}\n", greeting, name);
        }
    }
}
