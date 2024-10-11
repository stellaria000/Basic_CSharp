using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* COLLECTION
             컬렉션 데이터를 담는 자료 구조. 여기서 컬렉션은 단일 자료 구조가 아닌 입력과 출력, 처리를 포함한 연산을 수행하는 다양한 자료 구조의 모음이다.
            배열은 다룰 때 인덱스로 직접 접근해 데이터를 삽잆하거나 다른 값으로 대체할 수 있지만, 컬렉션 클래스는 메소드를 통해 데이터를 다룬다.
            즉, 컬렉션 클래스의 구조와 메소드 이름만 알면 복잡한 처리도 쉽게 해결할 수 있다.
             */

            /*ARRAYLIST
             배열과 유사한 데이터 묶음을 관리하는 클래스. 그러나 ArrayList는 클래스의 생성자가 호출될 때 크기를 미리 설정할 필요가 없으며,
            한 가지 데이터형이 아닌 다양한 데이터 형의 값을 담을 수 있다. 
            Remove 메소드를 통해 특정 아이템을 제거할 수 있고, 정수/문자열/실수/불 형의 데이터를 모두 ArrayList에 넣을 수 있다. 하지만 foreach문으로
            ArrayList에 담긴 값을 출력할 때 어떤 데이터 형으로 특정할 수 없어 var형을 사용해 암시적으로 형변환할 수 있도록 한다.
            var형으로 선언해 두면 컴파일러가 자동으로 값에 따른 알맞은 데이터 형으로 변환한다.
             */

            /*
                ArrayList al = new ArrayList();
                al.Add(1);
                al.Add("Hello");
                al.Add(3.3);
                al.Add(true);

                foreach(var item in al) { Console.WriteLine(item); }

                Console.WriteLine();

                al.Remove("Hello");

                foreach(var item in al) { Console.WriteLine(item); }
            */

            // QUEUE
            //    Queue는 입력한 값이 먼저 출력되는 자료 구조이다. 선착순으로 실행되는 모든 경우에 사용할 수 있다.

            //Queue que = new Queue();
            //que.Enqueue(1);
            //que.Enqueue(2);
            //que.Enqueue(3);

            //while (que.Count > 0) Console.WriteLine(que.Dequeue());
            // Dequeue 메소드가 호출될 때마다 Count 값은 1씩 감소하며, 0이 될 경우 while 반복문을 빠져나온다.

            /* STACK
             Queue 클래스와 대응되는 자료 구조. Stack은 먼저 입력한 데이터가 맨 나중에 출력된다.
             */

            //Stack st = new Stack();
            //st.Push(1);
            //st.Push(2);
            //st.Push(3 );

            //while (st.Count > 0) Console.WriteLine(st.Pop());

            //HASHTABLE
            //    Hashtable 클래스는 키Key와 값Value로 저장하는 자료 구조다. 데이터의 크기가 증가할 수록 상대적으로 처리하는 속도가 빠르다.
            //    찾고자 하는 데이터가 마지막에 있는 경우 ArrayList, Queue, Stack 자료 구조는 데이터가 저장된 순서대로 살펴본 뒤 찾게 되지만, 
            //    Hashtable은 키로 값을 한번에 찾을 수 있기 때문에 데이터가 커질 수록 유리하다.

            //Hashtable ht = new Hashtable();
            //ht["apple"] = "사과";
            //ht["banana"] = "바나나";
            //ht["orange"] = "오렌지";

            //Console.WriteLine(ht["apple"]);
            //Console.WriteLine(ht["banana"]);
            //Console.WriteLine(ht["orange"]);

            /*EXCEPTION
             예외 상황은 프로그램을 만드는 과정에서 발생할 수 있는 의도치 않은 모든 상황을 의미한다. 예를 들어 나눗셈 연산을 수행할 때 0으로 나누는 경우, 
            배열의 인덱스 범위를 벗어난 값을 사용해 배열에 접근하는 경우, 클래스를 인스턴스로 만들지 않고 참조하려는 경우 등이 있다. 만약 이러한 상황이 발생할 때에는
            프로그램은 비정상적으로 종료한다.*/

            Console.Write("나눌 숫자를 입력하세요 : ");   
            int divider = int.Parse(Console.ReadLine());    // ReadLine 메소드로 사용자 입력을 받는다→ 문자열을 정수로 변환하기 위해 int.Parse 메소드 사용

            try { Console.WriteLine(10 / divider); }    // 입력값이 0일 때 오류 발생
            catch(Exception e) {
                Console.WriteLine("Exception: "+ e.Message);
                Console.WriteLine("0으로 나눌 수 없습니다."); }

        }
    }
}
