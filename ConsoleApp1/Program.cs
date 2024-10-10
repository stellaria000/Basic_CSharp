using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*03-2. 프로그램의 흐름을 결정하는 제어문 */
            // IF-ELSE IF
            //int num = 0;

            //if (num > 0) Console.WriteLine("양수");
            //else if (num < 0) Console.WriteLine("음수");
            //else Console.WriteLine("영");

            // FOR
            // for (int i = 1; i < 11; i++) Console.WriteLine(i);

            // CALCULATION
            //int result, num1, num2;
            //result = 3 + 1;
            //Console.WriteLine(result);

            //result = 3 - 1;
            //Console.WriteLine(result);

            //num1 = 2;
            //result = 5 * num1;
            //Console.WriteLine(result);

            //num2 = 10;
            //result = num2 / 3;
            //Console.WriteLine(result);

            //result = 10 % 2;
            //Console.WriteLine(result);

            // INCRESEMENT/DECRESEMENT
            //int num = 0;
            //Console.WriteLine(num++);
            //Console.WriteLine(num);
            //Console.WriteLine(--num);
            //Console.WriteLine(num);

            // COMPARING
            bool result;
            int num1, num2;
            
            num1 = 3;
            num2 = 5;

            result = num1 > num2;
            Console.WriteLine(result);

            result = num1 < num2;
            Console.WriteLine(result);

            result = num1 >= num2;
            Console.WriteLine(result);

            result = num1<= num2;
            Console.WriteLine(result);

            result = num1 == num2;
            Console.WriteLine(result);

            result = num1 != num2;
            Console.WriteLine(result);

        }
    }
}
