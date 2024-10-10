using System;

namespace ConsoleApp1
{
    class Person
    {
        public string Name;
        public string Birthday;
        public string Gender;

        public void Eat()
        {
            Console.WriteLine(Name + "이(가) 아침을 먹습니다.");
        }

        public void Walk()
        {
            Console.WriteLine(Name + "이(가) 걷습니다.");
        }

        public void Run()
        {
            Console.WriteLine(Name + "이(가) 뜁니다.");
        }
    }

    class Cat
    {
        public string Name;
        public int Weight;

        public Cat(string name) {
            Name = name;
            Console.WriteLine("고양이의 이름은  "+ Name+ "입니다."); }

        // EXAMPLE: OVERLOADING
        // 클래스 내부에 동일한 이름의 클래스를 여러 개 선언하고, 필요에 맞게 자동으로 호출할 수 있도록 만들어준다.
        public Cat(string name, int weight)
        {
            Name = name;
            Weight = weight;

            Console.WriteLine("고양이의 이름은 " + Name + "이며, 몸무게는 " + Weight + "kg입니다.");
        } 

        /* 소멸자 Destructor
         * 메소드 앞에 ~ 기호로 구별한다. 시스템의 가비지 컬렉터에서 소멸자가 호출되는 시점을 결정한다.
         * 사용하지 않는 메모리 자원을 관리해주는 도구로, 코드 작성 시 메모리 관리를 별도로 하지 않아도 메모리가 부족하면
         * 가비지 컬렉터가 알아서 사용하지 않는 클래스/변수에서 메모리를 해제하고 필요한 곳에 다시 메모리를 할당하게 관리한다.
         * 하지만 가비지 컬렉터가 알아서 메모리를 관리하므로 언제 동작할 지 알 수 없고, 소멸자가 호출되는 시점도 알 수 없다.
         */
        ~Cat() { Console.WriteLine(Name + "가 사라집니다."); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             인스턴스 변수는 일반 변수를 선언하는 것과 유사하지만, 데이터 형이 클래스가 된다. 인스턴스 변수 p1은 Person 클래스를 바탕으로 만들어진다.
             */
            //Person p1;
            //p1 = new Person();
            //p1.Name = "aa";
            //p1.Eat();

            Cat coco = new Cat("코코");
            Cat moly = new Cat("몰리", 3);
            
        }
    }
}

//        /*03-2. 프로그램의 흐름을 결정하는 제어문 */
//        // IF-ELSE IF
//        //int num = 0;

//        //if (num > 0) Console.WriteLine("양수");
//        //else if (num < 0) Console.WriteLine("음수");
//        //else Console.WriteLine("영");

//        //// FOR
//        //for (int i = 1; i < 11; i++) Console.WriteLine(i);

//        //// WHILE
//        //int i = 1;
//        //while (i < 11) Console.WriteLine(i++);

//        ///*03-3. 데이터를 연산자로 요리하기*/
//        //// CALCULATION
//        //int result, num1, num2;
//        //result = 3 + 1;
//        //Console.WriteLine(result);

//        //result = 3 - 1;
//        //Console.WriteLine(result);

//        //num1 = 2;
//        //result = 5 * num1;
//        //Console.WriteLine(result);

//        //num2 = 10;
//        //result = num2 / 3;
//        //Console.WriteLine(result);

//        //result = 10 % 2;
//        //Console.WriteLine(result);

//        //// INCRESEMENT / DECRESEMENT
//        //int num = 0;
//        //Console.WriteLine(num++);
//        //Console.WriteLine(num);
//        //Console.WriteLine(--num);
//        //Console.WriteLine(num);

//        //// COMPARING
//        //bool result;
//        //int num1, num2;

//        //num1 = 3;
//        //num2 = 5;

//        //result = num1 > num2;
//        //Console.WriteLine(result);

//        //result = num1 < num2;
//        //Console.WriteLine(result);

//        //result = num1 >= num2;
//        //Console.WriteLine(result);

//        //result = num1 <= num2;
//        //Console.WriteLine(result);

//        //result = num1 == num2;
//        //Console.WriteLine(result);

//        //result = num1 != num2;
//        //Console.WriteLine(result);

//        //// LOGIC(AND / OR / NOT)
//        //bool A, B;
//        //A = true;
//        //B = false;

//        //// AND
//        //Console.WriteLine(A && A);
//        //Console.WriteLine(A && B);

//        //// OR
//        //Console.WriteLine(A || A);
//        //Console.WriteLine(A || B);

//        //// NOT
//        //Console.WriteLine(!A);
//        //Console.WriteLine(!B);

//        //int score = 85;
//        //if (score > 80)
//        //    if (score <= 100) Console.WriteLine("A");

//        ///*03-4. 데이터 옮겨 담기*/
//        //sbyte value1 = 64;
//        //sbyte value2 = 64;

//        //int value3 = (int)value1 + value2;

//        //Console.WriteLine(value3);
//        //Console.WriteLine(value3);