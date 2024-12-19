using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Assigment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1.Write a program that allows the user to enter a number then print it.
            //int num;
            //bool flag;
            //do
            //{
            //    Console.Write("enter your number :");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //} while (!flag);
            //Console.WriteLine(num);
            #endregion

           


         

            #region q3C# Program to Perform Arithmetic Operations with Floating-Point Numbers
            //float num1 = 20.6f;
            //float num2 = 15.5f;
            //float sum = num1 + num2;//20.6 + 15.5
            //float sub = num1 - num2;//20.6-15-5
            //float multi = num1 * num2;//20.6 *15-5
            //float division = num1 / num2;//20.6 /15-5
            //Console.WriteLine("sum="+sum );
            //Console.WriteLine("sub="+sub);
            //Console.WriteLine("multi =" + multi);
            //Console.WriteLine("division=" + division);


            #endregion


            #region Q5
            // int x = 20;
            // Console.WriteLine(x);//
            // int y = x;//Assign the value of x to y
            // Console.WriteLine(y);
            //Console.WriteLine("===========================");
            // x = 10;//modify
            // Console.WriteLine(x);//x =10
            // Console.WriteLine(y);//y=20 not effect because value type

            #endregion




            #region q6


            #endregion

            #region q6
            //point p1 = new point();//reference in stack 4byte
            //Console.WriteLine(p1.x);//0 in heap
            //Console.WriteLine(p1.y);//0in heap
            //point p2 = p1;//reference in stack 4byte
            //Console.WriteLine(p2.x);//0 in heap
            //Console.WriteLine(p2.y);//0 in heap
            //Console.WriteLine("============================================");
            //p1.x =10 ;//assign object
            //Console.WriteLine(p1.x);//10
            //Console.WriteLine(p2.x);//10

            #endregion

            #region q7
            //Console.Write("enter your first name :");
            //string name = Console.ReadLine();
            //Console.Write("enter your last name :");
            //string name2= Console.ReadLine();
            //Console.WriteLine("=============");
            //string message = $"full name : {name  +  name2} ";
            //Console.Write(message);
            #endregion

            #region q8
            //Console.WriteLine("enter the principal amount:");
            //double principal=double.Parse(Console.ReadLine());

            //Console.WriteLine("enter the rate of interest:");
            //double rate=double.Parse(Console.ReadLine());

            //Console.WriteLine("enter the time:");
            //double time=double.Parse(Console.ReadLine());

            //string message = $"interst= {principal}*{rate}*{time}/100 ={principal*rate*time/100}";
            //Console.WriteLine(message);
            #endregion

            #region 9
            //Console.WriteLine("Enter your weight in kilograms: ");
            //double weight = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your height in meters: ");
            //double height = double.Parse(Console.ReadLine());
            //string message=$"BMI= {weight}/{height}*{height}={weight/height*height}";
            //Console.WriteLine(message);
            #endregion

            #region q10
            //Console.Write("Enter the temperature :");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num < 10 ? "Just Cold " : num > 30 ? "Just Hot" : "just good");






            #endregion

            #region q11
            //Console.Write("enter day:");
            //int day =int.Parse(Console.ReadLine());
            //Console.Write("month:");
            //int month = int.Parse(Console.ReadLine());
            //Console.Write("year:");
            //int year = int.Parse(Console.ReadLine());
            //string message = $"enter date:{day},{month},{year}";
            //string message2 = $"enter date:{day}/{month}/{year}";
            //string message3= $"enter date:{day}_{month}_{year}";
            //Console.WriteLine(message);
            //Console.WriteLine(message2);
            //Console.WriteLine(message3);      

            #endregion

            #region 12
            //Console.WriteLine("enter number");
            //int num=int.Parse(Console.ReadLine());
            //if (num %3==0 && num%4==0 )
            //{
            //    Console.WriteLine("yes");
            //}
            //    else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion

            #region q13
            //Console.WriteLine("enter an integer:");
            //int num =int.Parse(Console.ReadLine());
            //if (num <0 )
            //{
            //    Console.WriteLine("negative");
            //}
            //  else
            //{
            //    Console.WriteLine("positive");
            //}
            #endregion

            #region q14
            //Console.WriteLine("enter first integer:");
            //int num1=int.Parse(Console.ReadLine());

            //Console.WriteLine("enter second integer:");
            //int num2=int.Parse(Console.ReadLine());

            //Console.WriteLine("enter third number:");
            //int num3=int.Parse(Console.ReadLine());

            //int max = num1;
            //int min = num1;
            //if(num2>max)
            //{
            //    max = num2;
            //}
            // if(num3>max)
            //{
            //    max = num3;
            //}
            // if (num2<min)
            //{
            //    min = num2;
            //}
            // if(num3<min)
            //{
            //    min = num3;
            //}
            //    Console.WriteLine($"the maximum elementis:{max}");
            //    Console.WriteLine($"the manimum elementis:{min}");

            #endregion

            #region q 14
            //Console.WriteLine("enter number:");
            //int num=int.Parse(Console.ReadLine());
            //if(num%2==0)
            //{
            //    Console.WriteLine("the number is even");

            //}
            //else
            //{
            //    Console.WriteLine("the number is odd");
            //}
            #endregion

            #region q15
            //Console.WriteLine("enter a char:");
            //string character = Console.ReadLine();
            //if (character == "a"||character == "e" ||character== "i"||character== "o"||character== "u")
            //{
            //    Console.WriteLine("vowel");

            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}



            #endregion

            #region q16


            //Console.Write("enter number of month :");
            //int num = int.Parse(Console.ReadLine());
            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("31");
            //        break;
            //    case 2:
            //        Console.WriteLine("28");
            //        break;
            //    case 3:
            //        Console.WriteLine("31");
            //        break;
            //    case 4:
            //        Console.WriteLine("30");
            //        break;
            //    case 5:
            //        Console.WriteLine("31");
            //        break;
            //    case 6:
            //        Console.WriteLine("30");
            //        break;
            //    case 7:
            //        Console.WriteLine("31");
            //        break;
            //    case 8:
            //        Console.WriteLine("31");
            //        break;
            //    case 9:
            //        Console.WriteLine("30");
            //        break;
            //    case 10:
            //        Console.WriteLine("31");
            //        break;
            //    case 11:
            //        Console.WriteLine("30");
            //        break;
            //    case 12:
            //        Console.WriteLine("31");
            //        break;
            //    default:
            //        Console.WriteLine("this is not the number of month");
            //        break;









            //}
            #endregion

         

            #region q 18
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());


            //if (number < 1)
            //{
            //    Console.WriteLine("Please enter a number greater than or equal to 1.");
            //}
            //else
            //{

            //    Console.WriteLine($"Numbers from 1 to {number}:");
            //}
            //    for (int i = 1; i <= number; i++)
            //    {
            //        Console.WriteLine(i);
            //    }


                #endregion

                #region q19
                //Console.Write("Enter an integer to get the multiplication table: ");
                //int number = int.Parse(Console.ReadLine());


                //Console.WriteLine($"Multiplication Table for {number}:");
                //for (int i = 1; i <= 12; i++)
                //{

                //    int result = number * i;
                //    Console.WriteLine($"{number} x {i} = {result}");
                //}


                #endregion

                #region 25
                //int[] arr = { 1, 2, 3, 4, 5, 6 };
                //int sum = 0;
                //for (int i = 0; i < arr.Length; i++)
                //{
                //    sum += arr[i];
                //}
                //Console.WriteLine(sum);
                #endregion
                        
    }   }
}
