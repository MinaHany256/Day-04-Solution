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


        }
    }
}
