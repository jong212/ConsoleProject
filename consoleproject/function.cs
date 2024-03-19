using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleproject
{
    public static class GlovalMethod // Utilities 클래스 추가
    {
        public static void prt(string str,int numA,int numB) // static 키워드 추가, 메서드 이름 대문자로 시작하도록 수정
        {
            Console.SetCursorPosition(numA,numB);
            Console.WriteLine(str);
        }

        public static void oneprt(List<string> list,int numA, int numB,bool alignCenter) // static 키워드 추가, 메서드 이름 대문자로 시작하도록 수정
        {
            foreach (var sentence in list)
            {
                int initialCursorLeft = numA; // 기본적으로 numA를 사용
                alignCenter = false;
                if (alignCenter)
                {
                    // 가운데 정렬을 위한 계산
                    int windowWidth = Console.WindowWidth;
                    int stringLength = sentence.Length;
                    initialCursorLeft = (windowWidth - stringLength ) / 2; // 가운데 정렬 시에만 재계산
                }

                for (int i = 0; i < sentence.Length; i++)
                {
                    Console.SetCursorPosition(initialCursorLeft + i, numB + 1); // 커서 위치 설정
                    Console.Write(sentence[i]);
                    Thread.Sleep(80); // 다음 문장으로 넘어가기 전에 잠시 대기


                }
                numB++; // 다음 줄로 이동
                Thread.Sleep(100); // 다음 문장으로 넘어가기 전에 잠시 대기
            }
            Console.Out.Flush();

        }


    }

}
