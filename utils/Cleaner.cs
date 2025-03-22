using System.Text;

namespace IT_Lab2.utils
{
    public class Cleaner
    {
        public static string ToBinary(string s)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in s)
            {
                if (c == '0' || c == '1')
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
    }
}
