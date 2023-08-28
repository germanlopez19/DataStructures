using System;

namespace LinearTableInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 90, 70, 50, 80, 60, 85 };
            array = TestOneArrayInsert.Insert(array, 75, 2);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }
            Console.ReadKey();
        }
    }
}
