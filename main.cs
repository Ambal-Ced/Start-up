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


        }
    }
}
