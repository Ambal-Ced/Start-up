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
            string fname = "First",
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
            Console.WriteLine(123);//int
            Console.WriteLine(0.25F);//float
            Console.WriteLine(2.625);///double
            Console.WriteLine(true);
            Console.WriteLine(false);
            var message = "Hello world!";//var keyword tells the C# compiler that the data type is implied by the assigned value
            Console.WriteLine(message);
            var name = "Bob";
            var num = "3";
            var temp = "34.4";
            Console.WriteLine(34.40M);

            Console.WriteLine("Hello, " + name + "! You have " + num +
            " message in your inbox. The temperature is " + temp + "celsius.");
            suffix = "III";

            Console.WriteLine("Name: " + fname + " " + mname + " / " + mnamesingle + " " + lnmae + " " + suffix);

            string str;
            Console.Write("Write any: ");
            str = Console.ReadLine();
            Console.WriteLine("You write: " + str);

            char ptr;
            Console.Write("Enter 1  Letter: ");
            ptr = (char)Console.Read();
            Console.WriteLine("The Letter is " + ptr);

            char vty;
            Console.WriteLine("ENTER a Letter/Num");
            vty = Console.ReadKey().KeyChar;
            Console.WriteLine("\nlets delay");
            Console.ReadKey();
            Console.WriteLine("Its delayed");
            // data convertion
            //char->int->long->float->double (small to big)
            //asciicode a letter has a value
            //can directly convert char to double
            char chrn = 'b';
            int rndnum = chrn;
            long lng = rndnum;
            float fltnum = lng;
            double dblnum = fltnum;
            Console.WriteLine("Character: " + chrn +
                "\nInteger of the char: " + rndnum +
                "\nlong: " + lng +
                "\nfloat: " + fltnum +
                "\ndouble: " + dblnum);

            //double->float->long->int->char (big to small)
            //can directly convert double to char

            double db = 67.99999999911111;
            float fl = (float)db;
            long lo = (long)db;
            int ins = (int)db;
            char ch = (char)ins;
            Console.ReadKey();
            Console.WriteLine("\n\ndouble: " + db +
                   "\nfloat: " + fl +
                   "\nlong: " + lo +
                   "\nInteger of the char: " + ins +
                   "\nCharacter: " + ch);
            //arithmetic
            int num1 = 10, num2 = 10;
            Console.Write("Adittion: ");
            Console.WriteLine(num1 + num2);
            Console.WriteLine("Division: " + num1 / num2);
            Console.Write("Subtraction: ");
            Console.WriteLine(num1 - num2);
            Console.WriteLine("Multiplication: " + num1 * num2);
            Console.ReadKey();

            //might be useful somewhere
            string nasd = Console.ReadLine();
            string nssd = Console.ReadLine();

            Console.WriteLine(nasd + nssd);
            //end here

        }
    }





}
