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

            Console.WriteLine("");

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

        public int Modulo(int a, int b)
        {
            return a % b;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public double Subtraction(int a, int b)
        {
            return a - b;
        }

        public double Multiplication(int a, int b)
        {
            return a * b;
        }

        public double Division(double a, double b)
        {
            return a / b;
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
            if(str.Equals("FastTrackIT") && num <= 3)
            {
                return str + num;
            }
            else if(str.Equals("FastTrackIT") && num >= 4)
            {
                return num.ToString() + str;
            }
            return "Something's not right!";
        }

        public string SnowAmount(int num)
        {
            if(num > 8 || num == 6)
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
            if(num > 3 && num != 4)
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
            if(num % 2 == 0)
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
            if(num >= 18)
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
            if(a > b && a > c)
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
    }
}
