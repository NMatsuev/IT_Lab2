namespace IT_Lab2.utils
{
    public class KeyMaker
    {
        //x^25+x^3+1
        const int Pow1 = 25;
        const int Pow2 = 3;

        public static bool[] Create(Queue<bool> register, int size)
        {
            bool[] result = new bool[size];
            bool param1;
            bool param2;
            for (int i = 0; i < size; i++)
            {
                param1 = register.ElementAt(register.Count - Pow1);
                param2 = register.ElementAt(register.Count - Pow2);
                result[i] = register.Dequeue();
                register.Enqueue(param1 ^ param2);
            }
            return result;
        }
    }
}
