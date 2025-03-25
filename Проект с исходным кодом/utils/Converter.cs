using System.Text;

namespace IT_Lab2.utils
{
    public class Converter
    {
        const int BYTE_SIZE = 8;
        public static bool[] BoolArrayFromString(string str)
        {
            bool[] array = new bool[str.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = str[i] != '0';
            }
            return array;
        }
        public static Queue<bool> BoolQueueFromString(string str, int size)
        {
            Queue<bool> queue = new Queue<bool>(size);
            for (int i = 0; i < str.Length && i < size; i++)
            {
                queue.Enqueue(str[i] != '0');
            }
            return queue;
        }

        public static string StringFromBoolArray(bool[] array)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i])
                    sb.Append('1');
                else
                    sb.Append('0');
            }
            return sb.ToString();
        }

        public static string StringFromByteArray(byte[] array)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(StringFromByte(array[i]));
            }
            return sb.ToString();
        }

        public static string StringFromByte(byte b)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < BYTE_SIZE; i++)
            {
                sb.Append((b & 0x80) >> BYTE_SIZE - 1 & 1);
                b <<= 1;
            }
            return sb.ToString();

        }

        public static byte[] ByteArrayFromString(string str)
        {
            byte[] bytes = new byte[str.Length / BYTE_SIZE];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = ByteFromString(str.Substring(i * BYTE_SIZE, BYTE_SIZE));
            }
            return bytes;
        }

        public static byte ByteFromString(string str)
        {
            byte b = 0;
            for (int i = 0; i < BYTE_SIZE; i++)
            {
                b += (byte)(str[i] - '0');
                if (i != BYTE_SIZE - 1)
                    b <<= 1;
            }
            return b;
        }
    }
}
