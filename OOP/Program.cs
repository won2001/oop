using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace OOP
{
    internal class Program
    {
        #region 객체지향
        //enum CarType { Truck, Bus}
        /*class Car 
        {
            public string name;
            public float speed;
            public CarType type;

            private bool turnOn;
            public int oiAmount;

            public void Drive()
            {
                Console.WriteLine($"{name} 이름의 차가 움직입니다.");
                speed += 10;
            }

            public void Stop()
            {
                Console.WriteLine($"{name} 이름의 차가 멈춥니다.");
                speed = 0;
            }
            public void TurnOn()
            {
                if (oiAmount > 0)
                {
                    Console.WriteLine("시동이 걸립니다.");
                    turnOn = true;
                }
                else
                {
                    Console.WriteLine("기름이 없어서 시동이 걸리지 않습니다.");
                }
            }

        }

        class Player
        {
            private int hp = 100;

            public void TakeDamge(int damge)
            {
                Console.WriteLine($"플레이어가 데미지 {damge}를 받는다.");
                hp -= damge;
                if (hp <= 0)
                    Console.WriteLine($"플레이어의 체력이 {hp}가 되었다.");
                {
                    Die();
                }
            }
            private void Die()
            {
                Console.WriteLine("플레이어가 죽었습니다");
            }
        }

        class Monster
        {
            public string name;
            public int attackPoint;
            public void Attack(Player player)
            {
                Console.WriteLine($"{name} 플레이어를 {attackPoint} 공격력으로 공격합니다.");
                player.TakeDamge(attackPoint);

            }
        }
        class Human
        {
            public string name;
            public string homeAddress;

            public void GoHome()
            {

            }
        }
        static void Main(string[] args)
        {
            Car bongo = new Car();
            bongo.name = "봉고";
            bongo.speed = 0;
            bongo.type = CarType.Truck;

            bongo.Drive();
            bongo.Stop();

            bongo.TurnOn();

            //클래스 : 객체를 설계 - 비유로 붕어빵 틀
            //인스턴스 : 실제로 객체자체 - 비유로 붕어빵
            Player player = new Player();

            Monster dragon = new Monster(); // 인스턴스
            dragon.name = "드래곤";
            dragon.attackPoint = 45;

            Monster orc = new Monster();
            orc.name = "오크";
            orc.attackPoint = 20;



            dragon.Attack(player);// monster attafck player
            orc.Attack(player);

        }*/
        #endregion
        #region class과제
        //class 과제1
        //Chracter 클래스를 선언하고, 클래스가 가져야 할 필드와 메서드는 아래와 같다.
        //**필드
        //레벨
        //체력
        //이동 속도
        //공격력
        //**메서드
        //전진
        //후진
        //좌회전(90도)
        //우회전(90도)
        //공격
        //피격
        class Chracter
        {
            public int levl;
            private int hp = 100;
            public int speed;
            public int strength = 10;
            public void Straight()
            {
                Console.WriteLine("전진합니다.");
                speed += 10;
            }
            public void Back()
            {
                Console.WriteLine("후진합니다.");
                speed -= 10;
            }
            public void Left()
            {
                Console.WriteLine("왼쪽으로 이동합니다.");
                speed += 5;
            }
            public void Right()
            {
                Console.WriteLine("오른쪽으로 이동합니다.");
                speed += 5;

            }
            public void Attack()
            {
                Console.WriteLine($"플레이어를 {strength} 공격력으로 공격합니다.");
            }
            public void Hit(int damge)
            {
                Console.WriteLine($"플레이어가 데미지 {damge}를 받는다.");
                hp -= damge;
            }
        }
        #endregion



        #region static과제
        //static 과제 1. 계산기 클래스 만들기

        //주어진 조건을 만족하는 클래스를 설계하시오.
        //클래스 내 연산에 관련된 메서드는 static 으로 프로그램 전역에서 사용할 수 있어야 합니다.
        //요구 사항
        //클래스 이름 : MyCalculator

        //메서드
        //Add: 두 개의 숫자를 받아 그 합을 반환합니다.
        //Subtract: 두 개의 숫자를 받아 첫 번째에서 두 번째를 뺀 결과를 반환합니다.
        //Multiply: 두 개의 숫자를 받아 그 곱을 반환합니다.
        //Divide: 두 개의 숫자를 받아 첫 번째를 두 번째로 나눈 결과를 반환합니다. 0으로 나누는 경우에는 적절한 에러 메시지를 반환해야 합니다.
        //Squared: 첫 번째 숫자를 기준으로 두 번째 숫자만큼 제곱하는 기능을 추가합니다.

        //입력과 반환 값: 모든 메서드는 두 개의 double 타입 입력을 받고, 결과도 double 타입으로 반환해야 합니다.

        //에러 처리: Divide 메서드에서 0으로 나눌 경우, 콘솔에 에러 발생텍스트를 출력해야 합니다

        public static class MyCalculator
        {
            public static double Add(double num1, double num2)
            {
                double sum = 0;
                return num1 + num2;
            }
            public static double Sudtract(double num1, double num2)
            {
                double imsub = 0;
                return num1 - num2;
            }
            public static double Multlply(double num1, double num2)
            {
                double multiply = 0;
                return num1 * num2;
            }
            public static double Divide(double num1, double num2)
            {
                double divide;
                if (num2 == 0)
                    throw new DivideByZeroException();
                return num1 / num2;
            }
            public static double Squared(double num1, double num2)
            {
                double squared = Math.Pow(num1, num2);
                return squared;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("첫번째 숫자를 입력해주세요.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째 숫자를 입력해주세요.");
            int y = int.Parse(Console.ReadLine());

            double sum = MyCalculator.Add(x, y);
            double imsub = MyCalculator.Sudtract(x, y);
            double mult = MyCalculator.Multlply(x, y);
            double divide = MyCalculator.Divide(x, y);
            double squared = MyCalculator.Squared(x, y);

            Console.WriteLine($"두 수를 더한 값은{sum}입니다.");
            Console.WriteLine($"두 수를 뺀 값은{imsub}입니다.");
            Console.WriteLine($"두 수를 곱한 값은{mult}입니다.");
            Console.WriteLine($"두 수를 나눈 값은{divide}입니다.");
            Console.WriteLine($"첫번째 수의 두 번째 숫자만큼 제곱한 값은{squared}입니다.");

        }
        #endregion
    }
}
