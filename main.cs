using System;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start up c#");
            int age = 20;
            long long_int = 203203827;
            double decimal_15 = 20.112356734521111;
            float avenum = 6.7f;
            string fname ="First", 
                mname = "Middle", 
                lnmae = "last",
                suffix;
            char mnamesingle = 'M';
            bool ismale = true;

            suffix = "jr";

            Console.WriteLine("Name: " + fname + " " + mname + " / " + mnamesingle + " " + lnmae + " " + suffix);
            Console.WriteLine("Is Male: " + ismale);
            Console.WriteLine("Ave num chosen: " + avenum);
            Console.WriteLine("double: " + decimal_15);
            Console.WriteLine("long int: " + long_int);
            Console.WriteLine("Age: " + age);


            suffix = "III";

            Console.WriteLine("Name: " + fname + " " + mname + " / " + mnamesingle + " " + lnmae + " " + suffix);
        }
    }
}
