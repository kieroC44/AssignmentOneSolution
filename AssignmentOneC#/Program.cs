namespace AssignmentOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 
            /*
             * Ask user for salary amount and print:    
             * "No tax" if < 5000 , and the salary stays the same.
             * "10% tax" if between 5000–9999 ,  subtract 10% tax.
             * "20% tax" if ≥ 10000 ,  subtract 20% tax.
             * Expected output : 
             * ==> 10% tax applied  
             * ==> Final salary after tax 
             */



            //            double salary;
            //            Console.Write("Enter your salary: ");
            //            salary = double.Parse(Console.ReadLine());

            //            double tax = 0;

            //            if (salary < 5000)
            //            {
            //                Console.WriteLine("No tax applied");
            //            }
            //            else if (salary >= 5000 && salary <= 9999)
            //            {
            //                tax = salary * 0.10;
            //                salary -= tax;
            //                Console.WriteLine(" 10% tax applied");
            //            }
            //            else if (salary >= 10000)
            //            {
            //                tax = salary * 0.20;
            //                salary -= tax;
            //                Console.WriteLine(" 20% tax applied");
            //            }

            //            Console.WriteLine(" Final salary after tax = " + salary);
            //        }
            //    }



            //}



            #endregion

            #region 1-	Write a program that allows the user to enter a number then print it.




            //int number;
            //Console.Write("Enter a number: ");
            //number = int.Parse(Console.ReadLine());
            //Console.WriteLine("The number you entered is: " + number);



            #endregion

            #region 2-	Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 




            //Console.Write("Enter a Value: ");
            //string x = (Console.ReadLine());
            //try
            //{
            //    int result = int.Parse(x);
            //    Console.WriteLine(result);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Cannot convert string with non-numeric characters to integer.");
            //}


            //A FormatException will be thrown at runtime because the string contains non-numeric characters, and int.Parse can only convert fully numeric strings.















            #endregion

            #region 3 -    Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //float a = 5.7f, b = 2.3f;
            //float Value = a + b;
            //Console.WriteLine("Result: " + Value);
            ////No Error will occur, and the output will be the sum of the two floating-point numbers.

            #endregion

            #region 4-	Write C# program that Extract a substring from a given string.
            //string text = "Welcome For The First Assigenment";
            //string sub = text.Substring(15, 7);
            //Console.WriteLine("The Substring: " + sub);

            #endregion

            #region 5-     Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            // int x = 5;
            // int y = x;
            // y = 10;
            // Console.WriteLine($"x = {x}, y = {y}");
            // //The output will be "x = 5, y = 10".
            //// modifying 'y' does not affect 'x'.
            #endregion

            #region 6-	 Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //int[] a = { 1, 2, 3 };
            //int[] b = a;
            //b[0] = 10;
            //Console.WriteLine($"a[0] = {a[0]}, b[0] = {b[0]}");

            #endregion

            #region 7-	Write C# program that take two string variables and print them as one variable 
            //string x = "Welcome";
            //string y = "To Ass_1";
            //string result = x + " " + y;
            //Console.WriteLine(result);

            #endregion

            #region 8-	Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.
            //double principal = 10000, rate = 10, time = 3;
            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine("Value Of Interest: " + interest);


            #endregion

            #region 9-	Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)

            //double weight = 60, height = 1.85;
            //double bmi = weight / (height * height);
            //Console.WriteLine("BMI Equal: " + bmi);

            #endregion

            #region 10-	Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Ex:
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001
            //int day, month, year;
            //Console.Write("Enter day: ");
            //day = int.Parse(Console.ReadLine());
            //Console.Write("Enter month: ");
            //month = int.Parse(Console.ReadLine());
            //Console.Write("Enter year: ");
            //year = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Today's date: {day} , {month} , {year}");
            //Console.WriteLine($"Today's date: {day} – {month} – {year}");
            //Console.WriteLine($"Today's date: {day} / {month} / {year}");



            #endregion

            #region 11-	 What is the output of the following C# code?
            /*  
             DateTime date = new DateTime(2024, 6, 14);
             Console.WriteLine($"The event is on {date:MM/dd/yyyy}");*/

            //The event is on 06/14/2024



            #endregion

            #region 12-	Which of the following statements is correct about the C#.NET code snippet given below?
            /*
             * int d; 
             * d = Convert.ToInt32( !(30 < 20) );
             */
            //f)A value 1 will be assigned to d.
            #endregion

            #region 13-	Which of the following is the correct output for the C# code given below?
            /*Console.WriteLine(13 / 2 + " " + 13 % 2); */

            #endregion

        }
    }
}


