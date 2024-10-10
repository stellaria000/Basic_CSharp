using System;

namespace ConsoleApp1
{
    /*상속 INHERITANCE
     
    부모 클래스의 내요용을 자식 클래스에서 그대로 사용할 수 있게 하는 것. 코드 복사/붙여넣기를 통해 이름만 변경한 후 사용할 수도 있지만 
    상속이 강력한 이유는 요구사항의 변화에도 코드를 최소한의 수정으로 작성할 수 있기 때문.

    클래스 상속의 경우, 반복되는 내용이 수없이 늘어나도, 반복할 내용을 부모 클래스로 만들고, 변경할 내용을 자식- 파생- 클래스에서 상속받을 수 있게
    설계해 코드를 한 번 수정하면 된다.
     */
    class Robot { 
        public void Move() { Console.WriteLine("Robot moves"); }
    }

    class CleanRobot: Robot { public void Move() { Console.WriteLine("Cleaning Robot Moves"); } }

    class RescueRobot: Robot { public void Move() { Console.WriteLine("Rescuing Robot Moves"); } }

    class Program
    {
        static void Main(string[] args)
        {
            CleanRobot cleany = new CleanRobot();
            RescueRobot rescuey = new RescueRobot();

            cleany.Move();
            rescuey.Move();
        }
    }
}

