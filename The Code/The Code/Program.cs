using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool verf = false;
            int SOL = 0;
            while (num != -1)
            {
                InputNumber(ref num);
                if (num == -1)
                {
                    break;
                }
                CheckIfPerfect(num, ref verf, ref SOL);
                Display(verf, num);
            }
        }

        static void InputNumber(ref int temp)
        {
            Console.WriteLine("Enter a number");
            temp = int.Parse(Console.ReadLine());
        }

        static void CheckIfPerfect(int temp, ref bool verify, ref int SOL)
        {
            List<int> factorlist = new List<int>();
            int temp2 = temp / 2 + 1;
            for (int i = 1; i < temp2; i++)
            {
                if (temp % i == 0)
                {
                    factorlist.Add(i);
                }
            }

            Console.WriteLine(string.Join(", ", factorlist));

            if (factorlist.Sum() == temp)
            {
                verify = true;
            }
        }

        static void Display(bool verify, int number)
        {
            if (verify == true)
            {
                Console.WriteLine("{0} is perfect", number);
            }
            else
            {
                Console.WriteLine("{0} is not perfect", number);
            }
        }
    }
}
