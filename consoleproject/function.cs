using System;
using System.Collections.Generic;
using System.Threading;

namespace consoleproject
{
    public static class GlovalMethod
    {
        //텍스트 하나짜리 출력 
        public static void prt(string str, int numA, int numB)
        {
            Console.SetCursorPosition(numA, numB);
            Console.WriteLine(str);
            Console.Out.Flush();

        }

        //텍스트 출력 가운데 정렬은 옵션
        public static void oneprt(List<string> list, int numA, int numB, bool alignCenter)
        {
            foreach (var sentence in list)
            {
                int initialCursorLeft = numA;
                alignCenter = false;
                if (alignCenter)
                {
                    int windowWidth = Console.WindowWidth;
                    int stringLength = sentence.Length;
                    initialCursorLeft = (windowWidth - stringLength) / 2;
                }


                Console.SetCursorPosition(initialCursorLeft, numB);

                foreach (char character in sentence)
                {
                    int charWidth = GetCharacterWidth(character);
                    Console.Write(character);
                    initialCursorLeft += charWidth;
                    Thread.Sleep(80);
                    Console.Out.Flush();
                }
                numB++;
                Thread.Sleep(100);
            }
            Console.Out.Flush();
        }

        //텍스트 찌그러져서 출력되는 현상 해결해주는 함수
        private static int GetCharacterWidth(char character)
        {
            int width = 1; // Default width is 1
            // Handle double-width characters (such as some Unicode characters)
            if (!char.IsControl(character) && char.IsLetterOrDigit(character))
            {
                width = 2;
            }
            return width;
        }



        /*
        public static async Task DisplayAnimationsAsync(string animalName = "", int delay = 300)
        {
            var allAnimations = GameProgressService.Instance.GetAnimalAnimations();

            // 특정 동물의 애니메이션만 표시하거나, 매개변수가 비어있으면 모든 동물의 애니메이션 표시
            foreach (var animal in allAnimations)
            {
                if (!string.IsNullOrEmpty(animalName) && animal.Key != animalName)
                {
                    continue; // 특정 동물만 처리하고자 할 때, 해당 동물이 아니면 건너뛰기
                }

                Console.WriteLine($"{animal.Key} animations:");
                foreach (var animation in animal.Value)
                {
                    Console.WriteLine(animation); // 애니메이션 출력
                    await Task.Delay(delay); // 매개변수로 받은 대기 시간을 적용
                }
                Console.WriteLine(); // 동물 구분을 위한 공백 줄
            }
        }
        */

    }
}
