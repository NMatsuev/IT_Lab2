namespace IT_Lab2.utils
{
    public class ArraysOperations
    {
        public static bool[] Xor(bool[] array1, bool[] array2)
        {
            bool[] result = new bool[array1.Length > array2.Length ? array2.Length : array1.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array1[i] ^ array2[i];
            }
            return result;
        }
    }
}
