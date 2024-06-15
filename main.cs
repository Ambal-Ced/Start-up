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
            Console.WriteLine("You write: "+str);

            char ptr;
            Console.Write("Enter 1  Letter: ");
            ptr = (char) Console.Read();
            Console.WriteLine("The Letter is "+ptr);

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
            Console.WriteLine("Character: "+chrn +
                "\nInteger of the char: " + rndnum +
                "\nlong: " + lng +
                "\nfloat: " +  fltnum +
                "\ndouble: "+ dblnum);

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
            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            decimal decimalQuotient = 7.0m / 5;
            Console.WriteLine($"Decimal quotient: {decimalQuotient}");

            //best way to do arithmetic is to add or use a decimal on the num
            int first = 7;
            int second = 19273;
            decimal quotientt = (decimal)first / (decimal)second;
            Console.WriteLine(quotient);

            decimal tr = 9m;
            decimal sse = 1.8m;
            decimal quo = (decimal)tr / (decimal)sse;
            Console.WriteLine(quotient);

            decimal a1 = 2m, a2 = 3.5m;

            Console.WriteLine($"Modulus of 7 & 5 : {7 % 5}");
            Console.WriteLine($"Multiplication of 7 & 5 : {7 * 5}");
            Console.WriteLine($"Division of 7 & 5 : {7 / 5}");
            Console.WriteLine($"Subtraction of 7 & 5 : {7 - 5}");
            Console.WriteLine($"(Negative)Subtraction of 5 & 7 : {5 - 7}");
            Console.WriteLine($"Addition of 7 & 5 : {7 + 5}");
            Console.WriteLine($"Addition of two decimal : {a1 + a2}");
            Console.WriteLine($"Addition of two decimal : {a1 - a2}");
            Console.WriteLine($"Addition of two decimal : {a1 / a2}");
            Console.WriteLine($"Addition of two decimal : {a1 * a2}");

            int value1 = 3 + 4 * 5;
            int value2 = (3 + 4) * 5;
            int value3 = 3 + (4 * 5);
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);

            int value = 0;     // value is now 0.
            Console.WriteLine(value);
            value = value + 5; // value is now 5.
            Console.WriteLine(value);
            value += 5;        // value is now 10.
            Console.WriteLine(value);

            value = 0;     // value is now 0.
            Console.WriteLine(value);
            value = value + 1; // value is now 1.
            Console.WriteLine(value);
            value++;           // value is now 2.
            Console.WriteLine(value);

            value = 5;
            Console.WriteLine(value);
            value++;
            Console.WriteLine(value);

            //+=, -=, *=, ++, and -- 
            value = 1;

            value = value + 1;
            Console.WriteLine("First increment: " + value);

            value += 1;
            Console.WriteLine("Second increment: " + value);

            value++;
            Console.WriteLine("Third increment: " + value);

            value = value - 1;
            Console.WriteLine("First decrement: " + value);

            value -= 1;
            Console.WriteLine("Second decrement: " + value);

            value--;
            Console.WriteLine("Third decrement: " + value);

            value = 1;
            value++;
            Console.WriteLine("First: " + value);
            Console.WriteLine($"Second: {value++}");
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));

            int fahrenheit = 94;

            decimal celcius = ((decimal)fahrenheit - 32) * 5 / 9;

            Console.WriteLine(celcius);


            //might be useful somewhere
            string nasd = Console.ReadLine();
            string nssd = Console.ReadLine();

            Console.WriteLine(nasd + nssd);
            //end here

            string nums1, nums2, eq = null;

            nums1 = Console.ReadLine();
            nums2 = Console.ReadLine();
            Console.WriteLine(nums1 + nums2);
            //Conver.ToInt32 = int, Convert.ToInt64 = long, Convert.ToSingle = float Convert.ToString = string
            string x = "15.234";
            string y = "2";
            string z = "1712736";
            int x2 = Convert.ToInt32 (y);
            long x3 = Convert.ToInt64 (z);
            float x4 = Convert.ToSingle (x);
            double x5 = Convert.ToDouble (x);

            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
            Console.WriteLine(x5);

            string i = "10";
            string b = "10";

            int n = Convert.ToInt32(i);
            int m = Convert.ToInt32(b);

            int j = n + m;

            Console.WriteLine(j);
            Console.WriteLine("hello\tworlds???");
            Console.WriteLine("hello\nbro");
            Console.WriteLine(@"meta       bored     hehe");
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            Console.WriteLine("\u0048\u0045\u004C\u004C\u004F \u0057\u004F\u0052\u004C\u0044");
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber);
            Console.WriteLine(7 + secondNumber);
            Console.WriteLine("??" + 7 + secondNumber);
            Console.WriteLine("??" + (7 + secondNumber));
        }
    }
}
