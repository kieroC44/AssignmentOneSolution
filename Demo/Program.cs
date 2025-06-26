using System.Drawing;
using System.Xml.Linq;

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

       












        }
    }
}
