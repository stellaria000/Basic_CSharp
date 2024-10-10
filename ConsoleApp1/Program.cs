using System;

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

            // WHILE
            /* int i = 1;
            while (i < 11) Console.WriteLine(i++); */

            /*03-3. 데이터를 연산자로 요리하기*/
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
            //bool result;
            //int num1, num2;

            //num1 = 3;
            //num2 = 5;

            //result = num1 > num2;
            //Console.WriteLine(result);

            //result = num1 < num2;
            //Console.WriteLine(result);

            //result = num1 >= num2;
            //Console.WriteLine(result);

            //result = num1<= num2;
            //Console.WriteLine(result);

            //result = num1 == num2;
            //Console.WriteLine(result);

            //result = num1 != num2;
            //Console.WriteLine(result);

            // LOGIC(AND/OR/NOT)
            //bool A, B;
            //A = true;
            //B = false;

            // AND
            //Console.WriteLine(A && A);
            //Console.WriteLine(A && B);

            //// OR
            //Console.WriteLine(A || A);
            //Console.WriteLine(A || B);

            //// NOT
            //Console.WriteLine(!A);
            //Console.WriteLine(!B);

            //int score = 85;
            //if (score > 80)
            //    if (score <= 100) Console.WriteLine("A");

            /*03-4. 데이터 옮겨 담기*/
            sbyte value1 = 64;
            sbyte value2 = 64;

            int value3 = (int)value1 + value2;

            Console.WriteLine(value3);
        }
    }
}
