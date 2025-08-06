using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Assignment_Session04_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q6-Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region Q7-Write a program that allows the user to insert an integer then print a multiplication table up to 12.


            //Console.Write("Enter a number: ");
            //   int number = int.Parse(Console.ReadLine());

            //   for (int i = 1; i <= 12; i++)
            //   {
            //       Console.Write( (number * i) + " ");
            //   }

            #endregion

            #region Q8-Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.Write("Enter a number : ");
            //    int number =int.Parse(Console.ReadLine());
            //Console.WriteLine("Even numbers between 1 and " + number + ":");

            //for (int i = 1; i <= number; i++)
            //{

            //        if (i % 2 == 0)
            //        { 
            //        Console.Write(i + " ");
            //        }


            //}
            #endregion

            #region Q9- Write a program that takes two integers then prints the power.

            //Console.Write("Enter a number 1: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Enter a number 2: ");
            //int number2=int.Parse(Console.ReadLine());

            //double Result = Math.Pow(number1, number2);

            //Console.WriteLine("Result: "+ Result);



            #endregion

            #region Q10-Write a program to enter marks of five subjects and calculate total, average and percentage.

            //int[] subject=new int[5];
            //int total = 0;
            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;

            //Console.WriteLine("Enter marks of five subjects:");

            //for (int i = 0; i <5; i++)
            //{
            //    Console.Write("Subject" + (i+1) + ": ");
            //    subject[i]=int.Parse(Console.ReadLine());
            //    total += subject[i];

            //}

            //Console.WriteLine("\nTotal marks = " + total);
            //Console.WriteLine("Average Marks = " + average);
            //Console.WriteLine("Percentage = " + percentage + "%");

            #endregion

            #region Q11-Write a program to input the month number and print the number of days in that month.

            //Console.Write("input the month number : ");
            //int number=int.Parse(Console.ReadLine());

            //if (number == 1 || number == 3 || number == 5 || number == 7 || number == 8 || number == 10 || number == 12)
            //{
            //    Console.WriteLine("31 days");
            //}
            //else if (number == 4 || number == 6 || number == 9 || number == 11)
            //{
            //    Console.WriteLine("30 days");
            //}
            //else if (number == 2)
            //{
            //    Console.WriteLine("28 or 29 days");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid month number");
            //}
            #endregion

            #region Q12-Write a program to create a Simple Calculator

            //Console.Write("Enter first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter operation (+, -, *, /): ");
            //string operation = Console.ReadLine();

            //double result = 0;

            //if (operation == "+")
            //{
            //    result = num1 + num2;
            //}
            //else if (operation == "-")
            //{
            //    result = num1 - num2;
            //}
            //else if (operation == "*")
            //{
            //    result = num1 * num2;
            //}
            //else if (operation == "/")
            //{
            //    if (num2 != 0)
            //        result = num1 / num2;
            //    else
            //    {
            //        Console.WriteLine("Cannot divide by zero");
            //        return;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operation");
            //    return;
            //}

            //Console.WriteLine("Result = " + result);
            #endregion

            #region Q13-Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //string reversed = "";

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversed += input[i];
            //}

            //Console.WriteLine("Reversed string: " + reversed);
            #endregion

            #region Q14-Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();

            //string reversed = "";

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversed += input[i];
            //}

            //Console.WriteLine("Reversed integer: " + reversed);
            #endregion

            #region Q15- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //    Console.Write("Input starting number of range: ");
            //    int start = int.Parse(Console.ReadLine());

            //    Console.Write("Input ending number of range: ");
            //    int end = int.Parse(Console.ReadLine());

            //    Console.WriteLine("\nThe prime numbers between {0} and {1} are:", start, end);

            //    for (int i = start; i <= end; i++)
            //    {
            //        bool isPrime = true;

            //        if (i <= 1)
            //            continue;

            //        for (int j = 2; j < i; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }

            //        if (isPrime)
            //            Console.Write(i + " ");
            //    }
            //}
            #endregion

            #region Q17-Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.Write("Enter x1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y1: ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter x2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y2: ");
            //double y2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter x3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y3: ");
            //double y3 = double.Parse(Console.ReadLine());

            //double slope1 = (y2 - y1) / (x2 - x1);

            //double slope2 = (y3 - y2) / (x3 - x2);

            //if (slope1 == slope2)
            //    Console.WriteLine("The points lie on the same straight line.");
            //else
            //    Console.WriteLine("The points do NOT lie on the same straight line.");


            #endregion

            #region Q18-Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 

            //    Console.Write("Enter time taken by the worker (in hours): ");
            //    int number = int.Parse(Console.ReadLine());

            //    if (number >= 2 && number <= 3)
            //    {
            //        Console.WriteLine("Highly efficient worker.");
            //    }
            //    else if (number > 3 && number <= 4)
            //    {
            //        Console.WriteLine("Worker should increase speed.");
            //    }
            //    else if (number > 4 && number <= 5)
            //    {
            //        Console.WriteLine("Worker needs training to improve speed.");
            //    }
            //    else if (number > 5)
            //    {
            //        Console.WriteLine("Worker is to be terminated.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Time must be 2 hours or more.");
            //    }

            #endregion

            //
        }
    }

    
}
