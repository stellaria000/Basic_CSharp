using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        /*
             인스턴스 변수는 일반 변수를 선언하는 것과 유사하지만, 데이터 형이 클래스가 된다. 인스턴스 변수 p1은 Person 클래스를 바탕으로 만들어진다.
             */
        Person p1;
        p1 = new Person();
        p1.Name = "aa";
        p1.Eat();
    }

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
}
