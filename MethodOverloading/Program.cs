using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 4));
            Console.WriteLine(Add(1.5m, 4.5m));
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            decimal sum = num1 + num2;
            return sum;
        }

        public static string Add(int num1, int num2, bool isMoney)
        {
            if (isMoney == true)
            {
                if (num1 + num2 == 1)
                {
                    return $"{num1 + num2} dollar";
                }
                else
                {
                    return $"{num1 + num2} dollars";
                }
            }
            else
            {
               return $"{ num1 + num2}";
            }

        }
    }

}

