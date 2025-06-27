using System.Drawing;
using System.Globalization;
using System.Net;
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




            #region Unary Operators
            //// Unary -- > works on one variable , one operand
            //int X = 10;
            //// 1] ++ ,,, x =x + 1 ,, x+= 1 ;
            //[Prefix : Increment then print , Postfix : Print Then increment]
            //Console.WriteLine("Initial Value: " + X); // 10
            //Console.WriteLine("++X: " + ++X); // 11 [Prefix increment]
            //Console.WriteLine("X++: " + X++); // 11 [Postfix increment]
            //Console.WriteLine("Final Value: " + X); // 12

            ////2] -- 
            //[Prefix : Decrement then print , Postfix : Print Then decrement]
            //int Y = 10; //Y = Y - 1 ,, Y -= 1 ;
            //Console.WriteLine("Initial Value: " + Y); // 10
            //Console.WriteLine(" -- Y: " + -- Y); //9 [Prefix decrement]
            //Console.WriteLine("Y --: " + Y -- ); //9 [Postfix decrement]
            //Console.WriteLine("Final Value: " + Y); // 8

            #endregion

            #region Binary / Arthmetic Operators
            //Binary operators -- > between 2 operands / 2 variables
            //int a = 10, b = 5;
            //Console.WriteLine("Addition: " + (a + b));            // 10 + 5 = 15
            //Console.WriteLine("Subtraction: " + (a - b));        //10 - 5 = 5
            //Console.WriteLine("Multiplication: " + (a * b));    //10 * 5 = 50
            //Console.WriteLine("Division: " + (a / b));         //10 / 5 = 2
            //Console.WriteLine("Modulus: " + (a % 3));         // 10 % 3 = 1

            #endregion


            #region Assignment Operators
            // int a = 10;

            // // 1. Simple Assignment
            // a = 10;
            // Console.WriteLine("Simple Assignment: " + a); // 10

            // // 2. Add and Assign [a = a + 5]
            // a += 5;
            // Console.WriteLine("Add and Assign (a += 5): " + a); // 15

            // // 3. Subtract and Assign [a = a -3]
            // a -= 3;
            // Console.WriteLine("Subtract and Assign (a -= 3): " + a); // 12

            // // 4. Multiply and Assign [a = a * 2]
            // //a = a / 2;
            // //a /= 2;
            // a *= 2;
            // Console.WriteLine("Multiply and Assign (a *= 2): " + a); // 24
            //  // 5. Divide and Assign [a = a /2]
            // //a = a / 2;
            //// a /= 2;
            // a /= 2;
            // Console.WriteLine("Divide and Assign (a /= 2): " + a); // 12

            // // 6. Modulus and Assign [a = a % 5] I
            // //a *= 5;
            // a %= 5;
            // Console.WriteLine("Modulus and Assign (a %= 5): " + a); //
            #endregion

            #region Relational Operators [Comparison]
            ////return bool [true , false]

            //int a = 10, b = 5;

            //// Equal to ( == )
            //Console.WriteLine("a == b: " + (a == b)); // false

            //// Not equal to ( != )
            //Console.WriteLine("a != b: " + (a != b)); // true

            //// Greater than (>)
            //Console.WriteLine("a > b: " + (a > b)); // true

            //// Less than (<)
            //Console.WriteLine("a < b: " + (a < b)); // f
            //                                        // Greater than or equal to (>=)
            //Console.WriteLine("a >= b: " + (a >= 'b')); // true

            ////// Less than or equal to ( <= )
            //Console.WriteLine("a <= b: " + (a <= b)); // false
            //#endregion


            //#region Logical Operators
            ////Short circuit

            //bool A = true, B = false;
            //// Logical NOT
            //Console.WriteLine("IA: " + (!A));
            //Console.WriteLine("!B: " + (!B));

            //// Logical AND && [Short Circuit]
            //// true && true == > true
            //// true && false == > false
            //// false && true == > false
            //// false && false == > false
            //Console.WriteLine("B && A: " + (B && A)); // false && true === > false//// !true == > false//// !false == > true




            #endregion

            #region Logical Operators
            //Short circuit

            //bool A = true, B = false;
            //// Logical NOT
            //Console.WriteLine("IA: " + (!A));         // !true == > false
            //Console.WriteLine("!B: " + (!B));            // !false == > true

            //// Logical AND && [Short Circuit]
            //// true && true == > true
            //// true && false == > false
            //// false && true == > false
            //// false && false == > false
            //Console.WriteLine("B && A: " + (B && A)); // false && true === > false

            //// Logical OR || [Short Circuit]
            //// true | | true == > true
            //// true | | false == > true
            //// false || true == > true
            //// false || false == > false
            ////Console.WriteLine("A | | B: " + (A || B)); // true | | false == > true


            #endregion

            #region Bitwise Operators

            //int a = 5; // Binary -- > 0101
            //int b = 3; // Binary -- > 0011

            //// Bitwise AND &
            //// true & true == > true
            //// true & false == > false
            //// false & false == > false
            //// false & true == > false
            //Console.WriteLine("a & b: " + (a & b)); // 1 -- > 0001

            //// Bitwise OR |
            //// true | true == > true
            //// true | false == > true
            //// false | true == > true
            //// false | false == > false
            //Console.WriteLine("a | b: " + (a | b)); // 7 -- > 0111
            //                                        //// Bitwise XOR ^
            ///// 1 ^ 0 == > 1
            ///// 0 ^0 == >0
            ///// 1 ^1 == > 0
            ////Console.WriteLine("a ^ b: " + (a ^ b)); // 6 -- > 0110

            ////// Bitmise NOT
            ////Console.WriteLine(""a: " + (~a)); // -6 ( 2's complement of 5 -- > 1010)

            ////// Left Shift
            ////Console.WriteLine("a << 1: " + (a << 1)); // 10 -- > 1010

            ////// Right Shift
            ////Console.WriteLine("a >> 1: " + (a>>1)); // 2 -- > 0010
            #endregion

            #region Ternary Operators
            //int a = 10, b = 20;
            //string result;
            //// Example : Simple Comparison
            //if (a > b)
            //result = "a is greater";
            //else if (b > a)
            //result = "b is greater";
            //else
            //result = "a equals b";

            //result = (a > b) ? "a is greater" : "b is greater"; 
            //result = (a > b) ? "a is greater" : (b a) ? "b is greater" : "a equals b"; 
            //Console.WriteLine(result); // b is greater
            #endregion

            #region String formating
            //Equation : 10 + 5 = 15
            //int x = 10, y = 5, result = x + y;

            //String interpolation
            //string msg = $"Equation : {x} + {y} = {result}";
            //Console.WriteLine(msg);
            //Console.WriteLine($"Equation : {x} + {y} = {result}");
            //Console.WriteLine(15);
            //Console.WriteLine(true); I

            //Format function
            //string msg = String.Format("Equation : {0} + {1} = {2}",
            //Console.WriteLine(msg);

            //Composite formatting
            //Console.WriteLine("Equation : {0} + {1} = {2}", x,y, result);

            //String Concatenation [+]
            // int x = 10, y = 5, result = x + y;
            // string msg = "Equation" +  ":" +  x + "+" + y + " = " + result;
            //Console.WriteLine(msg);
            //Equation
            //Equation :
            //Equation : 10
            //Equation : 10 +
            //Equation : 10 + 5
            //Equation : 10 + 5 =
            //Equation : 10 + 5 = 15

            //Console.WriteLine("Equation :  " + x + " + " + y + " = " + result );

            //D:\C44 -- Route\02 C#\Session 03\SessionThreeGroupTwoSolution\SessionThree
            //string filePath = "D: \c44 -- Route\02 C#\Session 03\Session";
            ////Console.WriteLine(filePath);

            //string msg = "Mariam \t shindy";
            //Console.WriteLine(msg);

            //File path D:\c4u -- Route\2 C#\Session 02
            #endregion



            #region Conditional statements
            #region Example 1 [Quarter]
            #region If else
            Console.WriteLine("Please enter a month number");
            int monthNo;
            bool flag = int.TryParse(Console.ReadLine(), out monthNo);

            switch (monthNo)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }




            //if (monthNo == 1)
            //    Console.WriteLine("January");
            //else if (monthNo == 2)
            //    Console.WriteLine("February");
            //else if (monthNo == 3)
            //    Console.WriteLine("March");
            //else
            //    Console.WriteLine("Invalid");


            #endregion


            #region Switch

            //Jump [int, constant pattern]
            //jump table / branch table [data structure] will be gene
            //better in the performance
            //must the case be unique
            //will not create here because num of cases little
            /*
            JumpTable:
            [o]->address of Action1
            [1] -> address of Action2
            [2]->address of Action3

                */



            #endregion



            #endregion
            #endregion






        }
    }
}
