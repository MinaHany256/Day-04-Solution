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

        #region Reference Type Parameters

        #region Example01
        /// Passing By Value 
        ///static int SumArray(int[] array)   // array = Numbers
        ///{
        ///    int sum = 0;
        ///    if (array is not null)
        ///    {
        ///        array[0] = 100;
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
        ///        array[0] = 100;
        ///        for (int i = 0; i < array.Length; i++)
        ///            sum += array[i];
        ///    }
        ///    return sum;
        ///} 
        #endregion

        #region Example02
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

        #endregion

        #region Passing By Out
        //static void SumMul(int X, int Y, out int sum, out int mul)
        //{
        //    sum = X + Y;
        //    mul = X * Y;
        //} 
        #endregion

        #region Params
        //static int SumArray (params int[] Arr)
        //{
        //    int sum = 0;

        //    if (Arr is not null)
        //        for (int i = 0; i< Arr.Length;i++)
        //            sum += Arr[i];

        //    return sum;
        //} 
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

            #region Reference Type Parameters

            #region Example 01
            //int[] numbers = [1, 2, 3, 4, 5];
            //int sum = SumArray(numbers);     // Passing By Value
            // SumArray(AddressOfArray)

            //int sum  = SumArray(ref numbers);   // Passing By Ref
            // SumArray(ReferenceOfArray)

            //Console.WriteLine(numbers[0]);  
            #endregion


            #region Example02
            //int[] numbers = [1, 2, 3, 4, 5];
            //int sum = SumArray(numbers);     // Passing By Value
            //int sum = SumArray(ref numbers);     // Passing By Value

            //Console.WriteLine(numbers[0]); 
            #endregion


            #endregion

            #region Passing By Out
            //int A = 3, B = 4;

            //SumMul(A, B, out int _, out int MResult);

            //Console.WriteLine($"MReslut: {MResult}");
            ////Console.WriteLine($"SReslut: {SResult}"); 
            #endregion

            #region Params
            //int total = SumArray (1, 2, 3, 4, 5, 6, 7);
            //Console.WriteLine (total); 
            #endregion

            #region Boxing and unboxing

            // Boxing : Casting from ValueType to ReferenceType
            // UnBoxing : Casting from ReferenceType to ValueType

            #region Example 01
            //object obj;
            ///// Declaring for reference of type "Object" , Refering to the default value of referenceType = NULL
            ///// This reference 'obj' will be allocated at STACK with size 4 bytes
            ///// This reference 'obj' can refer to an instance of type "Object" or another type inherting from "Object"

            //obj = new object();
            //obj = "Ahmed";

            //obj = 'A';    // Casting From Char to object  ---> Boxing
            //obj = 5;      // Casting from int to object   ---> Boxing
            //obj = 5.5;    // Casting from double to object   ---> Boxing
            //obj = true;   // Casting from boolean to object   ---> Boxing

            //bool flag = (bool) obj; 
            #endregion

            #region Example 02
            //int x = 10;

            //object obj = x;
            //Console.WriteLine(obj);

            //int y = (int) obj;
            ////Casting from object [reference type] to int [value type] Explicitly
            ////          new object(20) ---------> 20
            //// unboxing   [unsafe casting] 
            #endregion

            //// Parent = ChildX
            //// Animal = Dog
            //// Safe Casting
            //// Boxing

            //// ChildX = (ChildX) Parent
            //// Dog = (Dog) Animal
            //// Unsafe Casting
            //// UnBoxing

            #endregion

        }
    }
}
