using System;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{

    internal class Program
    {
        #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
        ////Value Type , Pass By Value
        //public static void SWAP01(int X, int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = X;
        //}
        ////Value Type, Pass By Reference
        //public static void SWAP02(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        #endregion

        #region 2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

        /// Passing By Value 
        ///static int SumArray(int[] array)   // array = Numbers
        ///{
        ///    int sum = 0;
        ///    if (array is not null)
        ///    {
        ///        //array[0] = 100;
        ///        array = [6, 7, 8];
        ///        for (int i = 0; i < array.Length; i++)
        ///            sum += array[i];
        ///    }
        ///    return sum;
        ///}

        /// Passing By Reference
        ///static int SumArray(ref int[] array)   // array = Numbers
        ///{
        ///    int sum = 0;
        ///    if (array is not null)
        ///    {
        ///        //array[0] = 100;
        ///        array = [6, 7, 8];
        ///        for (int i = 0; i < array.Length; i++)
        ///            sum += array[i];
        ///    }
        ///    return sum;
        ///} 

        #endregion

        #region 3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

        //static void SumAndSub (int number01 , int number02 ,int number03 , int number04 , out int sum , out int sub)
        //{
        //     sum = number01 + number02;
        //     sub = number03 - number04;

        //}

        #endregion

        #region  4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.Output should be like Enter a number: 25 The sum of the digits of the number 25 is: 7

        //static int SumNumbers(int number)
        //{
        //    int sum = 0;

        //    while (number != 0)
        //    {
        //        sum += number % 10;
        //        number /= 10;
        //    }

        //    return sum;
        //}

        #endregion

        #region 5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

        //static bool isPrime (int number)
        //{
        //    bool flag;
        //    int i = 2;

        //    if(number == 0 || number == 1) 
        //        return flag = false;
        //    if(number == i)
        //        return flag = true;
        //    if(number % i == 0)
        //        return flag = false;

        //    return flag = true;
        //}

        #endregion

        #region 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

        //static void MinMaxArray(int[] Arr, out int Min, out int Max)
        //{
        //    Min = 0; Max = 0;

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        if(Min > Arr[i])
        //            Min = Arr[i];

        //        if (Max < Arr[i])
        //            Max = Arr[i];
        //    }

        //}

        #endregion

        #region 7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

        //static int GetFactorial (int number)
        //{
        //    int factorial = 1;

        //    while(number > 0)
        //    {
        //        factorial*=number;

        //        number--;
        //    }

        //    return factorial;
        //}

        #endregion



        static void Main()
        {
            #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            ///// Passing (Value Type) By Value : Acts as input Parameters only 
            ///// take a copy of value of A and B then put them in X and Y , Then After swapping the value of A and B is the Same
            ///// because  X and Y has the values and after end of function will be deleted and then A and B is the same 
            //int A = 3;
            //int B = 5;
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //SWAP01(A, B);  // Passing By Value   [Input Parameters ]   SWAP(3,5)
            //Console.WriteLine("**********After Swaping************");

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");


            /////  Passing (Refrence Type) By Value : Acts as input and output Parameters
            ///// sending reference of A and B , in other words ,   they have access on A and B but in name X and Y so any change in X and Y will directly affects A and B
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            //SWAP02(ref A, ref B);// Passing By Ref   [Input Output Parameters]  SWAP(A,B)

            //Console.WriteLine("**********After Swaping************");
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            #endregion

            #region 2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            ///// Passing by Value : in this Example , we will send the address of the array as a parameter 
            ///// and after saying that (array = [6,7,8]) the SumArray in the stack Frame refers to new array ([6,7,8])
            ///// while the numbers array in the main stack frame still the same not changed  
            //int[] numbers = [1, 2, 3, 4, 5];
            //int sum = SumArray(numbers);     // Passing By Value

            //Console.WriteLine(numbers[0]); 

            ///// Passing by Reference : in this Example , it will send the reference of the array (numbers) as a parameter , then the function has access on the numbers array but with name (array)
            ///// so when saying that (array = [6,7,8]) the numbers array will be also changed to the new array
            //int sum = SumArray(ref numbers);     // Passing By reference
            //Console.WriteLine(numbers[0]); 
            #endregion

            #region 3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //int number01,number02, number03,number04;
            //do
            //{
            //    Console.Write("Enter First Number : ");

            //} while (!int.TryParse(Console.ReadLine(),out number01));

            //do
            //{
            //    Console.Write("Enter Second Number : ");

            //} while (!int.TryParse(Console.ReadLine(), out number02));

            //do
            //{
            //    Console.Write("Enter Third Number : ");

            //} while (!int.TryParse(Console.ReadLine(), out number03));

            //do
            //{
            //    Console.Write("Enter Fourth Number : ");

            //} while (!int.TryParse(Console.ReadLine(), out number04));

            //SumAndSub(number01, number02, number03, number04, out int sum, out int sub);

            //Console.WriteLine($"Summation of First Two Numbers  = {sum}");
            //Console.WriteLine($"Subtraction of Second Two Numbers  = {sub}");

            #endregion

            #region 4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.Output should be like Enter a number: 25 The sum of the digits of the number 25 is: 7

            //Console.Write("Please Enter a number: ");

            //int numbers = int.Parse(Console.ReadLine());

            //int sum = SumNumbers(numbers);

            //Console.WriteLine($"The Sum = {sum}");

            #endregion

            #region 5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //Console.WriteLine("Enter any Number : ");
            //int number  = int.Parse(Console.ReadLine());

            //if(isPrime(number))
            //    Console.WriteLine("True");
            //else Console.WriteLine("False");

            #endregion

            #region 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //int[] Arr = [3, 5, 7, 2, 8, -1, 4, 10, 12];


            //MinMaxArray(Arr, out int min, out int max);

            //Console.WriteLine($"Minimum value in the array: {min}");
            //Console.WriteLine($"Maximum value in the array: {max}");

            #endregion

            #region 7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //Console.Write("Please Enter any Number : ");
            //int number = int.Parse(Console.ReadLine());

            //int Result = GetFactorial(number);

            //Console.WriteLine($"Factorial of this number = {Result}");

            #endregion



        }
    }
}
