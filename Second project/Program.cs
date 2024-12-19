using System;
using System.ComponentModel;
using System.Drawing;

namespace Second_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Write a program that allows the user to enter a number then print it.
            /*
            Console.WriteLine("Enter Number:");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine(num);
            Console.ReadLine();
            */

            /*
                        bool flag;
                        int num;
                        do
                        {
                            Console.WriteLine("Enter Number:");
                            flag = int.TryParse(Console.ReadLine(),out num);
                            Console.Clear();    
                            Console.WriteLine(num);

                        }
                        while (!flag);
            */
            #endregion

            #region 2.Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 


            /*
           //>>>>in this case , the output will be 0 always.
            bool flag;
            int num;
            do
            {
                Console.WriteLine("Enter Text:");
                flag = int.TryParse(Console.ReadLine(), out num);
                Console.WriteLine(num);

            }
            while (!flag);
            */
            /*
            //>>>>in this case , it will give an error
            int num;
            Console.WriteLine("Enter Text:");
            num = int.Parse(Console.ReadLine());
            */


            #endregion

            #region  3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            /*
            //>>it will work correctly if i use flaot casting
            Console.WriteLine("Enter 2 Number:");
           float num1 =float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float res=num1+ num2;
            Console.WriteLine(res);
            Console.ReadLine();
            */
            #endregion


            #region  4.Write C# program that Extract a substring from a given string.
            /*
            string String = "Assignment 02";
            string SubString = String.Substring(10);
            Console.WriteLine($"Substring = {SubString}");
            Console.ReadLine();
            */
            #endregion

            #region 5.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            /*
            //>>>> the value of modifying variable will be changed (the value of Y will be equal to X value but not the address )
            int x;
            x = 5;
            int y = 10;
            y = x;
            Console.Write("Y = ");
            Console.WriteLine(y);
            Console.Write("X = ");
            Console.WriteLine(x);
            Console.ReadLine();
            */
            #endregion

            #region 6.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            /*
            //>>>> the value and address of  P2 will be the same as P1 if p2=p1
            Point p1 = new Point();
            p1.x = 1;
            p1.y= 2;

            Point p2 = new Point();
            p2.x = 10;
            p2.y = 20;
            p2 = p1;
            Console.WriteLine("the First Point:");
            Console.Write("P1.X=");
            Console.WriteLine(p1.x);
            Console.Write("P1.Y=");
            Console.WriteLine(p1.y);
            Console.Write("P1 address:");
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine("the second Point:");
            Console.Write("P2.X=");
            Console.WriteLine(p2.x);
            Console.Write("P2.Y=");
            Console.WriteLine(p2.y);
            Console.Write("P2 address:");
            Console.WriteLine(p2.GetHashCode());
            Console.ReadLine();
            */
            #endregion


            #region 7.Write C# program that take two string variables and print them as one variable 
            /*
            string str1 = "Assignment";
            string str2 = "02";

            Console.WriteLine($"{str1} {str2}");
            Console.ReadLine();
            */
            #endregion






            #region 9.Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI isBMI = (Weight) / (Height * Height)
            /*
            Console.WriteLine("Enter Your Weight :");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Height :");
            float Height = float.Parse(Console.ReadLine());
            Console.Write("BMI=");
            float res = (weight) / (Height * Height);
            Console.WriteLine(res);
            Console.ReadLine();
            */
            #endregion

            #region 10.Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".
            /*
            float temp;
            string res;
            Console.WriteLine("Enter temperature:");
            temp= float.Parse(Console.ReadLine());
            res = (temp < 10) ? "Just Cold" : (temp > 30) ? "Just Hot" : "Just Good";
            Console.WriteLine(res);
            Console.ReadLine();
            */
            #endregion


            #region 11.Write a program that takes the date from the user and displays it in various formats using string interpolation.
            /*
             DateTime dateTime = DateTime.Now;

             Console.WriteLine($"Today’s date : {dateTime.Day} , {dateTime.Month} , {dateTime.Year}");
             Console.WriteLine($"Today’s date : {dateTime.Day} / {dateTime.Month} / {dateTime.Year}");
             Console.WriteLine($"Today’s date : {dateTime.Day} - {dateTime.Month} - {dateTime.Year}");
            Console.ReadLine();
            */
            #endregion





            #region 13- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            /*
            bool flag;
            int num;
            do
            {
                Console.WriteLine("Enter Number:");
                flag = int.TryParse(Console.ReadLine(), out num);
            }
            while (!flag);
            if (num <0)
                Console.WriteLine("negative");
            else
                Console.WriteLine("positive");
            Console.ReadLine();
            */
            #endregion

            #region 14- Write a program that takes 3 integers from the user then prints the max element and the min element.
            /*
            bool flag1, flag2, flag3;
            int num1,num2,num3;
            do
            {
                Console.WriteLine("Enter 3 Number:");
                flag1 = int.TryParse(Console.ReadLine(), out num1);
                flag2 = int.TryParse(Console.ReadLine(), out num2);
                flag3 = int.TryParse(Console.ReadLine(), out num3);
            }
            while (!(flag1 && flag2 && flag3));

            if (num1 >= num2 && num1 >= num3)
            {
                Console.Write("The Max=");
                Console.WriteLine(num1);
                Console.Write("The Min=");
                if(num3>= num2)
                Console.WriteLine(num2);
                else Console.WriteLine(num3);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.Write("The Max=");
                Console.WriteLine(num2);
                Console.Write("The Min=");
                if (num1>=num3)
                    Console.WriteLine(num3);
                else
                    Console.WriteLine(num1);
            }
            else if(num3>= num2 && num3 >= num1)
            {
                Console.Write("The Max=");
                Console.WriteLine(num3);
                Console.Write("The Min=");
                if (num2 >= num1)
                    Console.WriteLine(num1);
                else
                    Console.WriteLine(num2);
            }
            Console.ReadLine();
            */
            #endregion

            #region 14- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            /*
            bool flag;
            int num;
            do
            {
                Console.WriteLine("Enter Number:");
                flag = int.TryParse(Console.ReadLine(), out num);
            }
            while (!flag);
            if (num % 2 == 0 )
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
            Console.ReadLine();
            */
            #endregion


            
            #region 15- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
         /*
            bool flag;
            char c;
            do
            {
                Console.WriteLine("Enter character:");
                flag = char.TryParse(Console.ReadLine(),out c);
            }
            while(!flag);

            c = char.ToLower(c);

            if (c == 'a'||c=='e'||c=='o'||c=='i'||c=='u')
                Console.WriteLine("vowel");
            else
                Console.WriteLine("Consonant");
            Console.ReadLine();
           */
            #endregion

            #region 16- Write a program to input the month number and print the number of days in that month.
            /*
             bool flag;
             int num;
             do
             {
                 Console.WriteLine("Enter Month Number:");
                 flag = int.TryParse(Console.ReadLine(), out num);
             }
             while (!flag);
             switch (num)
             {
                 case 1:
                     Console.WriteLine("31");
                     break;
                 case 2:
                     Console.WriteLine("28");
                     break;
                 case 3:
                     Console.WriteLine("31");
                     break;
                 case 4:
                     Console.WriteLine("30");
                     break;
                 case 5:
                     Console.WriteLine("31");
                     break;
                 case 6:
                     Console.WriteLine("30");
                     break;
                 case 7:
                     Console.WriteLine("31");
                     break;
                 case 8:
                     Console.WriteLine("31");
                     break;
                 case 9:
                     Console.WriteLine("30");
                     break;

                 case 10:
                     Console.WriteLine("31");
                     break;
                 case 11:
                     Console.WriteLine("30");
                     break;
                 case 12:
                     Console.WriteLine("31");
                     break;
                 default:
                     Console.WriteLine("Invalid month number");
                     break;


             }
             */
            #endregion



            #region 17.Write a program to create a Simple Calculator.
            /*

                bool flag1, flag2;
                float num1, num2;
                string operation;

                do
                {
                    Console.WriteLine("Enter two numbers:");
                    flag1 = float.TryParse(Console.ReadLine(), out num1);
                    flag2 = float.TryParse(Console.ReadLine(), out num2);
                }
                while (!(flag1 && flag2));

                do
                {
                    Console.WriteLine("Enter the operation (+, -, *, /):");
                    operation = Console.ReadLine();
                }
                while (operation != "+" && operation != "-" && operation != "*" && operation != "/");
            float res;
            if (operation == "+")
            {
                res = num1 + num2;
                Console.WriteLine($"Result: {res}");
            }
            else if (operation == "-")
            {
                res = num1 - num2;
                Console.WriteLine($"Result: {res}");
            }
            else if (operation == "*")
            {
                res = num1 * num2;
                Console.WriteLine($"Result: {res}");
            }
            else if (operation == "/")
            {
                
                if (num2 != 0)
                {
                    res=num1/num2;
                    Console.WriteLine($"Result: {res}");
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
            }

            Console.ReadLine();
  
            */
            #endregion

            #region 18.Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            /*
             bool flag;
             int num;
             do
             {
                 Console.WriteLine("Enter Number:");
                 flag = int.TryParse(Console.ReadLine(), out num);
             }
             while (!flag);
             for(int i=1;i<=num;i++)
             {
                 Console.WriteLine(i);
             }
             Console.ReadLine();
            */
            #endregion


            #region 19- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            /*
             bool flag;
             int num;
             do
             {
                 Console.WriteLine("Enter Number:");
                 flag = int.TryParse(Console.ReadLine(), out num);
             }
             while (!flag);

             Console.WriteLine("The Output:");
             for (int i = 1; i <= 12; i++)
             {
                 Console.Write($"{num * i} ");
             }
             Console.ReadLine();
            */
            #endregion

            #region 20- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            /*
            bool flag;
            int num;
            do
            {
                Console.WriteLine("Enter Number:");
                flag = int.TryParse(Console.ReadLine(), out num);
            }
            while (!flag);

            for (int i = 1; i <= num; i++)
            {
                if (i %2 == 0)
                Console.Write($"{i} ");
               
            }
            Console.ReadLine();
            */
            #endregion


            #region 21-Write a program that takes two integers then prints the power.
            /*
            bool flag,flag1;
            int num,num1;
            do
            {
                Console.WriteLine("Enter 2 Number:");
                flag = int.TryParse(Console.ReadLine(), out num);
                flag1 = int.TryParse(Console.ReadLine(), out num1);
            }
            while (!(flag&& flag1));

            int res = 1;
            for (int i = 1; i <= num1; i++)
            {
                res *= num;
            }

            
            Console.WriteLine($"{res}");
            Console.ReadLine();
            */
            #endregion

            #region 22 - Write a program to allow the user to enter int and print the REVERSED of it.
            /*
            bool flag;
            int num;

            do
            {
                Console.WriteLine("Enter number:");
                flag = int.TryParse(Console.ReadLine(), out num);
            }
            while (!flag);

            int rev = 0;
            int temp = Math.Abs(num); 
            while (temp > 0)
            {
                int remainder = temp % 10;
                rev = rev * 10 + remainder;
                temp /= 10;
            }

            if (num < 0)
            {
                rev = -rev;
            }

            
            Console.WriteLine($"{rev}");
            Console.ReadLine();
            */
            #endregion


            #region 23- Write a program in C# Sharp to find prime numbers within a range of numbers.
            /*
            bool flag, flag1;
            int num, num1;
            do
            {
                Console.WriteLine("Enter 2 Number:");
                flag = int.TryParse(Console.ReadLine(), out num);
                flag1 = int.TryParse(Console.ReadLine(), out num1);
            }
            while (!(flag && flag1));
            Console.WriteLine("The prime number between 1 and 50 are :");
            for (int i = num; i <= num1; i++)
            {
                if (i <= 1)
                    continue; 

                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                
                if (isPrime)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }

           

            Console.ReadLine();
            */
            #endregion


            #region 24- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            /*
             bool flag;
             int num;

             do
             {
                 Console.Write("Enter a number to convert : ");
                 flag = int.TryParse(Console.ReadLine(), out num);
             }
             while (!flag);

             string binary = string.Empty;
             int temp = num;
             Console.WriteLine("Expected Output :");
             if (num == 0)
             {
                 binary = "0";
             }
             else
             {
                 while (temp > 0)
                 {
                     binary = (temp % 2) + binary; 
                     temp /= 2;
                 }
             }

             Console.WriteLine($"The Binary of {num} is {binary}");
             Console.ReadLine();
            */
            #endregion


            #region 25- Write a program in C# Sharp to find the sum of all elements of the array.
            /*
             bool flag;
             int size;
             do
             {
                 Console.WriteLine("Enter the size of the array:");
                 flag = int.TryParse(Console.ReadLine(), out size);
             }
             while (!flag || size <= 0);

             int[] numbers = new int[size];


             for (int i = 0; i < size; i++)
             {
                 do
                 {
                     Console.WriteLine($"Enter element {i + 1}:");
                     flag = int.TryParse(Console.ReadLine(), out numbers[i]);
                 }
                 while (!flag);
             }

             int sum = 0;
             foreach (int num in numbers)
             {
                 sum += num;
             }


             Console.WriteLine($"The sum of all elements in the array is: {sum}");
             Console.ReadLine();
            */
            #endregion

        }
    }
}