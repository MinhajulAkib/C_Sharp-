using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] evenNums = new int[5];
            evenNums[0] = 2;
            evenNums[1] = 4;
            //evenNums[6] = 12;  //Throws run-time exception IndexOutOfRange

            Console.WriteLine(evenNums[0]);  //prints 2
            Console.WriteLine(evenNums[1]);
        }
    }
}
