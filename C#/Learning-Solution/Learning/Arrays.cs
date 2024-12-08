using System;


namespace Learning
{
    public class Arrays
    {
        public void ArraysExample()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };



            Console.WriteLine(intArray.Length);

            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }

            // Multi - dimensional Arrays
            // two dimension array
            int[,] twoDimensionalArray = new int[4, 2];
            int[,] intTwoDimension1 = new int[,] { { 1, 2 }, { 3, 4 } };
            int[,] intTwoDimension2 = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            // three dimensional array

            int[,,] threeDimensionalArray = new int[4, 2, 3];


            // Jagged array

            int[][] jaggedArray = new int[2][];

            jaggedArray[0] = new int[5] { 1, 2, 3, 46, 6 };
            jaggedArray[1] = new int[4] { 1, 3, 4, 5 };
        }
    }
}


