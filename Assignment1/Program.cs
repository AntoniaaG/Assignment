using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintName();
            PrintSum(2, 3);
            PrintDivision(7, 4);
            Result1();
            Result2();
            Result3();
            Result4();

            Console.WriteLine();

            Calculator calc = new Calculator();
            Console.WriteLine("Sum result: " + calc.Sum(2, 3));
            Console.WriteLine("Sutraction result: " + calc.Subtraction(2, 3));
            Console.WriteLine("Multiplication rezult: " + calc.Multiplication(2, 3));
            Console.WriteLine("Division result: " + calc.Division(2, 3));
            Console.WriteLine();

            PrintCSharp();
            Console.WriteLine();

            Console.WriteLine("Median: " + calc.ArithmeticMedian(10, 3, 2));
            Console.WriteLine("Modulo: " + calc.Modulo(10, 3));
            Console.WriteLine("Fahrenheit to Celsius: " + FtoC(100));
            Console.WriteLine("Inch to Meters: " + InchToMeters(10));

            Console.WriteLine();

            Console.WriteLine("Speed: ");
            Speed(3000, 1, 5, 10);

            Console.WriteLine();

            LogicalOp op = new LogicalOp();
            int biggest = op.CheckBiggerNumber(2, 3);
            Console.WriteLine("The bigger number is: " + biggest);
            Console.WriteLine("String compare: " + op.StringCompare("FastTrackIt"));
            Console.WriteLine("String and number compare: " + op.StringAndNumberCompare("FastTrackIT", 3));
            Console.WriteLine("Snow amount: " + op.SnowAmount(4));
            Console.WriteLine("Compare 3, 4: " + op.Compare34(1));
            op.SwitchCase(3);
            Console.WriteLine("Even number? : " + op.isNumberEven(60));
            Console.WriteLine("Vote eligible: " + op.isEligibleToVote(10));
            Console.WriteLine("Biggest number: " + op.biggestNumber(8, 9, 8));

            Console.WriteLine();
            Console.WriteLine("C# For Loops");
            Console.WriteLine("Exercise1");
            op.to100(80);
            Console.WriteLine("Exercise2");
            op.toNegative100(10);
            Console.WriteLine("Exercise3");
            op.count(10, 20);
            Console.WriteLine("Exercise4");
            op.compareAndCount(8, 2);
            Console.WriteLine("Exercise5");
            op.oneTo100Even();
            Console.WriteLine("Exercise6");
            op.oneTo100Odd();
            Console.WriteLine("Exercise7: " + op.sumNumbersTo100a(98));
            Console.WriteLine("Exercise8: " + op.sumNumbersTo100b(98));
            Console.WriteLine("Exercise9");
            op.design();

            Console.WriteLine();
            Console.WriteLine("C# While Loops");
            Console.WriteLine("Exercise1");
            op.whileTo100(80);
            Console.WriteLine("Exercise2");
            op.whileTo100Negative(2);
            Console.WriteLine("Exercise3");
            op.whileCount(5, 2);
            Console.WriteLine("Exercise4");
            op.whileCountandCompare(8, 15);
            Console.WriteLine("Exercise5");
            op.whileEvenNumbers();
            Console.WriteLine("Exercise6");
            op.whileOddNumbers();
            Console.WriteLine("Exercise7");
            op.whileSum();
            Console.WriteLine("Exercise8: " + op.divizible7Median(3, 21));
            Console.WriteLine("Exercise9:");
            op.first20Fib();
            Console.WriteLine("Exercise10:");
            op.cozaLozaWoza();

            Console.WriteLine();
            Console.WriteLine("C# Arrays");
            int[] arr = new int[100];
            op.addToArray(arr);

            int[] emptyArr = new int[100];
            int[] emptyArr2;
            emptyArr2 = op.addToEmptyArray(emptyArr);
            Console.WriteLine(emptyArr2[5]);

            int[] emptyArr3;
            emptyArr3 = op.findNumberInArray(arr, 1);
            Console.WriteLine("array without number: " + emptyArr3[0]);

            Console.WriteLine("almost the smallest: " + op.almostTheSmallest(emptyArr3));

            int[] emptyArr4 = new int[100];
            op.copyArray(emptyArr4, emptyArr3);
            for(int i = 0; i < emptyArr4.Length; i++)
            {
                Console.Write(emptyArr4[i] + " ");
            }
        }

        public static void PrintCSharp()
        {
            Console.WriteLine("       C C C         /        /\n    C          -----/--------/-----\n    C              /        / \n    C             /        /\n    C        ----/--------/-----\n       C C C    /        /");
        }

        public static void Circle(double r)
        {
            double area = r * r * Math.PI;
            double length = 2 * r * Math.PI;

            Console.WriteLine(length);
            Console.WriteLine(area);
        }
         
        public static void Speed(float meters, int hours, int minutes, int seconds)
        {
            float time = hours * 3600 + minutes * 60 * seconds;
            float metersPerSec = meters / time;
            float kmPerHour = metersPerSec * 3.6f;
            float milesPerHour = kmPerHour / 1.609f;

            Console.WriteLine(metersPerSec);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(milesPerHour);
        }

        public static double InchToMeters(double a)
        {
            return a * 0.0254;
        }

        public static float FtoC(float a)
        {
            return (a - 32) * 5 / 9;
        }

        public static void PrintName()
        {
            Console.WriteLine("Hello \nAntonia!");
        }

        public static void PrintSum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void PrintDivision(double a, double b)
        {
            Console.WriteLine(a / b);
        }

        public static void Result1()
        {
            Console.WriteLine(-5 + 8 * 6);
        }

        public static void Result2()
        {
            Console.WriteLine((55 + 9) % 9);
        }

        public static void Result3()
        {
            Console.WriteLine(20 + -3 * 5 / 8);
        }

        public static void Result4()
        {
            Console.WriteLine(5 + 15 / 3 * 2 - 8 % 3);
        }
    }

    public class Calculator
    {
        public float ArithmeticMedian(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }
        public float ArithmeticMedian(int a, int b, int c, int d)
        {
            return (a + b + c + d) / 4;
        }
        public double ArithmeticMedian(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }
        public int Modulo(int a, int b)
        {
            return a % b;
        }
        public double Modulo(double a, double b)
        {
            return a % b;
        }
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        public float Sum(float a, float b)
        {
            return a + b;
        }
        public float Sum(float a, float b, float c)
        {
            return a + b + c;
        }
        public double Subtraction(double a, double b)
        {
            return a - b;
        }
        public float Subtraction(float a, float b, float c)
        {
            return a - b - c;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public double Multiplication(int a, int b)
        {
            return a * b;
        }
        public double Multiplication(float a, float b)
        {
            return a * b;
        }
        public double Multiplication(float a, float b, float c)
        {
            return a * b * c;
        }
        public double Division(double a, double b)
        {
            return a / b;
        }
        public float Division(float a, float b, float c)
        {
            return a / b / c;
        }
        public double Division(double a, double b, double c)
        {
            return a / b / c;
        }
    }

    public class LogicalOp
    {
        public int CheckBiggerNumber(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public string StringCompare(string str)
        {
            if (str.Equals("FastTrackIT"))
            {
                return "Learning text comparison";
            }
            else
            {
                return "Got to try some more";
            }
        }

        public string StringAndNumberCompare(string str, int num)
        {
            if (str.Equals("FastTrackIT") && num <= 3)
            {
                return str + num;
            }
            else if (str.Equals("FastTrackIT") && num >= 4)
            {
                return num.ToString() + str;
            }
            return "Something's not right!";
        }

        public string SnowAmount(int num)
        {
            if (num > 8 || num == 6)
            {
                return $"The amount of snow this winter was {num} cm";
            }
            else
            {
                return $"The forecast snow is cm: {num}";
            }
        }

        public string Compare34(int num)
        {
            if (num > 3 && num != 4)
            {
                return "The number is greater than 3 and not equal to 4";
            }
            else if (num == 4)
            {
                return "The number is equal to 4";
            }
            return "The number is lower than 3";
        }

        public void SwitchCase(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("The number is:  1 !");
                    break;
                case 2:
                    Console.WriteLine("The number is:  2 !");
                    break;
                case 3:
                    Console.WriteLine("The number is:  3 !");
                    break;
                case 4:
                    Console.WriteLine("The number is:  4 !");
                    break;
                case 5:
                    Console.WriteLine("The number is:  5 !");
                    break;
                case 6:
                    Console.WriteLine("The number is:  6 !");
                    break;
                default:
                    Console.WriteLine("The number is:  infinity ?!");
                    break;
            }
        }

        public bool isNumberEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isEligibleToVote(int num)
        {
            if (num >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int biggestNumber(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        //C# for loops
        public void to100(int n)
        {
            for (int i = n; i <= 100; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void toNegative100(int n)
        {
            for (int i = n; i >= -100; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void count(int x, int y)
        {
            for (int i = x; i <= y; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public void compareAndCount(int x, int y)
        {
            if (x > y)
            {
                for (int i = y; i <= x; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = x; i <= y; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

        public void oneTo100Even()
        {
            for (int i = 2; i <= 100; i = i + 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void oneTo100Odd()
        {
            for (int i = 1; i <= 100; i = i + 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public int sumNumbersTo100a(int n)
        {
            int s = 0;
            for (int i = n; i <= 100; i++)
            {
                s += i;
            }
            return s;
        }

        public int sumNumbersTo100b(int n)
        {
            int s = 0;

            for (int i = n; i <= 100; i++)

                s += i;

            return s/(100-n+1);
        }

        public void design()
        {
            int count;
            int asterisk;
            int nos;

            for (count = 7; count >= 1; count--)
            {
                nos = count;
                for (asterisk = count; asterisk > 1; asterisk--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        //C# while loops

        public void whileTo100(int n)
        {
            while (n <= 100)
            {
                Console.Write(n + " ");
                n++;
            }
            Console.WriteLine();
        }

        public void whileTo100Negative(int n)
        {
            while (n >= -100)
            {
                Console.Write(n + " ");
                n--;
            }
            Console.WriteLine();
        }

        public void whileCount(int x, int y)
        {
            while (x <= y)
            {
                Console.Write(x + " ");
                x++;
            }
            while (x >= y)
            {
                Console.Write(x + " ");
                x--;
            }
            Console.WriteLine();
        }

        public void whileCountandCompare(int x, int y)
        {
            if(x < y)
            {
                while (x <= y)
                {
                    Console.Write(x + " ");
                    x++;
                }
            } else { 
                while (x >= y)
                {
                    Console.Write(y + " ");
                    y++;
                }
            }
            Console.WriteLine();
        }

        public void whileEvenNumbers()
        {
           int i = 2;
           while (i <= 100) {
                Console.Write( i + " ");
                i = i +2;
            }
            Console.WriteLine();
        }
        public void whileOddNumbers()
        {
            int i = 1;
            while (i <= 100)
            {
                Console.Write(i + " ");
                i = i + 2;
            }
            Console.WriteLine();
        }

        public void whileSum()
        {
            int x = 111;
            int y = 8899;
            float count = 0;
            float sum = 0;

            while (x <= y)
            {
                count = count + 1;
                sum = sum + x;
                x++;
            }

            Console.WriteLine("Suma este " + sum);
            float med = sum / count;
            Console.WriteLine("Media este " + med);
        }

        public float divizible7Median(int a, int b)
        {
            float sum = 0;
            float count = 0;
            if (a < b)
            {
                while (a <= b)
                {
                    if(a % 7 == 0)
                    {
                        sum = sum + a;
                        count++;
                    }
                    a++;
                }
            }
            else
            {
                while(a >= b)
                {
                    if (a % 7 == 0)
                    {
                        sum = sum + a;
                        count++;
                    }
                    a--;
                }
            }
            return sum / count;
        }

        public void first20Fib()
        {
            int fn;
            int f0 = 0;
            int f1 = 1;
            int i = 0;
            Console.Write(f0.ToString() + " " + f1.ToString() + " ");

            while (i < 20)
            {
                fn = f0 + f1;
                f0 = f1;
                f1 = fn;
                Console.Write(fn + " ");
                i++;
            }
            Console.WriteLine();
        }

        public void cozaLozaWoza()
        {
            int i = 1;
            while (i <= 110)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Coza ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Loza ");
                }
                else if (i % 7 == 0)
                {
                    Console.Write("Woza ");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("CozaLoza ");
                }
                else if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.Write("CozaWoza ");
                }
                else if (i % 5 == 0 && i % 7 == 0)
                {
                    Console.Write("WozaLoza ");
                }
                else
                {
                    Console.Write(i + " ");
                }
                if (i % 11 == 0)
                {
                    Console.WriteLine();
                }
                i++;
            }
        }

        public void addToArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
                Console.Write(i + 1 + " ");
            }
            Console.WriteLine();
        }

        public int[] addToEmptyArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(i % 2 == 0)
                {
                    arr[i] = i;
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            return arr;
        }
        public int arrayNumMedian(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum / arr.Length;
        }
        public bool findStringInArray(string[] arr, string str)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (str.Equals(arr[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public int findPosInArray(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(num == arr[i])
                {
                    return i;
                }
            }
            return -1;
        }
        public void printGrill(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; i < arr.Length; i++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine();
            }
        }
        public int[] findNumberInArray(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (num == arr[i])
                {
                    for(int j = i; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    return arr;
                }
            }
            return null;
        }
        public int almostTheSmallest(int[] arr)
        {
            int[] newArr = findNumberInArray(arr, arr.Min());
            return newArr.Min();
        }
        public void copyArray(int[] arrEmpty, int[] arrFull)
        {
            for(int i = 0; i < arrFull.Length; i++)
            {
                arrEmpty[i] = arrFull[i];
            }
        }
    }
}
