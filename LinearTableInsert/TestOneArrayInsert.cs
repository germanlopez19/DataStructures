using System;
namespace LinearTableInsert
{
    public class TestOneArrayInsert
    {
        public static int[] Insert(int[] array, int value, int insertIndex)
        {
            int[] arrayTemp = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i < 2)
                {
                    arrayTemp[i] = array[i];
                }
                else
                {

                    arrayTemp[i + 1] = array[i];
                }
            }
            arrayTemp[insertIndex] = value;
            return arrayTemp;
        }
    }
}
