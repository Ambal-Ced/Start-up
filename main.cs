using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start__up
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Start up c#");
            // int age = 20;
            // long long_int = 203203827;
            // double decimal_15 = 20.112356734521111;
            // float avenum = 6.7f;
            // string fname = "First",
            //     mname = "Middle",
            //     lnmae = "last",
            //     suffix;
            // char mnamesingle = 'M';
            // bool ismale = true;

            // suffix = "jr";

            // Console.WriteLine("Name: " + fname + " " + mname + " / " + mnamesingle + " " + lnmae + " " + suffix);
            // Console.WriteLine("Is Male: " + ismale);
            // Console.WriteLine("Ave num chosen: " + avenum);
            // Console.WriteLine("double: " + decimal_15);
            // Console.WriteLine("long int: " + long_int);
            // Console.WriteLine("Age: " + age);
            // Console.WriteLine(123);//int
            // Console.WriteLine(0.25F);//float
            // Console.WriteLine(2.625);///double
            // Console.WriteLine(true);
            // Console.WriteLine(false);
            // var message = "Hello world!";//var keyword tells the C# compiler that the data type is implied by the assigned value
            // Console.WriteLine(message);
            // var name = "Bob";
            // var num = "3";
            // var temp = "34.4";
            // Console.WriteLine(34.40M);

            // Console.WriteLine("Hello, " + name + "! You have " + num +
            // " message in your inbox. The temperature is " + temp + "celsius.");
            // suffix = "III";

            // Console.WriteLine("Name: " + fname + " " + mname + " / " + mnamesingle + " " + lnmae + " " + suffix);

            // string str;
            // Console.Write("Write any: ");
            // str = Console.ReadLine();
            // Console.WriteLine("You write: " + str);

            // char ptr;
            // Console.Write("Enter 1  Letter: ");
            // ptr = (char)Console.Read();
            // Console.WriteLine("The Letter is " + ptr);

            // char vty;
            // Console.WriteLine("ENTER a Letter/Num");
            // vty = Console.ReadKey().KeyChar;
            // Console.WriteLine("\nlets delay");
            // Console.ReadKey();
            // Console.WriteLine("Its delayed");
            // // data convertion
            // //char->int->long->float->double (small to big)
            // //asciicode a letter has a value
            // //can directly convert char to double
            // char chrn = 'b';
            // int rndnum = chrn;
            // long lng = rndnum;
            // float fltnum = lng;
            // double dblnum = fltnum;
            // Console.WriteLine("Character: " + chrn +
            //     "\nInteger of the char: " + rndnum +
            //     "\nlong: " + lng +
            //     "\nfloat: " + fltnum +
            //     "\ndouble: " + dblnum);

            // //double->float->long->int->char (big to small)
            // //can directly convert double to char

            // double db = 67.99999999911111;
            // float fl = (float)db;
            // long lo = (long)db;
            // int ins = (int)db;
            // char ch = (char)ins;
            // Console.ReadKey();
            // Console.WriteLine("\n\ndouble: " + db +
            //        "\nfloat: " + fl +
            //        "\nlong: " + lo +
            //        "\nInteger of the char: " + ins +
            //        "\nCharacter: " + ch);
            // //arithmetic
            // int sum = 7 + 5;
            // int difference = 7 - 5;
            // int product = 7 * 5;
            // int quotient = 7 / 5;

            // Console.WriteLine("Sum: " + sum);
            // Console.WriteLine("Difference: " + difference);
            // Console.WriteLine("Product: " + product);
            // Console.WriteLine("Quotient: " + quotient);

            // decimal decimalQuotient = 7.0m / 5;
            // Console.WriteLine($"Decimal quotient: {decimalQuotient}");

            // //best way to do arithmetic is to add or use a decimal on the num
            // int first = 7;
            // int second = 19273;
            // decimal quotientt = (decimal)first / (decimal)second;
            // Console.WriteLine(quotient);

            // decimal tr = 9m;
            // decimal sse = 1.8m;
            // decimal quo = (decimal)tr / (decimal)sse;
            // Console.WriteLine(quotient);

            // decimal a1 = 2m, a2 = 3.5m;

            // Console.WriteLine($"Modulus of 7 & 5 : {7 % 5}");
            // Console.WriteLine($"Multiplication of 7 & 5 : {7 * 5}");
            // Console.WriteLine($"Division of 7 & 5 : {7 / 5}");
            // Console.WriteLine($"Subtraction of 7 & 5 : {7 - 5}");
            // Console.WriteLine($"(Negative)Subtraction of 5 & 7 : {5 - 7}");
            // Console.WriteLine($"Addition of 7 & 5 : {7 + 5}");
            // Console.WriteLine($"Addition of two decimal : {a1 + a2}");
            // Console.WriteLine($"Addition of two decimal : {a1 - a2}");
            // Console.WriteLine($"Addition of two decimal : {a1 / a2}");
            // Console.WriteLine($"Addition of two decimal : {a1 * a2}");

            // int value1 = 3 + 4 * 5;
            // int value2 = (3 + 4) * 5;
            // int value3 = 3 + (4 * 5);
            // Console.WriteLine(value1);
            // Console.WriteLine(value2);
            // Console.WriteLine(value3);

            // int value = 0;     // value is now 0.
            // Console.WriteLine(value);
            // value = value + 5; // value is now 5.
            // Console.WriteLine(value);
            // value += 5;        // value is now 10.
            // Console.WriteLine(value);

            // value = 0;     // value is now 0.
            // Console.WriteLine(value);
            // value = value + 1; // value is now 1.
            // Console.WriteLine(value);
            // value++;           // value is now 2.
            // Console.WriteLine(value);

            // value = 5;
            // Console.WriteLine(value);
            // value++;
            // Console.WriteLine(value);

            // //+=, -=, *=, ++, and -- 
            // value = 1;

            // value = value + 1;
            // Console.WriteLine("First increment: " + value);

            // value += 1;
            // Console.WriteLine("Second increment: " + value);

            // value++;
            // Console.WriteLine("Third increment: " + value);

            // value = value - 1;
            // Console.WriteLine("First decrement: " + value);

            // value -= 1;
            // Console.WriteLine("Second decrement: " + value);

            // value--;
            // Console.WriteLine("Third decrement: " + value);

            // value = 1;
            // value++;
            // Console.WriteLine("First: " + value);
            // Console.WriteLine($"Second: {value++}");
            // Console.WriteLine("Third: " + value);
            // Console.WriteLine("Fourth: " + (++value));

            // int fahrenheit = 94;

            // decimal celcius = ((decimal)fahrenheit - 32) * 5 / 9;

            // Console.WriteLine(celcius);


            // //might be useful somewhere
            // string nasd = Console.ReadLine();
            // string nssd = Console.ReadLine();

            // Console.WriteLine(nasd + nssd);
            // //end here

            // string nums1, nums2, eq = null;

            // nums1 = Console.ReadLine();
            // nums2 = Console.ReadLine();
            // Console.WriteLine(nums1 + nums2);
            // //Conver.ToInt32 = int, Convert.ToInt64 = long, Convert.ToSingle = float Convert.ToString = string
            // string x = "15.234";
            // string y = "2";
            // string z = "1712736";
            // int x2 = Convert.ToInt32(y);
            // long x3 = Convert.ToInt64(z);
            // float x4 = Convert.ToSingle(x);
            // double x5 = Convert.ToDouble(x);

            // Console.WriteLine(x2);
            // Console.WriteLine(x3);
            // Console.WriteLine(x4);
            // Console.WriteLine(x5);

            // string i = "10";
            // string b = "10";

            // int n = Convert.ToInt32(i);
            // int m = Convert.ToInt32(b);

            // int j = n + m;

            // Console.WriteLine(j);
            // Console.WriteLine("hello\tworlds???");
            // Console.WriteLine("hello\nbro");
            // Console.WriteLine(@"meta       bored     hehe");
            // Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            // Console.WriteLine("\u0048\u0045\u004C\u004C\u004F \u0057\u004F\u0052\u004C\u0044");
            // Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // int firstNumber = 12;
            // int secondNumber = 7;
            // Console.WriteLine(firstNumber + secondNumber);
            // Console.WriteLine(7 + secondNumber);
            // Console.WriteLine("??" + 7 + secondNumber);
            // Console.WriteLine("??" + (7 + secondNumber));
            // Console.WriteLine("\n\n");

            // // initialize variables - graded assignments 
            // int currentAssignments = 5;

            // int sophia1 = 93;
            // int sophia2 = 87;
            // int sophia3 = 98;
            // int sophia4 = 95;
            // int sophia5 = 100;

            // int nicolas1 = 80;
            // int nicolas2 = 83;
            // int nicolas3 = 82;
            // int nicolas4 = 88;
            // int nicolas5 = 85;

            // int zahirah1 = 84;
            // int zahirah2 = 96;
            // int zahirah3 = 73;
            // int zahirah4 = 85;
            // int zahirah5 = 79;

            // int jeong1 = 90;
            // int jeong2 = 92;
            // int jeong3 = 98;
            // int jeong4 = 100;
            // int jeong5 = 97;

            // decimal sophiagrade = ((decimal)sophia1 + (decimal)sophia2 + (decimal)sophia3 + (decimal)sophia4 + (decimal)sophia5) / 5;
            // decimal nicolasgrade = ((decimal)nicolas1 + (decimal)nicolas2 + (decimal)nicolas3 + (decimal)nicolas4 + (decimal)nicolas5) / 5;
            // decimal zahiragrade = ((decimal)zahirah1 + (decimal)zahirah2 + (decimal)zahirah3 + (decimal)zahirah4 + (decimal)zahirah5) / 5;
            // decimal jeonggrade = ((decimal)jeong1 + (decimal)jeong2 + (decimal)jeong3 + (decimal)jeong4 + (decimal)jeong5) / 5;

            // Console.WriteLine("Student\t\tGrade");
            // Console.WriteLine("Sophia\t\t" + sophiagrade + "\tA");
            // Console.WriteLine("Nicolas\t\t" + nicolasgrade + "\tB");
            // Console.WriteLine("Zahirah\t\t" + zahiragrade + "\tB");
            // Console.WriteLine("Jeong\t\t" + jeonggrade + "\tA");

            // //getting the digit
            // string studentName = "Sophia Johnson";
            // string course1Name = "English 101";
            // string course2Name = "Algebra 101";
            // string course3Name = "Biology 101";
            // string course4Name = "Computer Science I";
            // string course5Name = "Psychology 101";

            // int course1Credit = 3;
            // int course2Credit = 3;
            // int course3Credit = 4;
            // int course4Credit = 4;
            // int course5Credit = 3;

            // int gradeA = 4;
            // int gradeB = 3;

            // int course1Grade = gradeA;
            // int course2Grade = gradeB;
            // int course3Grade = gradeB;
            // int course4Grade = gradeB;
            // int course5Grade = gradeA;

            // int totalCreditHours = 0;
            // totalCreditHours += course1Credit;
            // totalCreditHours += course2Credit;
            // totalCreditHours += course3Credit;
            // totalCreditHours += course4Credit;
            // totalCreditHours += course5Credit;

            // int totalGradePoints = 0;
            // totalGradePoints += course1Credit * course1Grade;
            // totalGradePoints += course2Credit * course2Grade;
            // totalGradePoints += course3Credit * course3Grade;
            // totalGradePoints += course4Credit * course4Grade;
            // totalGradePoints += course5Credit * course5Grade;

            // decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

            // int leadingDigit = (int)gradePointAverage;
            // int firstDigit = (int)(gradePointAverage * 10) % 10;//to get the first decimal number use x 10 %10 
            // int secondDigit = (int)(gradePointAverage * 100) % 10;// to get second decimal digit use x100

            // Console.WriteLine($"Student: {studentName}\n");
            // Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
            // Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
            // Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
            // Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
            // Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
            // Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");
            // Console.WriteLine($"Final GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");
            // Console.WriteLine($"Final GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");

            // Random dice = new Random();
            // Random juice = new Random();
            // int serve = juice.Next(1,4);
            // int roll = dice.Next(1, 7);
            // Console.WriteLine("Serving Table "+roll);

            // if(serve == 1){
            //     Console.WriteLine("Orange ");
            // }else if(serve == 2){
            //     Console.WriteLine("Grapes");
            // }else if(serve == 3){
            //     Console.WriteLine("Pineapple");
            // }else{
            //     Console.WriteLine("Apple");
            // }

            // Random dice = new Random();
            // int roll1 = dice.Next();
            // int roll2 = dice.Next(101);
            // int roll3 = dice.Next(50, 101);

            // Console.WriteLine($"First roll: {roll1}");
            // Console.WriteLine($"Second roll: {roll2}");
            // Console.WriteLine($"Third roll: {roll3}");
            //  int firstValue = 500;
            //  int secondValue = 600;
            //  int largerValue;
            //  largerValue = Math.Max(firstValue, secondValue);
            //  Console.WriteLine(largerValue);
            //  Console.ReadKey();
            //  if (firstValue < secondValue) {
            //     largerValue = secondValue;
            //  }
            //  else {
            //     largerValue = firstValue;
            //  }

            // Random dice = new Random();
            // Random juice = new Random();
            // int serve = juice.Next(1,4);
            // int roll = dice.Next(1, 7);
            // Console.WriteLine("Serving Table "+roll);

            // if(serve == 1){
            //     Console.WriteLine("Orange ");
            // }else if(serve == 2){
            //     Console.WriteLine("Grapes");
            // }else if(serve == 3){
            //     Console.WriteLine("Pineapple");
            // }else{
            //     Console.WriteLine("Apple");
            // }

            // Random dice = new Random();
            // int roll1 = dice.Next();
            // int roll2 = dice.Next(101);
            // int roll3 = dice.Next(50, 101);

            // Console.WriteLine($"First roll: {roll1}");
            // Console.WriteLine($"Second roll: {roll2}");
            // Console.WriteLine($"Third roll: {roll3}");

            //  int firstValue = 500;
            //  int secondValue = 600;
            //  int largerValue;
            //  largerValue = Math.Max(firstValue, secondValue);
            //  Console.WriteLine(largerValue);
            //  if (firstValue < secondValue) {
            //     largerValue = secondValue;
            //  }
            //  else {
            //     largerValue = firstValue;
            //  }
            // Random dice = new Random();

            // int roll1 = dice.Next(1, 7);
            // int roll2 = dice.Next(1, 7);
            // int roll3 = dice.Next(1, 7);

            // int total = roll1 + roll2 + roll3;

            // Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            // if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            // {
            //     if ((roll1 == roll2) && (roll2 == roll3))
            //     {
            //         Console.WriteLine("You rolled triples!  +6 bonus to total!");
            //         total += 6;
            //     }
            //     else
            //     {
            //         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
            //         total += 2;
            //     }
            // }

            // if (total >= 15)
            // {
            //     Console.WriteLine("You win!");
            // }
            // else 
            // {
            //     Console.WriteLine("Sorry, you lose.");
            // }
            // string message = "The quick brown fox jumps over the lazy dog.";
            // bool result = message.Contains("dog");
            // Console.WriteLine(result);

            // if (message.Contains("dog"))
            // {
            //     Console.WriteLine("What does the fox say?\n");
            // }

            // Random random = new Random();
            // int daysUntilExpiration = random.Next(12);
            // int discountPercentage = 0;

            // if (daysUntilExpiration == 0)
            // {
            //     Console.WriteLine("Your subscription has expired.");
            // }
            // else if (daysUntilExpiration == 1)
            // {
            //     Console.WriteLine("Your subscription expires within a day!");
            //     discountPercentage = 20;
            // }
            // else if (daysUntilExpiration <= 5)
            // {
            //     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            //     discountPercentage = 10;
            // }
            // else if (daysUntilExpiration <= 10)
            // {
            //     Console.WriteLine("Your subscription will expire soon. Renew now!");
            // }

            // if (discountPercentage > 0)
            // {
            //     Console.WriteLine($"Renew now and save {discountPercentage}%.");
            // }

            // string[] fraudulentOrderIDs = new string[3];
            // fraudulentOrderIDs[0] = "A123";
            // fraudulentOrderIDs[1] = "B456";
            // fraudulentOrderIDs[2] = "C789";

            // Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            // Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            // Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            // fraudulentOrderIDs[0] = "F000";

            // Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            // string[] fraudulentOrderIDss = { "A123", "B456", "C789" };

            // Console.WriteLine($"First: {fraudulentOrderIDss[0]}");
            // Console.WriteLine($"Second: {fraudulentOrderIDss[1]}");
            // Console.WriteLine($"Third: {fraudulentOrderIDss[2]}");

            // fraudulentOrderIDss[0] = "F000";

            // Console.WriteLine($"Reassign First: {fraudulentOrderIDss[0]}");

            // Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
            // string[] names = { "Rowena", "Robin", "Bao" };
            // foreach (string name in names)
            // {
            //     Console.WriteLine(name);
            // }
            // int[] inventory = { 200, 450, 700, 175, 250 };
            // int sum = 0;
            // int bin = 0;
            // foreach (int items in inventory)
            // {
            //     sum += items;
            //     bin++;
            //     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            // }
            // Console.WriteLine($"We have {sum} items in inventory.");

            // string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            // foreach (string orderID in orderIDs)
            // {
            //     if (orderID.StartsWith("C"))
            //     {
            //         Console.WriteLine(orderID);
            //     }
            // }

            // string originalMessage = "The quick brown fox jumps over the lazy dog.";

            // char[] message = originalMessage.ToCharArray();
            // Array.Reverse(message);

            // int letterCount = 0;

            // foreach (char letter in message)
            // {
            //     if (letter == 0)
            //     {
            //         letterCount++;
            //     }
            // }

            // string newMessage = new String(message);

            // Console.WriteLine(newMessage);
            // Console.WriteLine($"'o' appears {letterCount} times.");


            // Random random = new Random();
            // int daysUntilExpiration = random.Next(12);
            // int discountPercentage = 0;

            // if (daysUntilExpiration == 0)
            // {
            //     Console.WriteLine("Your subscription has expired.");
            // }
            // else if (daysUntilExpiration == 1)
            // {
            //     Console.WriteLine("Your subscription expires within a day!");
            //     discountPercentage = 20;
            // }
            // else if (daysUntilExpiration <= 5)
            // {
            //     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            //     discountPercentage = 10;
            // }
            // else if (daysUntilExpiration <= 10)
            // {
            //     Console.WriteLine("Your subscription will expire soon. Renew now!");
            // }

            // if (discountPercentage > 0)
            // {
            //     Console.WriteLine($"Renew now and save {discountPercentage}%.");
            // }

            // string[] fraudulentOrderIDs = new string[3];
            // fraudulentOrderIDs[0] = "A123";
            // fraudulentOrderIDs[1] = "B456";
            // fraudulentOrderIDs[2] = "C789";

            // Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            // Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            // Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            // fraudulentOrderIDs[0] = "F000";

            // Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            // string[] fraudulentOrderIDss = { "A123", "B456", "C789" };

            // Console.WriteLine($"First: {fraudulentOrderIDss[0]}");
            // Console.WriteLine($"Second: {fraudulentOrderIDss[1]}");
            // Console.WriteLine($"Third: {fraudulentOrderIDss[2]}");

            // fraudulentOrderIDss[0] = "F000";

            // Console.WriteLine($"Reassign First: {fraudulentOrderIDss[0]}");

            // Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
            // string[] names = { "Rowena", "Robin", "Bao" };
            // foreach (string name in names)
            // {
            //     Console.WriteLine(name);
            // }
            // int[] inventory = { 200, 450, 700, 175, 250 };
            // int sum = 0;
            // int bin = 0;
            // foreach (int items in inventory)
            // {
            //     sum += items;
            //     bin++;
            //     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            // }
            // Console.WriteLine($"We have {sum} items in inventory.");

            // string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            // foreach (string orderID in orderIDs)
            // {
            //     if (orderID.StartsWith("C"))
            //     {
            //         Console.WriteLine(orderID);
            //     }
            // }
            /*
               This code reverses a message, counts the number of times 
               a particular character appears, then prints the results
               to the console window.
             */

            // string originalMessage = "The quick brown fox jumps over the lazy dog.";

            // char[] message = originalMessage.ToCharArray();
            // Array.Reverse(message);

            // int letterCount = 0;

            // foreach (char letter in message)
            // {
            //     if (letter == 0)
            //     {
            //         letterCount++;
            //     }
            // }

            // string newMessage = new String(message);

            // Console.WriteLine(newMessage);
            // Console.WriteLine($"'o' appears {letterCount} times.");

            // initialize variables - graded assignments 
            // int currentAssignments = 5;

            // int sophia1 = 90;
            // int sophia2 = 86;
            // int sophia3 = 87;
            // int sophia4 = 98;
            // int sophia5 = 100;

            // int andrew1 = 92;
            // int andrew2 = 89;
            // int andrew3 = 81;
            // int andrew4 = 96;
            // int andrew5 = 90;

            // int emma1 = 90;
            // int emma2 = 85;
            // int emma3 = 87;
            // int emma4 = 98;
            // int emma5 = 68;

            // int logan1 = 90;
            // int logan2 = 95;
            // int logan3 = 87;
            // int logan4 = 88;
            // int logan5 = 96;

            // int sophiaSum = 0;
            // int andrewSum = 0;
            // int emmaSum = 0;
            // int loganSum = 0;

            // decimal sophiaScore;
            // decimal andrewScore;
            // decimal emmaScore;
            // decimal loganScore;

            // sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            // andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
            // emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
            // loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

            // sophiaScore = (decimal)sophiaSum / currentAssignments;
            // andrewScore = (decimal)andrewSum / currentAssignments;
            // emmaScore = (decimal)emmaSum / currentAssignments;
            // loganScore = (decimal)loganSum / currentAssignments;

            // Console.WriteLine("Student\t\tGrade\n");
            // Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
            // Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
            // Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
            // Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

            // Console.WriteLine("Press the Enter key to continue");
            // Console.Read();

            //int[] sophiaScores = new int[5]; determines that it holds 5 arrays if the [] is empty then its not limited


            // initialize variables - graded assignments 
            // initialize variables - graded assignments 
            // int currentAssignments = 5;

            // int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            // int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            // int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            // int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

            // int sophiaSum = 0;

            // decimal sophiaScore;

            // foreach (int score in sophiaScores)
            // {
            //     // add the exam score to the sum
            //     sophiaSum += score;
            // }
            // // Student names
            // string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
            // foreach (string name in studentNames)
            // {
            //     Console.WriteLine($"{name}");

            // }
            // Console.ReadLine();
            // sophiaScore = (decimal)sophiaSum / currentAssignments;

            // Console.WriteLine("Student\t\tGrade\n");
            // Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

            // Console.WriteLine("Press the Enter key to continue");
            // Console.ReadLine();

            // initialize variables - graded assignments 
            // int currentAssignments = 5;

            // int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            // int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            // int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            // int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
            // int[] leoScores = new int[] {90, 90, 90, 90, 90};

            // // Student names
            // string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Leo" };

            // int[] studentScores = new int[10];

            // // Write the Report Header to the console
            // Console.WriteLine("Student\t\tGrade\n");

            // foreach (string name in studentNames)
            // {
            //     string currentStudent = name;

            //     if (currentStudent == "Sophia")
            //         {studentScores = sophiaScores;}

            //     else if (currentStudent == "Andrew")
            //         {studentScores = andrewScores;}

            //     else if (currentStudent == "Emma")
            //         {studentScores = emmaScores;}

            //     else if (currentStudent == "Logan")
            //         {studentScores = loganScores;}
            //     else if (currentStudent == "Leo")
            //         {studentScores = leoScores;}
            //     // initialize/reset the sum of scored assignments
            //     int sumAssignmentScores = 0;

            //     // initialize/reset the calculated average of exam + extra credit scores
            //     decimal currentStudentGrade = 0;

            //     foreach (int score in studentScores)
            //     {
            //         // add the exam score to the sum
            //         sumAssignmentScores += score;
            //     }



            //   Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}");
            // }
            // Console.Read();

            // initialize variables - graded assignments
            // int currentAssignments = 5;

            // int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            // int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            // int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            // int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

            // // Student names
            // string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            // int[] studentScores = new int[10];

            // string currentStudentLetterGrade = "";

            // // Display the Report Header
            // Console.WriteLine("Student\t\tGrade\n");

            // foreach (string name in studentNames)
            // {
            //     string currentStudent = name;

            //     if (currentStudent == "Sophia")
            //         // assign Sophia's scores to the studentScores array 
            //         studentScores = sophiaScores;

            //     else if (currentStudent == "Andrew")
            //         // assign Andrew's scores to the studentScores array 
            //         studentScores = andrewScores;

            //     else if (currentStudent == "Emma")
            //         // assign Emma's scores to the studentScores array 
            //         studentScores = emmaScores;

            //     else if (currentStudent == "Logan")
            //         // assign Logan's scores to the studentScores array 
            //         studentScores = loganScores;

            //     // initialize/reset the sum of scored assignments
            //     int sumAssignmentScores = 0;

            //     // initialize/reset the calculated average of exam + extra credit scores
            //     decimal currentStudentGrade = 0;

            //     foreach (int score in studentScores)
            //     {
            //         // add the exam score to the sum
            //         sumAssignmentScores += score;
            //     }

            //     currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

            //     if (currentStudentGrade >= 97)
            //         currentStudentLetterGrade = "A+";

            //     else if (currentStudentGrade >= 93)
            //         currentStudentLetterGrade = "A";

            //     else if (currentStudentGrade >= 90)
            //         currentStudentLetterGrade = "A-";

            //     else if (currentStudentGrade >= 87)
            //         currentStudentLetterGrade = "B+";

            //     else if (currentStudentGrade >= 83)
            //         currentStudentLetterGrade = "B";

            //     else if (currentStudentGrade >= 80)
            //         currentStudentLetterGrade = "B-";

            //     else if (currentStudentGrade >= 77)
            //         currentStudentLetterGrade = "C+";

            //     else if (currentStudentGrade >= 73)
            //         currentStudentLetterGrade = "C";

            //     else if (currentStudentGrade >= 70)
            //         currentStudentLetterGrade = "C-";

            //     else if (currentStudentGrade >= 67)
            //         currentStudentLetterGrade = "D+";

            //     else if (currentStudentGrade >= 63)
            //         currentStudentLetterGrade = "D";

            //     else if (currentStudentGrade >= 60)
            //         currentStudentLetterGrade = "D-";

            //     else
            //         currentStudentLetterGrade = "F";

            //     Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
            // }

            // Console.WriteLine("Press the Enter key to continue");
            // Console.ReadLine();




            // initialize variables - graded assignments 
            // int currentAssignments = 5;

            // int sophia1 = 90;
            // int sophia2 = 86;
            // int sophia3 = 87;
            // int sophia4 = 98;
            // int sophia5 = 100;

            // int andrew1 = 92;
            // int andrew2 = 89;
            // int andrew3 = 81;
            // int andrew4 = 96;
            // int andrew5 = 90;

            // int emma1 = 90;
            // int emma2 = 85;
            // int emma3 = 87;
            // int emma4 = 98;
            // int emma5 = 68;

            // int logan1 = 90;
            // int logan2 = 95;
            // int logan3 = 87;
            // int logan4 = 88;
            // int logan5 = 96;

            // int sophiaSum = 0;
            // int andrewSum = 0;
            // int emmaSum = 0;
            // int loganSum = 0;

            // decimal sophiaScore;
            // decimal andrewScore;
            // decimal emmaScore;
            // decimal loganScore;

            // sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            // andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
            // emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
            // loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

            // sophiaScore = (decimal)sophiaSum / currentAssignments;
            // andrewScore = (decimal)andrewSum / currentAssignments;
            // emmaScore = (decimal)emmaSum / currentAssignments;
            // loganScore = (decimal)loganSum / currentAssignments;

            // Console.WriteLine("Student\t\tGrade\n");
            // Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
            // Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
            // Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
            // Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

            // Console.WriteLine("Press the Enter key to continue");
            // Console.Read();

            //int[] sophiaScores = new int[5]; determines that it holds 5 arrays if the [] is empty then its not limited


            // initialize variables - graded assignments 
            // initialize variables - graded assignments 
            // int currentAssignments = 5;

            // int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            // int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            // int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            // int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

            // int sophiaSum = 0;

            // decimal sophiaScore;

            // foreach (int score in sophiaScores)
            // {
            //     // add the exam score to the sum
            //     sophiaSum += score;
            // }
            // // Student names
            // string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
            // foreach (string name in studentNames)
            // {
            //     Console.WriteLine($"{name}");

            // }
            // Console.ReadLine();
            // sophiaScore = (decimal)sophiaSum / currentAssignments;

            // Console.WriteLine("Student\t\tGrade\n");
            // Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

            // Console.WriteLine("Press the Enter key to continue");
            // Console.ReadLine();

            // initialize variables - graded assignments 
            // int currentAssignments = 5;

            // int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            // int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            // int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            // int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
            // int[] leoScores = new int[] {90, 90, 90, 90, 90};

            // // Student names
            // string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Leo" };

            // int[] studentScores = new int[10];

            // // Write the Report Header to the console
            // Console.WriteLine("Student\t\tGrade\n");

            // foreach (string name in studentNames)
            // {
            //     string currentStudent = name;

            //     if (currentStudent == "Sophia")
            //         {studentScores = sophiaScores;}

            //     else if (currentStudent == "Andrew")
            //         {studentScores = andrewScores;}

            //     else if (currentStudent == "Emma")
            //         {studentScores = emmaScores;}

            //     else if (currentStudent == "Logan")
            //         {studentScores = loganScores;}
            //     else if (currentStudent == "Leo")
            //         {studentScores = leoScores;}
            //     // initialize/reset the sum of scored assignments
            //     int sumAssignmentScores = 0;

            //     // initialize/reset the calculated average of exam + extra credit scores
            //     decimal currentStudentGrade = 0;

            //     foreach (int score in studentScores)
            //     {
            //         // add the exam score to the sum
            //         sumAssignmentScores += score;
            //     }



            //   Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}");
            // }
            // Console.Read();

            // initialize variables - graded assignments
            // int currentAssignments = 5;

            // int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            // int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            // int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            // int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

            // // Student names
            // string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            // int[] studentScores = new int[10];

            // string currentStudentLetterGrade = "";

            // // Display the Report Header
            // Console.WriteLine("Student\t\tGrade\n");

            // foreach (string name in studentNames)
            // {
            //     string currentStudent = name;

            //     if (currentStudent == "Sophia")
            //         // assign Sophia's scores to the studentScores array 
            //         studentScores = sophiaScores;

            //     else if (currentStudent == "Andrew")
            //         // assign Andrew's scores to the studentScores array 
            //         studentScores = andrewScores;

            //     else if (currentStudent == "Emma")
            //         // assign Emma's scores to the studentScores array 
            //         studentScores = emmaScores;

            //     else if (currentStudent == "Logan")
            //         // assign Logan's scores to the studentScores array 
            //         studentScores = loganScores;

            //     // initialize/reset the sum of scored assignments
            //     int sumAssignmentScores = 0;

            //     // initialize/reset the calculated average of exam + extra credit scores
            //     decimal currentStudentGrade = 0;

            //     foreach (int score in studentScores)
            //     {
            //         // add the exam score to the sum
            //         sumAssignmentScores += score;
            //     }

            //     currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

            //     if (currentStudentGrade >= 97)
            //         currentStudentLetterGrade = "A+";

            //     else if (currentStudentGrade >= 93)
            //         currentStudentLetterGrade = "A";

            //     else if (currentStudentGrade >= 90)
            //         currentStudentLetterGrade = "A-";

            //     else if (currentStudentGrade >= 87)
            //         currentStudentLetterGrade = "B+";

            //     else if (currentStudentGrade >= 83)
            //         currentStudentLetterGrade = "B";

            //     else if (currentStudentGrade >= 80)
            //         currentStudentLetterGrade = "B-";

            //     else if (currentStudentGrade >= 77)
            //         currentStudentLetterGrade = "C+";

            //     else if (currentStudentGrade >= 73)
            //         currentStudentLetterGrade = "C";

            //     else if (currentStudentGrade >= 70)
            //         currentStudentLetterGrade = "C-";

            //     else if (currentStudentGrade >= 67)
            //         currentStudentLetterGrade = "D+";

            //     else if (currentStudentGrade >= 63)
            //         currentStudentLetterGrade = "D";

            //     else if (currentStudentGrade >= 60)
            //         currentStudentLetterGrade = "D-";

            //     else
            //         currentStudentLetterGrade = "F";

            //     Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
            // }

            // Console.WriteLine("Press the Enter key to continue");
            // Console.ReadLine();
            // Console.WriteLine("a" == "a");
            // // Console.WriteLine("a" == "A");
            // // Console.WriteLine(1 == 2);

            // // string myValue = "a";
            // // Console.WriteLine(myValue == "a");

            // // Console.WriteLine(1 > 2);
            // // Console.WriteLine(1 < 2);
            // // Console.WriteLine(1 >= 1);
            // // Console.WriteLine(1 <= 1);

            // // string pangram = "The quick brown fox jumps over the lazy dog.";
            // // Console.WriteLine(pangram.Contains("fox"));
            // // Console.WriteLine(pangram.Contains("cow"));

            // // // These two lines of code will create the same output

            // // Console.WriteLine(pangram.Contains("fox") == false);
            // // Console.WriteLine(!pangram.Contains("fox"));


            // // int a = 7;
            // // int b = 6;
            // // Console.WriteLine(a != b); // output: True
            // // string s1 = "Hello";
            // // string s2 = "Hello";
            // // Console.WriteLine(s1 != s2); // output: False

            // // int saleAmount = 1001;
            // // //<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
            // // int discount = saleAmount > 1000 ? 100 : 50;
            // // Console.WriteLine($"Discount: {discount}");

            // Random random = new Random();

            // int rndnum = random.Next(2);

            // Console.WriteLine(rndnum);

            // string resultnum = (rndnum == 0) ? "true" : "false";

            // Console.WriteLine(resultnum);

            // string permission = "Admin|Manager";
            // int level = 53;

            // if (permission.Contains("Admin"))
            // {
            //     if (level > 55)
            //     {
            //         Console.WriteLine("Welcome, Super Admin user.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Welcome, Admin user.");
            //     }
            // }
            // else if (permission.Contains("Manager"))
            // {
            //     if (level >= 20)
            //     {
            //         Console.WriteLine("Contact an Admin for access.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("You do not have sufficient privileges.");
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("You do not have sufficient privileges.");
            // }


            // bool flag = true;
            // int value;
            // if (flag)
            // {
            //     value = 20;
            //     Console.WriteLine($"Inside the code block: {value}");
            // }
            // value = 10;
            // Console.WriteLine($"Outside the code block: {value}");

            // string name = "steve";
            // if (name == "bob") Console.WriteLine("Found Bob");
            // else if (name == "steve") Console.WriteLine("Found Steve");
            // else Console.WriteLine("Found Chuck");

            // int[] numbers = { 4, 8, 15, 16, 23, 42 };
            // bool found = false;
            // int total = 0;
            // foreach (int number in numbers)
            // {

            //     total += number;

            //     if (number == 42)
            //     {
            //         found = true;

            //     }

            // }

            // if (found) 
            // {
            //     Console.WriteLine("Set contains 42");

            // }

            // Console.WriteLine($"Total: {total}");

            // int value = 1;
            // int var;
            // if (value > 0){
            //     var = 8;
            //     int sum = var + value;
            //     Console.WriteLine(sum);
            // }
            // int val = 5;
            // if (val > 0){ 
            //     int val2 = 6;
            //     int sum = val + val2;
            //     Console.WriteLine(sum);
            //     }

            // int employeeLevel = 205;
            // string employeeName = "John Smith";

            // string title = "";

            // switch (employeeLevel)
            // {
            //     case 100:
            //         title = "Junior Associate";
            //         break;
            //     case 200:
            //         title = "Senior Associate";
            //         break;
            //     case 300:
            //         title = "Manager";
            //         break;
            //     case 400:
            //         title = "Senior Manager";
            //         break;
            //     default:
            //         title = "Associate";
            //         break;
            // }

            // Console.WriteLine($"{employeeName}, {title}");

            // int employeeLevel = 100;
            // string employeeName = "John Smith";

            // string title = "";

            // switch (employeeLevel)
            // {
            //     case 100:
            //     case 200:
            //         title = "Senior Associate";
            //         break;
            //     case 300:
            //         title = "Manager";
            //         break;
            //     case 400:
            //         title = "Senior Manager";
            //         break;
            //     default:
            //         title = "Associate";
            //         break;
            // }

            // Console.WriteLine($"{employeeName}, {title}");

            // SKU = Stock Keeping Unit. 
            // SKU value format: <product #>-<2-letter color code>-<size code>
            // string sku = "01-MN-L";

            // string[] product = sku.Split('-');

            // string type = "";
            // string color = "";
            // string size = "";

            // if (product[0] == "01")
            // {
            //     type = "Sweat shirt";
            // } else if (product[0] == "02")
            // {
            //     type = "T-Shirt";
            // } else if (product[0] == "03")
            // {
            //     type = "Sweat pants";
            // }
            // else
            // {
            //     type = "Other";
            // }

            // if (product[1] == "BL")
            // {
            //     color = "Black";
            // } else if (product[1] == "MN")
            // {
            //     color = "Maroon";
            // } else
            // {
            //     color = "White";
            // }

            // if (product[2] == "S")
            // {
            //     size = "Small";
            // } else if (product[2] == "M")
            // {
            //     size = "Medium";
            // } else if (product[2] == "L")
            // {
            //     size = "Large";
            // } else
            // {
            //     size = "One Size Fits All";
            // }

            // Console.WriteLine($"Product: {size} {color} {type}");

            // switch (product[0])
            // {
            //     case "01":
            //         type = "Sweat shirt";
            //         break;
            //     case "02":
            //         type = "T-Shirt";
            //         break;
            //     case "03":
            //         type = "Sweat pants";
            //         break;
            //     default:
            //         type = "Other";
            //         break;
            // }

            // switch (product[1])
            // {
            //     case "BL":
            //         color = "Black";
            //         break;
            //     case "MN":
            //         color = "Maroon";
            //         break;
            //     default:
            //         color = "White";
            //         break;
            // }

            // switch (product[2])
            // {
            //     case "S":
            //         size = "Small";
            //         break;
            //     case "M":
            //         size = "Medium";
            //         break;
            //     case "L":
            //         size = "Large";
            //         break;
            //     default:
            //         size = "One Size Fits All";
            //         break;
            // }

            // Console.WriteLine($"Product: {size} {color} {type}");

            // Random random = new Random();
            // int current = 0;

            // do
            // {
            //     current = random.Next(1, 11);
            //     Console.WriteLine(current);
            // } while (current != 7);

            // Random random = new Random();
            // int current = random.Next(1,11);

            // while(current >= 3){
            //     Console.WriteLine(current);
            //     current = random.Next(1,11);
            // }
            // Console.WriteLine($"Last number: {current}");

            // Random random = new Random();
            // // int current = random.Next(1, 11);
            // int current = random.Next(0,10);

            // do
            // {
            //     current = random.Next(1, 11);

            //     if (current >= 8) continue;


            //     Console.WriteLine(current);
            // } while (current != 7);


            // int monsterHealth=10;
            // int heroHealth=10;


            // Random dice = new Random();

            // do
            // {
            //     int roll = dice.Next(1, 11);
            //     monsterHealth -= roll;
            //     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterHealth} health.");

            //     if (monsterHealth <= 0) continue;

            //     roll = dice.Next(1, 11);
            //     heroHealth -= roll;
            //     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {heroHealth} health.");

            // } while (heroHealth > 0 && monsterHealth > 0);

            // Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");

            // string? readResult;
            // bool validEntry = false;
            // Console.WriteLine("Enter a string containing at least three characters:");
            // do
            // {
            //     readResult = Console.ReadLine();
            //     if (readResult != null)
            //     {
            //         if (readResult.Length >= 3)
            //         {
            //             validEntry = true;
            //         }
            //         else
            //         {
            //             Console.WriteLine("Your input is invalid, please try again.");
            //         }
            //     }
            // } while (validEntry == false);

            // capture user input in a string variable named readResult

            // int numericValue = 0;
            // bool validNumber = false;

            // validNumber = int.TryParse(readResult, out numericValue);


            // string? readResult;
            // string valueEntered = "";
            // int numValue = 0;
            // bool validNumber = false;

            // Console.WriteLine("Enter an integer value between 5 and 10");

            // do
            // {
            //     readResult = Console.ReadLine();
            //     if (readResult != null) 
            //     {
            //         valueEntered = readResult;
            //     }

            //     validNumber = int.TryParse(valueEntered, out numValue);

            //     if (validNumber == true)
            //     {
            //         if (numValue <= 5 || numValue >= 10)
            //         {
            //             validNumber = false;
            //             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
            //         }
            //     }
            //     else 
            //     {
            //         Console.WriteLine("Sorry, you entered an invalid number, please try again");
            //     }
            // } while (validNumber == false);

            // Console.WriteLine($"Your input value ({numValue}) has been accepted.");

            // readResult = Console.ReadLine();


            // string? readResult;
            // string roleName = "";
            // bool validEntry = false;

            // do
            // {                
            //     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
            //     readResult = Console.ReadLine();
            //     if (readResult != null) 
            //     {
            //         roleName = readResult.Trim();
            //     }

            //     if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
            //     {
            //         validEntry = true;
            //     }
            //     else
            //     {
            //         Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
            //     }

            // } while (validEntry == false);

            // Console.WriteLine($"Your input value ({roleName}) has been accepted.");
            // readResult = Console.ReadLine();

            // string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            // int stringsCount = myStrings.Length;

            // string myString = "";
            // int periodLocation = 0;

            // for (int i = 0; i < stringsCount; i++)
            // {
            //     myString = myStrings[i];
            //     periodLocation = myString.IndexOf(".");

            //     string mySentence;

            //     // extract sentences from each string and display them one at a time
            //     while (periodLocation != -1)
            //     {

            //         // first sentence is the string value to the left of the period location
            //         mySentence = myString.Remove(periodLocation);

            //         // the remainder of myString is the string value to the right of the location
            //         myString = myString.Substring(periodLocation + 1);

            //         // remove any leading white-space from myString
            //         myString = myString.TrimStart();

            //         // update the comma location and increment the counter
            //         periodLocation = myString.IndexOf(".");

            //         Console.WriteLine(mySentence);
            //     }

            //     mySentence = myString.Trim();
            //     Console.WriteLine(mySentence);
            // }
            /////////
            //Activity that uses array, for loop, do-while, if and case switch
            //activity addded new function

            // string[] petID = {"1", "2", "3", "4", "5", "", "7", ""};
            // string[] petSpecies = {"Cat", "Dog", "Cat", "Cat", "Dog", "", "", ""};
            // string[] petAge = {"1", "1", "2", "2", "1", "", "", ""};
            // string[] petdescriptionCondition = {"One leg is broken", "Small Tail", "Tiny", "One eye blind", "Lost 2 teeths", "", "", ""};
            // string[] petPersonality ={"Playful", "Shy", "Afraid", "Playful", "Playful", "", "", ""};
            // string[] petNickname = {"chiz", "bell", "timmy", "lim","ban", "", "", ""};


            // string? choice = "";
            // int i = 0;
            // do{
            // Console.WriteLine("\nWelcome to the Contoso PetFriends app. Your main menu options are: \n1. List all of our current pet information \n2. Add a new animal friend to the ourAnimals array \n3. Ensure animal ages and physical descriptions are complete \n4. Ensure animal nicknames and personality descriptions are complete \n5. Edit an animal's age \n6. Edit an animal's personality description \n7. Display all cats with a specified characteristic \n8. Display all dogs with a specified characteristic \n\nEnter your selection number (or type Exit to exit the program)\n\n");
            // Console.Write(">>> ");
            // choice = Console.ReadLine();
            // int arrayNum = 0;
            //     switch(choice){
            //         case "1":
            //         for (i = 0; i < petID.Length; i ++){
            //             arrayNum = i;
            //             if (petID[i] != "" && petNickname[i] != "" && petSpecies[i] != "" && petAge[i] != "" && petPersonality[i] != "" && petSpecies[i] !=""){
            //         Console.WriteLine($"Pet Id is {petID[arrayNum]} name is {petNickname[arrayNum]} he/she is a {petAge[arrayNum]} years old {petSpecies[arrayNum]} with a condition of {petdescriptionCondition[arrayNum]} and have a {petPersonality[arrayNum]} personality");
            //             }
            //         }Console.ReadKey();
            //         break;

            //         case "2":
            //         int empty = 0;
            //         int newid = 0;
            //         for (i = 0;i <= petID.Length; i++){
            //             if(petID[i] == ""){
            //                 i++;
            //                 empty = i;
            //                 string data;

            //                 string newId = Convert.ToString(empty);
            //                 petID[empty] = newId;
            //                 Console.Write("Enter Pet Nickname: ");
            //                 data = Console.ReadLine();
            //                 petNickname[empty] = data;

            //                 Console.Write("Enter Pet Species: ");
            //                 data = Console.ReadLine();
            //                 petSpecies[empty] = data;

            //                 Console.Write("Enter Pet Age: ");
            //                 data = Console.ReadLine();
            //                 petAge[empty] = data;

            //                 Console.Write("Enter Pet Description Condition: ");
            //                 data = Console.ReadLine();
            //                 petdescriptionCondition[empty] = data;

            //                 Console.Write("Enter Pet Personality: ");
            //                 data = Console.ReadLine();
            //                 petPersonality[empty] = data;

            //                 break;

            //             }


            //         }

            //         break;
            //         case "3":
            //         int j= 0;
            //         int k = 0;
            //             for(i=0;i<=petID.Length;i++){

            //                 if(petID[i] != ""){
            //                     if(petAge[i] == "" && petdescriptionCondition[i] != ""){
            //                         Console.WriteLine($"Pet Id is {petID[i]} name is {petNickname[i]} is missing age");
            //                         Console.WriteLine("Add age");
            //                         Console.Write("Enter Age: ");
            //                         string age = Console.ReadLine();
            //                         petAge[i] = age;
            //                         break;
            //                     }
            //                     else if(petAge[i] != "" && petdescriptionCondition[i] == ""){
            //                         Console.WriteLine($"Pet Id is {petID[i]} name is {petNickname[i]} is missing description");
            //                         Console.WriteLine("Add s");
            //                         Console.Write("Enter physical description: ");
            //                         string description = Console.ReadLine();
            //                         petdescriptionCondition[i] = description;
            //                         break;
            //                     }
            //                     else if(petAge[i] == "" && petdescriptionCondition[i] == ""){

            //                         Console.WriteLine($"Pet Id is {petID[i]} name is {petNickname[i]} is missing age or description");

            //                         Console.WriteLine($"Add age and physical descriptions");
            //                         Console.Write("Enter Age: ");
            //                         string age = Console.ReadLine();
            //                         Console.Write("Enter physical description: ");
            //                         string description = Console.ReadLine();
            //                         petAge[i] = age;
            //                         petdescriptionCondition[i] = description;
            //                         break;
            //                     }
            //                 }

            //                 if(petID[i] == "" || petID[i] != ""){  
            //                     j = j+1;
            //                     k = i;
            //                     int l = petID.Length;
            //                     if(j == l){
            //                         Console.WriteLine("All Pet Data is Complete");
            //                         Console.Read();
            //                         break;
            //                     }
            //                 }

            //             }

            //         break;
            //         case "4":
            //         j= 0;
            //         k = 0;
            //             for(i=0;i<=petID.Length;i++){

            //                 if(petID[i] != ""){
            //                     if(petNickname[i] == "" && petPersonality[i] != ""){
            //                         Console.WriteLine($"Pet Id is {petID[i]} is missing nickname");
            //                         Console.WriteLine("Add nickname");
            //                         Console.Write("Enter nickname: ");
            //                         string age = Console.ReadLine();
            //                         petNickname[i] = age;
            //                         break;
            //                     }
            //                     else if(petNickname[i] != "" && petPersonality[i] == ""){
            //                         Console.WriteLine($"Pet Id is {petID[i]} name is {petNickname[i]} is missing personality description");
            //                         Console.WriteLine("Add personality");
            //                         Console.Write("Enter personality description: ");
            //                         string description = Console.ReadLine();
            //                         petPersonality[i] = description;
            //                         break;
            //                     }
            //                     else if(petNickname[i] == "" && petPersonality[i] == ""){

            //                         Console.WriteLine($"Pet Id is {petID[i]} is missing nickname and personality description");

            //                         Console.WriteLine($"Add age and physical descriptions");
            //                         Console.Write("Enter Nickname: ");
            //                         string age = Console.ReadLine();
            //                         Console.Write("Enter personality description: ");
            //                         string description = Console.ReadLine();
            //                         petNickname[i] = age;
            //                         petPersonality[i] = description;
            //                         break;
            //                     }
            //                 }

            //                 if(petID[i] == "" || petID[i] != ""){  
            //                     j = j+1;
            //                     k = i;
            //                     int l = petID.Length;
            //                     if(j == l){
            //                         Console.WriteLine("All Pet Data is Complete");
            //                         Console.Read();
            //                         break;
            //                     }
            //                 }

            //             }

            //         break;
            //         case "5":

            //         Console.WriteLine("Function not available");
            //         break;
            //         case "6":

            //         Console.WriteLine("Function not available");
            //         break;
            //         case "7":
            //         for (i = 0; i < petSpecies.Length; i++){
            //             string Species = Convert.ToString(petSpecies[i]);
            //             if (Species == "Dog"){
            //                 Console.WriteLine($"Pet Id is {petID[arrayNum]} name is {petNickname[arrayNum]} he/she is a {petAge[arrayNum]} years old {petSpecies[arrayNum]} with a condition of {petdescriptionCondition[arrayNum]} and have a {petPersonality[arrayNum]} personality");


            //             }

            //         }Console.ReadKey();
            //         break;
            //         case "8":
            //         for (i = 0; i < petSpecies.Length;i++){
            //             string Species = petSpecies[i];
            //             if (Species == "Cat"){
            //                 Console.WriteLine($"Pet Id is {petID[arrayNum]} name is {petNickname[arrayNum]} he/she is a {petAge[arrayNum]} years old {petSpecies[arrayNum]} with a condition of {petdescriptionCondition[arrayNum]} and have a {petPersonality[arrayNum]} personality");
            //             }

            //         }
            //         Console.ReadKey();
            //         break;
            //         default:
            //         arrayNum = 0;
            //         break;

            //     }

            // }while(choice != "exit");

            // Console.WriteLine("Signed integral types:");

            // Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            // Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            // Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            // Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}\n");

            // Console.WriteLine("Signed integral types:");

            // Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            // Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            // Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            // Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            // Console.WriteLine("");
            // Console.WriteLine("Floating point types:");
            // Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            // Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            // Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

            // int[] data = new int[3];

            // string shortenedString = "Hello World!";
            // Console.WriteLine(shortenedString);

            // int val_A = 2;
            // int val_B = val_A;
            // val_B = 5;

            // Console.WriteLine("--Value Types--");
            // Console.WriteLine($"val_A: {val_A}");
            // Console.WriteLine($"val_B: {val_B}");

            // Console.WriteLine("");
            // int[] ref_A= new int[1];
            // ref_A[0] = 2;
            // int[] ref_B = ref_A;
            // ref_B[0] = 5;

            // Console.WriteLine("--Reference Types--");
            // Console.WriteLine($"ref_A[0]: {ref_A[0]}");
            // Console.WriteLine($"ref_B[0]: {ref_B[0]}");

            // int first = 2;
            // string second = "4";
            // int result = first + second;
            // Console.WriteLine(result); // error message

            // int first = 2;
            // string second = "4";
            // string result = first + second;
            // Console.WriteLine(result);

            // int myInt = 3;
            // Console.WriteLine($"int: {myInt}");

            // decimal myDecimal = myInt;
            // Console.WriteLine($"decimal: {myDecimal}");

            // decimal myDecimal = 3.14m;
            // Console.WriteLine($"decimal: {myDecimal}");

            // int myInt = (int)myDecimal;
            // Console.WriteLine($"int: {myInt}");

            // decimal myDecimal = 1.23456789m;
            // float myFloat = (float)myDecimal;

            // Console.WriteLine($"Decimal: {myDecimal}");
            // Console.WriteLine($"Float  : {myFloat}");

            // int first = 5;
            // int second = 7;
            // string message = first.ToString() + second.ToString();
            // Console.WriteLine(message);

            // string first = "5";
            // string second = "7";
            // int sum = int.Parse(first) + int.Parse(second);
            // Console.WriteLine(sum);

            // string value1 = "5";
            // string value2 = "7";
            // int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            // Console.WriteLine(result);

            // int value = (int)1.5m; // casting truncates
            // Console.WriteLine(value);

            // int value2 = Convert.ToInt32(1.5m); // converting rounds up
            // Console.WriteLine(value2);

            // string name = "Bob";
            // Console.WriteLine(int.Parse(name));

            // string value = "102";
            // int result = 0;
            // if (int.TryParse(value, out result))
            // {
            //    Console.WriteLine($"Measurement: {result}");
            // }
            // else
            // {
            //    Console.WriteLine("Unable to report the measurement.");
            // }

            // string value = "102";
            // int result = 0;
            // if (int.TryParse(value, out result))
            // {
            //    Console.WriteLine($"Measurement: {result}");
            // }
            // else
            // {
            //    Console.WriteLine("Unable to report the measurement.");
            // }
            // Console.WriteLine($"Measurement (w/ offset): {50 + result}");

            // string value = "bad";
            // int result = 0;
            // if (int.TryParse(value, out result))
            // {
            //    Console.WriteLine($"Measurement: {result}");
            // }
            // else
            // {
            //    Console.WriteLine("Unable to report the measurement.");
            // }

            // if (result > 0)
            //    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

            // string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            // decimal result =0m;
            // string message ="";

            // foreach (string value in values)
            // {
            // 	decimal number;
            // 	if(decimal.TryParse(value, out number)){
            // 		result += number;
            // 	}
            // 	else{
            // 		message += value;
            // 	}
            // }
            // Console.WriteLine($"Message: {message}");
            // Console.WriteLine($"Total: {result}");

            // int value1 = 11;
            // decimal value2 = 6.2m;
            // float value3 = 4.3f;

            // // The Convert class is best for converting the fractional decimal numbers into whole integer numbers
            // // Convert.ToInt32() rounds up the way you would expect.
            // int result1 = Convert.ToInt32(value1 / value2);
            // Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // decimal result2 = value2 / (decimal)value3;
            // Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // float result3 = value3 / value1;
            // Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

            // string[] pallets = { "B14", "A11", "B12", "A13" };

            // Console.WriteLine("Sorted...");
            // Array.Sort(pallets);
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }
            // Console.WriteLine("");
            // Console.WriteLine("Reversed...");
            // Array.Reverse(pallets);
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // string[] pallets = { "B14", "A11", "B12", "A13" };
            // Console.WriteLine("");

            // Array.Clear(pallets, 0, 2);
            // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // string[] pallets = { "B14", "A11", "B12", "A13" };
            // Console.WriteLine("");

            // Console.WriteLine($"Before: {pallets[0]}");
            // Array.Clear(pallets, 0, 2);
            // Console.WriteLine($"After: {pallets[0]}");

            // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // string[] pallets = { "B14", "A11", "B12", "A13" };
            // Console.WriteLine("");

            // Array.Clear(pallets, 0, 2);
            // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // Console.WriteLine("");
            // Array.Resize(ref pallets, 6);
            // Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            // pallets[4] = "C01";
            // pallets[5] = "C02";

            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // string[] pallets = { "B14", "A11", "B12", "A13" };
            // Console.WriteLine("");

            // Array.Clear(pallets, 0, 2);
            // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // Console.WriteLine("");
            // Array.Resize(ref pallets, 6);
            // Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            // pallets[4] = "C01";
            // pallets[5] = "C02";

            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // Console.WriteLine("");
            // Array.Resize(ref pallets, 3);
            // Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // string value = "abc123";
            // char[] valueArray = value.ToCharArray();
            // Array.Reverse(valueArray);
            // string result = new string(valueArray);
            // Console.WriteLine(result);

            // string value = "abc123";
            // char[] valueArray = value.ToCharArray();
            // Array.Reverse(valueArray);
            // // string result = new string(valueArray);
            // string result = String.Join(",", valueArray);
            // Console.WriteLine(result);

            // string[] items = result.Split(',');
            // foreach (string item in items)
            // {
            //     Console.WriteLine(item);
            // }

            // string value = "CBDTJ";
            // char[] valueArray = value.ToCharArray();
            // Array.Reverse(valueArray);

            // string result = String.Join("a", valueArray);
            // Console.WriteLine(result);
            // string[] items = result.Split('a');
            // foreach (string item in items)
            // {
            //     Console.WriteLine(item);
            // }

            // string pangram = "The quick brown fox jumps over the lazy dog";

            // // Step 1
            // string[] message = pangram.Split(' ');

            // //Step 2
            // string[] newMessage = new string[message.Length];

            // // Step 3
            // for (int i = 0; i < message.Length; i++)
            // {
            //     char[] letters = message[i].ToCharArray();
            //     Array.Reverse(letters);
            //     newMessage[i] = new string(letters);
            // }

            // //Step 4
            // string result = String.Join(" ", newMessage);
            // Console.WriteLine(result);

            // string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            // string[] items = orderStream.Split(',');
            // Array.Sort(items);

            // foreach (var item in items)
            // {
            //     if (item.Length == 4)
            //     {
            //         Console.WriteLine(item);
            //     }
            //     else
            //     {
            //         Console.WriteLine(item + "\t- Error");
            //     }
            // }

            // string first = "Hello";
            // string second = "World";
            // string result = string.Format("{0} {1}!", first, second);
            // Console.WriteLine(result);

            // string first = "Hello";
            // string second = "World";
            // Console.WriteLine("{1} {0}!", first, second);
            // Console.WriteLine("{0} {0} {0}!", first, second);

            // string first = "Hello";
            // string second = "World";
            // Console.WriteLine($"{first} {second}!");
            // Console.WriteLine($"{second} {first}!");
            // Console.WriteLine($"{first} {first} {first}!");

            // :C is for currency and :N is for decimal digits

            // decimal price = 123.45m;
            // int discount = 50;
            // Console.WriteLine($"Price: {price:C} (Save {discount:C})");

            // decimal measurement = 123456.78912m;
            // Console.WriteLine($"Measurement: {measurement:N} units");

            // decimal measurement = 123456.78912m;
            // Console.WriteLine($"Measurement: {measurement:N4} units");

            // decimal price = 67.55m;
            // decimal salePrice = 59.99m;

            // string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

            // Console.WriteLine(yourDiscount);

            // decimal price = 67.55m;
            // decimal salePrice = 59.99m;

            // string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

            // yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
            // Console.WriteLine(yourDiscount);

            // //explanation above on how the two is combined
            // string str1 = "hello";
            // string str2 = " world";

            // string str3 = str1 + str2;

            // Console.WriteLine(str3);

            // int invoiceNumber = 1201;
            // decimal productShares = 25.4568m;
            // decimal subtotal = 2750.00m;
            // decimal taxPercentage = .15825m;
            // decimal total = 3185.19m;

            // Console.WriteLine($"Invoice Number: {invoiceNumber}");
            // Console.WriteLine($"   Shares: {productShares:N3} Product");
            // Console.WriteLine($"     Sub Total: {subtotal:C}");
            // Console.WriteLine($"           Tax: {taxPercentage:P2}");
            // Console.WriteLine($"     Total Billed: {total:C}");

            // string input = "Pad this";
            //  Console.WriteLine(input.PadLeft(12, '-'));
            //  Console.WriteLine(input.PadRight(12,'-'));

            // string paymentId = "769C";
            //  string payeeName = "Mr. Stephen Ortega";
            //  string paymentAmount = "$5,000.00";

            //  var formattedLine = paymentId.PadRight(6);
            //  formattedLine += payeeName.PadRight(24);
            //  formattedLine += paymentAmount.PadLeft(10);

            //  Console.WriteLine("1234567890123456789012345678901234567890");
            //  Console.WriteLine(formattedLine);

            // string customerName = "Ms. Barros";

            // string currentProduct = "Magic Yield";
            // int currentShares = 2975000;
            // decimal currentReturn = 0.1275m;
            // decimal currentProfit = 55000000.0m;

            // string newProduct = "Glorious Future";
            // decimal newReturn = 0.13125m;
            // decimal newProfit = 63000000.0m;

            // Console.WriteLine($"Dear {customerName},");
            // Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
            // Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
            // Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

            // Console.WriteLine("Here's a quick comparison:\n");

            // string comparisonMessage = "";

            // comparisonMessage = currentProduct.PadRight(20);
            // comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
            // comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

            // comparisonMessage += "\n";
            // comparisonMessage += newProduct.PadRight(20);
            // comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
            // comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

            // Console.WriteLine(comparisonMessage);


            // string message = "Find what is (inside the parenthesis)";

            // int openingPosition = message.IndexOf('(');
            // int closingPosition = message.IndexOf(')');

            // // Console.WriteLine(openingPosition);
            // // Console.WriteLine(closingPosition);

            // // int length = closingPosition - openingPosition;
            // // Console.WriteLine(message.Substring(openingPosition,length));


            // openingPosition += 1;

            // int length = closingPosition - openingPosition;
            // Console.WriteLine(message.Substring(openingPosition,length));

            // // Output: inside the parenthesis


            // string message = "What is the value <span>between the tags</span>?";
            // int openingPosition = message.IndexOf("<span>");
            // int closingPosition = message.IndexOf("</span>");

            // openingPosition +=6;

            // int length = closingPosition - openingPosition;
            // Console.WriteLine(message.Substring(openingPosition, length));

            // string message = "What is the value <span>between the tags</span>?";

            // const string openSpan = "<span>";
            // const string closeSpan = "</span>";

            // int openingPosition = message.IndexOf(openSpan);
            // int closingPosition = message.IndexOf(closeSpan);

            // openingPosition += openSpan.Length;
            // int length = closingPosition - openingPosition;
            // Console.WriteLine(message.Substring(openingPosition, length));

            // string message = "(What if) I am (only interested) in the last (set of parentheses)?";
            // int openingPosition = message.LastIndexOf('(');

            // openingPosition += 1;
            // int closingPosition = message.LastIndexOf(')');
            // int length = closingPosition - openingPosition;
            // Console.WriteLine(message.Substring(openingPosition, length));

            // string message = "(What if) there are (more than) one (set of parentheses)?";
            // while (true)
            // {
            //     int openingPosition = message.IndexOf('(');
            //     if (openingPosition == -1) break;

            //     openingPosition += 1;
            //     int closingPosition = message.IndexOf(')');
            //     int length = closingPosition - openingPosition;
            //     Console.WriteLine(message.Substring(openingPosition, length));

            //     // Note the overload of the Substring to return only the remaining 
            //     // unprocessed message:
            //     message = message.Substring(closingPosition + 1);
            // }

            // string message = "Help (find) the {opening symbols}";
            // Console.WriteLine($"Searching THIS Message: {message}");
            // char[] openSymbols = { '[', '{', '(' };
            // int startPosition = 5;
            // int openingPosition = message.IndexOfAny(openSymbols);
            // Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

            // openingPosition = message.IndexOfAny(openSymbols, startPosition);
            // Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

            // ///\///\///\///\///\///\///\
            // string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            // // The IndexOfAny() helper method requires a char array of characters. 
            // // You want to look for:

            // char[] openSymbols = { '[', '{', '(' };

            // // You'll use a slightly different technique for iterating through 
            // // the characters in the string. This time, use the closing 
            // // position of the previous iteration as the starting index for the 
            // //next open symbol. So, you need to initialize the closingPosition 
            // // variable to zero:
            // /**/
            // int closingPosition = 0;

            // while (true)
            // {
            //     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

            // 	Console.WriteLine("The opening position and closing position " + openingPosition + " "+ closingPosition);

            //     if (openingPosition == -1) break;

            //     string currentSymbol = message.Substring(openingPosition, 1);

            //     // Now  find the matching closing symbol
            //     char matchingSymbol = ' ';

            //     switch (currentSymbol)
            //     {
            //         case "[":
            //             matchingSymbol = ']';
            //             break;
            //         case "{":
            //             matchingSymbol = '}';
            //             break;
            //         case "(":
            //             matchingSymbol = ')';
            //             break;
            //     }

            //     // To find the closingPosition, use an overload of the IndexOf method to specify 
            //     // that the search for the matchingSymbol should start at the openingPosition in the string. 

            //     openingPosition += 1;
            //     closingPosition = message.IndexOf(matchingSymbol, openingPosition);
            // 	Console.WriteLine("The opening position and closing position updated is "+openingPosition + " "+ closingPosition);

            //     // Finally, use the techniques you've already learned to display the sub-string:

            //     int length = closingPosition - openingPosition;
            // 	Console.WriteLine( "the length is "+length);
            //     Console.WriteLine(message.Substring(openingPosition, length));
            // }

            // string data = "12345John Smith          5000  3  ";
            // string updatedData = data.Remove(5, 20);
            // //postion then how many
            // Console.WriteLine(updatedData);

            // string message = "This--is--ex-amp-le--da-ta";
            // message = message.Replace("--", " ");
            // //what will be replace and what will replace it
            // message = message.Replace("-", "");
            // Console.WriteLine(message);

            // const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            // string quantity = "";
            // string output = "";

            // // Your work here

            // // Extract the "quantity"
            // const string openSpan = "<span>";
            // const string closeSpan = "</span>";

            // int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
            // Console.WriteLine(quantityStart);
            // int quantityEnd= input.IndexOf(closeSpan);
            // Console.WriteLine(quantityEnd);
            // int quantityLength = quantityEnd - quantityStart;
            // Console.WriteLine(quantityLength);
            // quantity = input.Substring(quantityStart, quantityLength);
            // Console.WriteLine(quantity);
            // quantity = $"Quantity: {quantity}";
            // Console.WriteLine(quantity);

            // // Set output to input, replacing the trademark symbol with the registered trademark symbol
            // const string tradeSymbol = "&trade;";
            // Console.WriteLine(tradeSymbol);
            // const string regSymbol = "&reg;";
            // Console.WriteLine(regSymbol);
            // output = input.Replace(tradeSymbol, regSymbol);
            // Console.WriteLine(output);

            // // Remove the opening <div> tag
            // const string openDiv = "<div>";
            // int divStart = output.IndexOf(openDiv);
            // Console.WriteLine(divStart);
            // output = output.Remove(divStart, openDiv.Length);
            // Console.WriteLine(output);

            // // Remove the closing </div> tag and add "Output:" to the beginning
            // const string closeDiv = "</div>";
            // int divCloseStart = output.IndexOf(closeDiv);
            // Console.WriteLine(divCloseStart);
            // output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

            // Console.WriteLine(quantity);
            // Console.WriteLine(output);

            // #1 the ourAnimals array will store the following: 
            // string animalSpecies = "";
            // string animalID = "";
            // string animalAge = "";
            // string animalPhysicalDescription = "";
            // string animalPersonalityDescription = "";
            // string animalNickname = "";
            // string suggestedDonation = "";

            // // #2 variables that support data entry
            // int maxPets = 8;
            // string? readResult;
            // string menuSelection = "";
            // decimal decimalDonation = 0.00m;

            // // #3 array used to store runtime data, there is no persisted data
            // string[,] ourAnimals = new string[maxPets, 7];

            // // #4 create sample data ourAnimals array entries
            // for (int i = 0; i < maxPets; i++)
            // {
            //     switch (i)
            //     {
            //         case 0:
            //             animalSpecies = "dog";
            //             animalID = "d1";
            //             animalAge = "2";
            //             animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            //             animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            //             animalNickname = "lola";
            //             suggestedDonation = "85.00";
            //             break;

            //         case 1:
            //             animalSpecies = "dog";
            //             animalID = "d2";
            //             animalAge = "9";
            //             animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            //             animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            //             animalNickname = "gus";
            //             suggestedDonation = "49.99";
            //             break;

            //         case 2:
            //             animalSpecies = "cat";
            //             animalID = "c3";
            //             animalAge = "1";
            //             animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            //             animalPersonalityDescription = "friendly";
            //             animalNickname = "snow";
            //             suggestedDonation = "40.00";
            //             break;

            //         case 3:
            //             animalSpecies = "cat";
            //             animalID = "c4";
            //             animalAge = "3";
            //             animalPhysicalDescription = "Medium sized, long hair, yellow, female, about 10 pounds. Uses litter box.";
            //             animalPersonalityDescription = "A people loving cat that likes to sit on your lap.";
            //             animalNickname = "Lion";
            //             suggestedDonation = "";
            //             break;

            //         default:
            //             animalSpecies = "";
            //             animalID = "";
            //             animalAge = "";
            //             animalPhysicalDescription = "";
            //             animalPersonalityDescription = "";
            //             animalNickname = "";
            //             suggestedDonation = "";
            //             break;

            //     }

            //     ourAnimals[i, 0] = "ID #: " + animalID;
            //     ourAnimals[i, 1] = "Species: " + animalSpecies;
            //     ourAnimals[i, 2] = "Age: " + animalAge;
            //     ourAnimals[i, 3] = "Nickname: " + animalNickname;
            //     ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
            //     ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
            //     ourAnimals[i, 6] = "Suggested Donation: "  + suggestedDonation;

            //     if (!decimal.TryParse(suggestedDonation, out decimalDonation)){
            //     decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
            //     }ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
            // }

            // // #5 display the top-level menu options
            // do
            // {
            //     // NOTE: the Console.Clear method is throwing an exception in debug sessions
            //     Console.Clear();

            //     Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            //     Console.WriteLine(" 1. List all of our current pet information");
            //     Console.WriteLine(" 2. Display all dogs with a specified characteristic");
            //     Console.WriteLine();
            //     Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

            //     readResult = Console.ReadLine();
            //     if (readResult != null)
            //     {
            //         menuSelection = readResult.ToLower();
            //     }

            //     // use switch-case to process the selected menu option
            //     switch (menuSelection)
            //     {
            //         case "1":
            //             // list all pet info
            //             for (int i = 0; i < maxPets; i++)
            //             {
            //                 if (ourAnimals[i, 0] != "ID #: ")
            //                 {
            //                     Console.WriteLine();
            //                     for (int j = 0; j < 7; j++)
            //                     {
            //                         Console.WriteLine(ourAnimals[i, j]);
            //                     }
            //                 }
            //             }
            //             Console.WriteLine("\n\rPress the Enter key to continue");
            //             readResult = Console.ReadLine();

            //             break;

            //         case "2":
            //             // Display all dogs with a specified characteristic
            //             string dogCharacteristic = "";

            //             while (dogCharacteristic == "")
            //             {
            //                 // have the user enter physical characteristics to search for
            //                 Console.WriteLine($"\nEnter one desired dog characteristics to search for");
            //                 readResult = Console.ReadLine();
            //                 if (readResult != null)
            //                 {
            //                     dogCharacteristic = readResult.ToLower().Trim();
            //                 }
            //             }
            //             string dogDescription = "";
            //             bool noMatchesDog = true;
            //              // #6 loop through the ourAnimals array to search for matching animals
            //                 for (int i = 0; i < maxPets; i++)
            //                 {
            //                     if (ourAnimals[i, 1].Contains("dog"))
            //                     {
            //                         dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
            //                     // #7 Search combined descriptions and report results
            //                         if (dogDescription.Contains(dogCharacteristic))
            //                         {
            //                             Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");
            //                             Console.WriteLine(dogDescription);
            //                             noMatchesDog = false;
            //                         }
            //                     }
            //                 }
            //                 if (noMatchesDog)
            //                 {
            //                     Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
            //                 }
            //             Console.WriteLine("Press the Enter key to continue.");
            //             readResult = Console.ReadLine();
            //             break;

            //         default:
            //             break;
            //     }

            // } while (menuSelection != "exit");

            // SayHello();

            // void SayHello() 
            // {
            //     Console.WriteLine("Hello World!");
            // }

            // int[] a = {1,2,3,4,5};

            // Console.WriteLine("Contents of Array:");
            // PrintArray();

            // void PrintArray()
            // {
            //     foreach (int x in a)
            //     {
            //         Console.Write($"{x} ");
            //     }
            //     Console.WriteLine();
            // }

            // Console.WriteLine("Generating random numbers:");
            // DisplayRandomNumbers();

            // void DisplayRandomNumbers() 
            // {
            //     Random random = new Random();

            //     for (int i = 0; i < 5; i++) 
            //     {
            //         Console.Write($"{random.Next(1, 100)} ");
            //     }

            //     Console.WriteLine();
            // }

            // int[] times = {800, 1200, 1600, 2000};
            // int diff = 0;

            // Console.WriteLine("Enter current GMT");
            // int currentGMT = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Current Medicine Schedule:");
            // DisplayTimes();

            // Console.WriteLine("Enter new GMT");
            // int newGMT = Convert.ToInt32(Console.ReadLine());

            // if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
            // {
            //     Console.WriteLine("Invalid GMT");
            // }
            // else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
            // {
            //     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
            //     AdjustTimes();
            // } 
            // else 
            // {
            //     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
            //     AdjustTimes();
            // }

            // Console.WriteLine("New Medicine Schedule:");
            // DisplayTimes();

            // void DisplayTimes()
            // {
            //     /* Format and display medicine times */
            //     foreach (int val in times)
            //     {
            //         string time = val.ToString();
            //         int len = time.Length;

            //         if (len >= 3)
            //         {
            //             time = time.Insert(len - 2, ":");
            //         }
            //         else if (len == 2)
            //         {
            //             time = time.Insert(0, "0:");
            //         }
            //         else
            //         {
            //             time = time.Insert(0, "0:0");
            //         }

            //         Console.Write($"{time} ");
            //     }
            //     Console.WriteLine();
            // }

            // void AdjustTimes() 
            // {
            //     /* Adjust the times by adding the difference, keeping the value within 24 hours */
            //     for (int i = 0; i < times.Length; i++) 
            //     {
            //         times[i] = ((times[i] + diff)) % 2400;
            //     }
            // }

            // string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
            // string[] address;
            // bool validLength = false;
            // bool validZeroes = false;
            // bool validRange = false;

            // foreach (string ip in ipv4Input) 
            // {
            //     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

            //     ValidateLength(); 
            //     ValidateZeroes(); 
            //     ValidateRange();

            //     if (validLength && validZeroes && validRange) 
            //     {
            //         Console.WriteLine($"{ip} is a valid IPv4 address");
            //     } 
            //     else 
            //     {
            //         Console.WriteLine($"{ip} is an invalid IPv4 address");
            //     }
            // }

            // void ValidateLength() 
            // {
            //     validLength = address.Length == 4;
            // };

            // void ValidateZeroes() 
            // {
            //     foreach (string number in address) 
            //     {
            //         if (number.Length > 1 && number.StartsWith("0")) 
            //         {
            //             validZeroes = false;
            //             return;
            //         }
            //     }

            //     validZeroes = true;
            // }

            // void ValidateRange() 
            // {
            //     foreach (string number in address) 
            //     {
            //         int value = int.Parse(number);
            //         if (value < 0 || value > 255) 
            //         {
            //             validRange = false;
            //             return;
            //         }
            //     }
            //     validRange = true;
            // }

            // Random random = new Random();
            // int luck = random.Next(100);

            // string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
            // string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
            // string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
            // string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

            // TellFortune();

            // void TellFortune() 
            // {
            //     Console.WriteLine("A fortune teller whispers the following words:");
            //     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
            //     for (int i = 0; i < 4; i++) 
            //     {
            //         Console.Write($"{text[i]} {fortune[i]} ");
            //     }
            // }

            // CountTo(5);

            // 	void CountTo(int max) 
            // 	{
            // 		for (int i = 0; i < max; i++)
            // 		{
            // 			Console.Write($"{i}, ");
            // 		}
            // 	}

            // int[] schedule = {800, 1200, 1600, 2000};

            // void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) 
            // {
            // int diff = 0;
            // if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
            // {
            //     Console.WriteLine("Invalid GMT");
            // }
            // else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
            // {
            //     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
            // } 
            // else 
            // {
            //     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
            // }

            // for (int i = 0; i < times.Length; i++) 
            // {
            //     int newTime = ((times[i] + diff)) % 2400;
            //     Console.WriteLine($"{times[i]} -> {newTime}");
            // }
            // }
            // DisplayAdjustedTimes(schedule, 6, -6);

            // string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

            // DisplayStudents(students);
            // DisplayStudents(new string[] {"Robert","Vanya"});

            // void DisplayStudents(string[] students) 
            // {
            //     foreach (string student in students) 
            //     {
            //         Console.Write($"{student}, ");
            //     }
            //     Console.WriteLine();
            // }

            // double pi = 3.14159;

            // PrintCircleInfo(12);
            // PrintCircleInfo(24);

            // void PrintCircleInfo(int radius) 
            // {
            //     Console.WriteLine($"Circle with radius {radius}");
            //     PrintCircleArea(radius);
            //     PrintCircleCircumference(radius);
            // }
            // void PrintCircleArea(int radius)
            // {
            //     double area = pi * (radius * radius);
            //     Console.WriteLine($"Area = {area}");
            // }

            // void PrintCircleCircumference(int radius)
            // {
            //     double circumference = 2 * pi * radius;
            //     Console.WriteLine($"Circumference = {circumference}");
            // }

            // int a = 3;
            // int b = 4;
            // int c = 0;

            // Multiply(a, b, c);
            // Console.WriteLine($"global statement: {a} x {b} = {c}");

            // void Multiply(int a, int b, int c) 
            // {
            //     c = a * b;
            //     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
            // }

            // int[] array = {1, 2, 3, 4, 5};

            // PrintArray(array);
            // Clear(array);
            // PrintArray(array);

            // void PrintArray(int[] array) 
            // {
            //     foreach (int a in array) 
            //     {
            //         Console.Write($"{a} ");
            //     }
            //     Console.WriteLine();
            // }

            // void Clear(int[] array) 
            // {
            //     for (int i = 0; i < array.Length; i++) 
            //     {
            //         array[i] = 0;
            //     }
            // }

            // string status = "Healthy";

            // Console.WriteLine($"Start: {status}");
            // SetHealth(status, false);
            // Console.WriteLine($"End: {status}");

            // void SetHealth(string status, bool isHealthy) 
            // {
            //     status = (isHealthy ? "Healthy" : "Unhealthy");
            //     Console.WriteLine($"Middle: {status}");
            // }

            // string status = "Healthy";

            // Console.WriteLine($"Start: {status}");
            // SetHealth(false);
            // Console.WriteLine($"End: {status}");

            // void SetHealth(bool isHealthy) 
            // {
            //     status = (isHealthy ? "Healthy" : "Unhealthy");
            //     Console.WriteLine($"Middle: {status}");
            // }

            // 

            // string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
            // string[] rsvps = new string[10];
            // int count = 0;
            // RSVP("Rebecca", 1, "none", true);
            // RSVP("Nadia", 2, "Nuts", true);
            // RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
            // RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1);
            // RSVP("Noor", 4, "none", false);
            // RSVP("Jonte", 2, "Stone fruit", false);

            // ShowRSVPs();


            // void RSVP(string name, int partySize, string allergies, bool inviteOnly) 
            // {
            //     if (inviteOnly)
            // {
            //     bool found = false;
            //     foreach (string guest in guestList)
            //     {
            //         if (guest.Equals(name)) {
            //             found = true;
            //             break;
            //         }
            //     }
            //     if (!found)
            //     {
            //         Console.WriteLine($"Sorry, {name} is not on the guest list");
            //         return;
            //     }
            // }

            //     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
            //     count++;
            // }

            // void ShowRSVPs()
            // {
            //     Console.WriteLine("\nTotal RSVPs:");
            //     for (int i = 0; i < count; i++)
            //     {
            //         Console.WriteLine(rsvps[i]);
            //     }
            // }

            // string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
            // string[] rsvps = new string[10];
            // int count = 0;
            // RSVP("Rebecca");
            // RSVP("Nadia", 2, "Nuts");
            // RSVP(name: "Linh", partySize: 2, inviteOnly: false);
            // RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
            // RSVP("Noor", 4, inviteOnly: false);
            // RSVP("Jonte", 2, "Stone fruit", false);

            // ShowRSVPs();


            // void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true) 
            // {
            //     if (inviteOnly)
            // {
            //     bool found = false;
            //     foreach (string guest in guestList)
            //     {
            //         if (guest.Equals(name)) {
            //             found = true;
            //             break;
            //         }
            //     }
            //     if (!found)
            //     {
            //         Console.WriteLine($"Sorry, {name} is not on the guest list");
            //         return;
            //     }
            // }

            //     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
            //     count++;
            // }

            // void ShowRSVPs()
            // {
            //     Console.WriteLine("\nTotal RSVPs:");
            //     for (int i = 0; i < count; i++)
            //     {
            //         Console.WriteLine(rsvps[i]);
            //     }
            // }

            // string[,] corporate = 
            // 	{
            // 		{"Robert", "Bavin"}, {"Simon", "Bright"},
            // 		{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
            // 		{"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

            // 	string[,] external = 
            // 	{
            // 		{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
            // 		{"Shay", "Lawrence"}, {"Daren", "Valdes"}
            // 	};

            // 	string externalDomain = "hayworth.com";

            // 	for (int i = 0; i < corporate.GetLength(0); i++) 
            // 	{
            // 		DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
            // 	}

            // 	for (int i = 0; i < external.GetLength(0); i++) 
            // 	{
            // 		DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
            // 	}

            // 	void DisplayEmail(string first, string last, string domain = "contoso.com") 
            // 	{
            // 		string email = first.Substring(0, 2) + last;
            // 		email = email.ToLower();
            // 		Console.WriteLine($"{email}@{domain}");
            // 	}

            // double total = 0;
            // double minimumSpend = 30.00;

            // double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
            // double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

            // for (int i = 0; i < items.Length; i++)
            // {
            //     total += GetDiscountedPrice(i);

            // }
            // total -= TotalMeetsMinimum() ? 5.00 : 0.00;

            // Console.WriteLine($"Total: ${FormatDecimal(total)}");

            // double GetDiscountedPrice(int itemIndex)
            // {
            //     return items[itemIndex] * (1 - discounts[itemIndex]);
            // }

            // bool TotalMeetsMinimum()
            // {
            //     return total >= minimumSpend;
            // }

            // string FormatDecimal(double input)
            // {
            //     return input.ToString().Substring(0, 5);
            // }

            // double usd = 23.73;
            // int vnd = UsdToVnd(usd);

            // Console.WriteLine($"${usd} USD = ${vnd} VND");

            // int UsdToVnd(double usd) 
            // {
            // int rate = 23500;
            // return (int)(rate *usd);	
            // }

            // double usd = 23.73;
            // int vnd = UsdToVnd(usd);

            // Console.WriteLine($"${usd} USD = ${vnd} VND");
            // Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

            // int UsdToVnd(double usd) 
            // {
            //     int rate = 23500;
            //     return (int) (rate * usd);
            // }

            // double VndToUsd(int vnd) 
            // {
            //     double rate = 23500;
            //     return vnd / rate;
            // }

            // string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

            // Console.WriteLine("Is it a palindrome?");
            // foreach (string word in words) 
            // {
            //     Console.WriteLine($"{word}: {IsPalindrome(word)}");
            // }

            // bool IsPalindrome(string word) 
            // {
            //     int start = 0;
            //     int end = word.Length - 1;

            //     while (start < end) 
            //     {
            //         if (word[start] != word[end]) 
            //         {
            //             return false;
            //         }
            //         start++;
            //         end--;
            //     }

            //     return true;
            // }

            // int target = 60;
            // int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
            // int[] result = TwoCoins(coins, target);

            // int[] TwoCoins(int[] coins, int target) 
            // {
            // for (int curr = 0; curr < coins.Length; curr++) 
            // {
            //     for (int next = curr + 1; next < coins.Length; next++) 
            //     {
            //         if (coins[curr] + coins[next] == target) 
            //         {
            //             return new int[]{curr, next};
            //         }

            //     }
            // }
            //     return  new int[0];
            // }

            // if (result.Length == 0) 
            // {
            //     Console.WriteLine("No two coins make change");
            // } 
            // else 
            // {
            //     Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
            // }

            // int target = 80;
            // int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
            // int[,] result = TwoCoins(coins, target);

            // if (result.Length == 0) 
            // {
            //     Console.WriteLine("No two coins make change");
            // } 
            // else 
            // {
            //     Console.WriteLine("Change found at positions:");
            //     for (int i = 0; i < result.GetLength(0); i++) 
            //     {
            //         if (result[i,0] == -1) 
            //         {
            //             break;
            //         }
            //         Console.WriteLine($"{result[i,0]},{result[i,1]}");
            //     }
            // }

            // int[,] TwoCoins(int[] coins, int target) 
            // {
            //     int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
            //     int count = 0;

            //     for (int curr = 0; curr < coins.Length; curr++) 
            //     {
            //         for (int next = curr + 1; next < coins.Length; next++) 
            //         {    
            //             if (coins[curr] + coins[next] == target) 
            //             {
            //                 result[count, 0] = curr;
            //                 result[count, 1] = next;
            //                 count++;
            //             }
            //             if (count == result.GetLength(0)) 
            //             {
            //                 return result;
            //             }
            //         }
            //     }
            //     return (count == 0) ? new int[0,0] : result;
            // }

            // Random random = new Random();

            // Console.WriteLine("Would you like to play? (Y/N)");
            // if (ShouldPlay()) 
            // {
            //     PlayGame();
            // }

            // bool ShouldPlay() 
            // {
            //     string response = Console.ReadLine();
            //     return response.ToLower().Equals("y");
            // }

            // void PlayGame() 
            // {
            //     var play = true;

            //     while (play) {
            //         var target = GetTarget();
            //         var roll = RollDice();

            //         Console.WriteLine($"Roll a number greater than {target} to win!");
            //         Console.WriteLine($"You rolled a {roll}");
            //         Console.WriteLine(WinOrLose(roll, target));
            //         Console.WriteLine("\nPlay again? (Y/N)");

            //         play = ShouldPlay();
            //     }
            // }

            // int GetTarget() 
            // {
            //     return random.Next(1, 6);
            // }

            // int RollDice() 
            // {
            //     return random.Next(1, 7);
            // }

            // string WinOrLose(int roll, int target) 
            // {
            //     if (roll > target) 
            //     {
            //         return "You win!";
            //     }
            //     return "You lose!";
            // }

            // using System;

            // string[] pettingZoo = 
            // {
            //     "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
            //     "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
            //     "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
            // };

            // PlanSchoolVisit("School A");
            // PlanSchoolVisit("School B", 3);
            // PlanSchoolVisit("School C", 2);

            // void PlanSchoolVisit(string schoolName, int groups = 6) 
            // {
            //     RandomizeAnimals(); 
            //     string[,] group1 = AssignGroup(groups);
            //     Console.WriteLine(schoolName);
            //     PrintGroup(group1);
            // }

            // void RandomizeAnimals() 
            // {
            //     Random random = new Random();

            //     for (int i = 0; i < pettingZoo.Length; i++) 
            //     {
            //         int r = random.Next(i, pettingZoo.Length);

            //         string temp = pettingZoo[r];
            //         pettingZoo[r] = pettingZoo[i];
            //         pettingZoo[i] = temp;
            //     }
            // }

            // string[,] AssignGroup(int groups = 6) 
            // {
            //     string[,] result = new string[groups, pettingZoo.Length/groups];
            //     int start = 0;

            //     for (int i = 0; i < groups; i++) 
            //     {
            //         for (int j = 0; j < result.GetLength(1); j++) 
            //         {
            //             result[i,j] = pettingZoo[start++];
            //         }
            //     }

            //     return result;
            // }

            // void PrintGroup(string[,] groups) 
            // {
            //     for (int i = 0; i < groups.GetLength(0); i++) 
            //     {
            //         Console.Write($"Group {i + 1}: ");
            //         for (int j = 0; j < groups.GetLength(1); j++) 
            //         {
            //             Console.Write($"{groups[i,j]}  ");
            //         }
            //         Console.WriteLine();
            //     }
            // }

        }
    }
}

