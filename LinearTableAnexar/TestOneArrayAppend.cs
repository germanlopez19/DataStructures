using System;
namespace LinearTableAnexar
{
    public class TestOneArrayAppend
    {
        public static int[] Add(int[] array, int value)
        {
            int[] tempArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[array.Length] = value;
            return tempArray;
        }
    }
}
