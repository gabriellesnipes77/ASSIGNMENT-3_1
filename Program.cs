using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ASSIGNMENT_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GetEvenNumbers");
        }
       
            static string GetEvenNumbers(int numAmount)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 2; i < 100; i = +2)
                {
                    sb.Append(i);
                    if (i < 98)
                        sb.Append(", ");
                }
            }

            return sb.ToString();
        }
    }
}