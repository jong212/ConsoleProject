/*
이 코드는 키보드의 화살표 키를 사용하여 '♥' 기호를 이동시키며, 1부터 25까지의 숫자를 올바른 순서로 정렬하는 게임입니다. 
'♥' 기호는 실제로 숫자 0을 대표하며, 사용자는 이 기호를 이동시켜 숫자들의 위치를 바꿀 수 있습니다. 
모든 숫자가 올바른 순서로 정렬되면 게임이 종료됩니다.
*/
using System;

namespace shop
{
    // Program 클래스 정의
    internal class Program
    {
        // Main 메서드: 프로그램의 진입점
        static void Main(string[] args)
        {
            // 게임에서 사용할 숫자 배열 선언 및 초기화
            int[] number = new int[25];
            // 게임 종료 플래그
            bool endflag = false;
            // 배열 내 숫자 위치를 바꿀 때 목적지(dest) 및 출발지(sour) 인덱스
            int dest, sour;
            // 숫자 위치 바꾸기를 위한 임시 저장 변수
            int temp;

            // 마지막으로 이동한 위치를 저장하는 변수 (초기값: 24)
            int save = 24;
            // 이동할 숫자를 임시 저장하는 변수
            int move;

            // 난수 생성을 위한 Random 객체 생성
            Random rand = new Random();

            // 숫자 배열을 초기화합니다. 0부터 24까지의 숫자를 배열에 할당
            for (int i = 24; i >= 0; i--)
            {
                number[save - i] = i;
            }

            // 난수를 사용하여 숫자 배열 내의 요소 위치를 무작위로 바꿉니다.
            for (int i = 0; i < 200; i++)
            {
                dest = rand.Next(24);
                sour = rand.Next(24);
                temp = number[dest];
                number[dest] = number[sour];
                number[sour] = temp;
            }
            // 게임의 메인 루프
            while (true)
            {
                Console.Clear(); // 콘솔 화면을 지웁니다.
                Console.WriteLine("움직여라");
                if (endflag) // 만약 모든 숫자가 올바른 순서대로 정렬되었다면 게임 종료
                {
                    Console.WriteLine("완성!!!!");
                    break;
                }
                // 게임 보드를 출력합니다.
                for (int i = 0; i < number.Length; i++)
                {
                    Console.Write(number[i] == 0 ? "♥\t" : $"{number[i]}\t");

                    if ((i + 1) % 5 == 0)
                    {
                        Console.WriteLine("\n\n\n");
                    }
                }

                // 키보드 입력을 받습니다.
                ConsoleKeyInfo inputKey = Console.ReadKey(true);

                // 입력된 키에 따라 동작을 수행합니다.
                switch (inputKey.Key)
                {
                    case ConsoleKey.LeftArrow:
                        // 왼쪽 화살표: 숫자를 왼쪽으로 이동
                        if (save % 5 == 0)
                        {
                            break;
                        }
                        move = number[save];
                        number[save] = number[save - 1];
                        number[save - 1] = move;
                        save--;
                        break;

                    case ConsoleKey.RightArrow:
                        // 오른쪽 화살표: 숫자를 오른쪽으로 이동
                        if (save % 5 == 4)
                        {
                            break;
                        }
                        move = number[save];
                        number[save] = number[save + 1];
                        number[save + 1] = move;
                        save++;
                        break;
                    case ConsoleKey.UpArrow:
                        // 위쪽 화살표: 숫자를 위로 이동
                        if (save < 5)
                        {
                            break;
                        }
                        move = number[save];
                        number[save] = number[save - 5];
                        number[save - 5] = move;
                        save -= 5;
                        break;

                    case ConsoleKey.DownArrow:
                        // 아래쪽 화살표: 숫자를 아래로 이동
                        if (save >= 20)
                        {
                            break;
                        }
                        move = number[save];
                        number[save] = number[save + 5];
                        number[save + 5] = move;
                        save += 5;
                        break;
                }
                // 모든 숫자가 올바른 순서인지 확인합니다.
                endflag = true;

                for (int i = 0; i < number.Length - 1; i++)
                {
                    if (number[i] != i + 1)
                    {
                        endflag = false;
                        break;
                    }
                }
            }
        }
    }
}
