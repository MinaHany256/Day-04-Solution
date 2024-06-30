namespace Demo
{
    class Program
    {

        #region Function Prototype and Calling

        ///static void PrintShapes()
        ///{
        ///    for (int i = 1; i <= 10; i++)
        ///    {
        ///        Console.WriteLine("%_%");
        ///    }
        ///}

        ///static void PrintShapes(int Count = 10, string shape = "@_@")
        ///{
        ///    for (int i = 1; i <= Count; i++)
        ///    {
        ///        Console.WriteLine($"{shape}");
        ///    }
        ///} 
        ///

        #endregion

        #region Value Type Parameters
        /// Passing By Value
        ///static void SWAP(int x, int y)
        ///{
        ///    int temp = x;
        ///    x = y;
        ///    y = temp;
        ///}

        ///Passign By Ref
        ///static void SWAP(ref int x, ref int y)
        ///{
        ///    int temp = x;
        ///    x = y;
        ///    y = temp;
        ///} 
        #endregion



        static void Main()
        {

            #region Function Prototype and Calling
            //PrintShapes(5,"#_#");
            //PrintShapes(shape:"*_*",Count:5);
            //PrintShapes(5);

            //Console.WriteLine("Hi\nmina\thany");
            //Console.WriteLine(@"Hi\nmina\thany"); 
            #endregion

            #region Value Type Parameters
            //int A = 3;
            //int B = 5;

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            ////SWAP(A, B); // Passing By Value   [Input Parameters ]
            //            // SWAP(3,5)

            //SWAP( ref A, ref B );   // Passing By Ref   [Input Output Parameters]
            //                        // SWAP(A,B)

            //Console.WriteLine("**********After Swaping************");

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}"); 
            #endregion


        }
    }
}
