using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cat
    {
        //public string Name;
        //public int Weight;
        private string name;

        public void SetName(string name) { this.name = name; }

        public string GetName() { return this.name; }

        /*
            public Cat(string name)
            {
                Name = name;
                Console.WriteLine("고양이의 이름은  " + Name + "입니다.");
            }
        */
        
        // EXAMPLE: OVERLOADING
        // 클래스 내부에 동일한 이름의 클래스를 여러 개 선언하고, 필요에 맞게 자동으로 호출할 수 있도록 만들어준다.
        
        /*
         * public Cat(string name, int weight)
            {
                Name = name;
                Weight = weight;

                Console.WriteLine("고양이의 이름은 " + Name + "이며, 몸무게는 " + Weight + "kg입니다.");
             }
        */

        /* 소멸자 Destructor
         * 메소드 앞에 ~ 기호로 구별한다. 시스템의 가비지 컬렉터에서 소멸자가 호출되는 시점을 결정한다.
         * 사용하지 않는 메모리 자원을 관리해주는 도구로, 코드 작성 시 메모리 관리를 별도로 하지 않아도 메모리가 부족하면
         * 가비지 컬렉터가 알아서 사용하지 않는 클래스/변수에서 메모리를 해제하고 필요한 곳에 다시 메모리를 할당하게 관리한다.
         * 하지만 가비지 컬렉터가 알아서 메모리를 관리하므로 언제 동작할 지 알 수 없고, 소멸자가 호출되는 시점도 알 수 없다.
         */
        // ~Cat() { Console.WriteLine(Name + "가 사라집니다."); }


    }

    class MainClass
    {
        /* 인스턴스 변수는 일반 변수를 선언하는 것과 유사하지만, 데이터 형이 클래스가 된다. 인스턴스 변수 p1은 Person 클래스를 바탕으로 만들어진다.*/
        static int Main(string[] args)
        {
            Cat coco = new Cat();
            coco.SetName("코코");

            //Cat coco = new Cat("코코");
            //coco.Name= "몰리";    

            Console.WriteLine("고양이의 이름은 " + coco.GetName() + "입니다.");

        }

    }
}


