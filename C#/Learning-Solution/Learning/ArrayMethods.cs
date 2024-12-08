using System;


namespace Learning
{
    public class ArrayMethods
    {
        public void ArrayMethodsExample()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            Array.Sort(nums);
            Array.Reverse(nums);
            int index = Array.IndexOf(nums, 3);
            Console.WriteLine("Index of 30 is " + index);


            bool exists = Array.Exists(nums, n => n > 3);

            Console.WriteLine("Exists " + exists);

            Console.WriteLine("Rank of the Matrix " + nums.Rank);

            Console.WriteLine("Number of rows " + nums.GetLength(0));


        }
    }
}

