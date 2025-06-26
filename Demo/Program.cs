using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    internal class Program
    {


        static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }

        static void TestPrint()
        {
            Print(10);
            Print<int>(10);
            Print("Mariam");
            Print(true);

        }
        static void PrintObj(object obj)
        { 
         Console.WriteLine(obj);

        }


        static void TestPrintobj()
        {
            PrintObj(10); //Boxing
            PrintObj("Maraim");
            PrintObj(10.5);

        }




        static void Main(string[] args)
        {
            //Test Demo Commit

            #region Object
            #region Intro
            //Object obj;
            //obj = 100;
            //obj = "100";
            //obj = "Mariam";
            //int result = 10 + (int)obj;

            #endregion

            #region ToString
            //Point P1 = new Point() { x = 1, y = 2 };
            ////Console.WriteLine(P1.ToString()); //SessionThree.Point
            //int X = 1234;
            ////Console.WriteLine(X.ToString()); //1234
            //object Num = 1234;
            ////Console.WriteLine(Num.ToString()); //1234
            ////Call ToString object
            ////Call back ToString Int32

            //object Name = "Mariam";
            //Console.WriteLine(Name. ToString());


            #endregion





            #region Equals
            //Point P1 = new Point() { x = 1, y = 2 };
            //Point P2 = new Point() { x = 1, y = 2 };
            //P1 = P2;
            //Console.WriteLine(P1.Equals(P2)); // True

            //int X = 1234;
            //int Y = 12345;
            //Console.WriteLine(X.Equals(Y))I//False

            //string n = "Mariam", m = "Mariam";
            //object Name = "Mariam";
            //object Name2 = "mariam";
            //Console.WriteLine(Name.Equals(Name2));




            #endregion


            #region GetHashCode
            //Point P1 = new Point() { x = 1, y = 2 };
            //Point P2 = new Point() { x = 1, y = 2 };
            //P1 = P2;
            //Console.WriteLine(P1.GetHashCode());
            //Console.WriteLine(P2.GetHashCode());

            //int X = 1234;
            //int Y = 1234;
            //Console.WriteLine(X.GetHashCode());
            //Console.WriteLine(Y.GetHashCode());

            //object Num = 1234;
            //Console.WriteLine(Num.GetHashCode());

            //object Name = "Mariam";
            //object Name1 = "Mariam";
            //Console.WriteLine(Name.GetHashCode());
            //Console.WriteLine(Name1.GetHashCode());





            #endregion

            #region GetType
            //Point P1 = new Point() { x = 1, y = 2 };
            //Console.WriteLine(P1.GetType());
            //object Name = "Mariam";
            //Console.WriteLine(Name.GetType());
            //int X = 1234;
            //Console.WriteLine(X.GetType());
            //object Num = 1234;
            //Console.WriteLine(Num.GetType());


            #endregion

            #region Example
            //object obj = new object();
            ////Reference refer null
            ////Refer any instance of object or any data type that inhiret from object
            //obj = 100; //Boxing
            //obj = "Mariam";
            //obj = 100.5;
            //double S = (double)obj; // unboxing
            #endregion



            #endregion

            #region Fraction & Discard
            //12.34563208329382903820
            //float number = 12.345678910F;
            //Console.WriteLine(number);
            //float number2 = 10;
            //Console.WriteLine(number2);

            //decimal number = 123.4567m;
            //Console.WriteLine(number);
            //decimal number = 10;
            //Console.WriteLine(number);


            //float result = 3.0F / 2;
            //Console.WriteLine(result);

            //double number = 12.3456;
            //Console.WriteLine(number);

            //Discard , Digit seprator C# 7.0 Feature[]
            //int number = 1000_000_000;
            //Console.WriteLine(number);

            //int. TryParse(Console. ReadLine(), out _);


            //int number = 100000000;
            //Console.WriteLine(number);
            //Console.WriteLine($"{number:c}");

            //CultureInfo cultureInfo = new CultureInfo("ar-SA");
            //Console.WriteLine(number.ToString("c", cultureInfo);




            #endregion



            #region Implicit and explicit casting

            //Impilict casting [Safe casting]
            //int x = 1000; //4 bytes
            //long y; // 8 bytes
            //y = x;//Safe
            //Console.WriteLine(y);

            //Explicit casting [Unsafe casting]
            //long x = 100000000000000;
            //int y = (int)x;
            //Console.WriteLine(y);
            //Arthmetic overflow

            //checked
            //{ 
            //    long x = 100000000000;
            //   int y = (int)x;
            //    unchecked
            //    {
            //        Console.WriteLine(y);
            //    }
            //}


            //long x = 1000;
            //if (x > int.MaxValue || x < int.MinValue)
            //{
            //    Console.WriteLine("An exception happened");
            //}
            //else
            //{
            //    int y = (int)x;
            //    Console.WriteLine(y);
            //}


            //object num = 12348888888888885;
            //if (num.GetType() == typeof(int))
            //{

            //    int y = (int)num;
            //    Console.WriteLine(y);
            //}
            //else
            //{

            //    Console.WriteLine("Number is large");
            //}



            #endregion

            #region Ex 2 [int - float]
            //Implicit int == > float
            //int x = 10;
            //float y = x; //implicit casting [safe]
            //Console.WriteLine(y);

            ////Explicit casting float == > int
            //float x=12.55f;
            //int y = (int) x;
            //Console.WriteLine(y); //unsafe [loss of data]

            #endregion




            #region Casting [Convert - Parse- TryParse]
            //Ex : Enter name , age , salary
            //Console.WriteLine("Please enter your data");
            //Console.WriteLine("Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Salary");
            //double salary = Convert.ToDouble(Console.ReadLine());
            //Console.Clear();
            //Console.Beep(100, 120);
            //Console.WriteLine($"Name = {name}");
            //Console.WriteLine($"Age = {age}");
            //Console.WriteLine($"Salary = {salary}");


            //Console.WriteLine("Please enter your data");
            //Console.WriteLine("Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Age");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Salary");
            //double salary = Double. Parse(Console. ReadLine());
            //Console.Clear();
            //Console. WriteLine($"Name = {name}");
            //Console.WriteLine($"Age = {age}");
            //Console.WriteLine($"Salary = {salary}"


            //Console.WriteLine("Please enter your data");
            //Console.WriteLine("Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Age");
            //int age;
            //bool isAgeParsed = int.TryParse(Console.ReadLine(), out age);
            //Console.WriteLine("Salary");
            //bool isSalaryParsed = Double.TryParse(Console.ReadLine(), out double salary);
            //Console.Clear();
            //Console.WriteLine($"Name = {name}");
            //Console.WriteLine($"isAgeParsed = {isAgeParsed}");
            //Console.WriteLine($"Age = {age}");
            //Console.WriteLine($"isSalaryParsed = {isSalaryParsed}");
            //Console.WriteLine($"Salary = {salary}");

            //Class member method , Object member method


            #endregion


























        }
    }
}
