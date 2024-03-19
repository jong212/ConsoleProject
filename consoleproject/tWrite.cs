using System;
using System.Collections.Generic;
using System.Threading;

namespace consoleproject
{
    public static class GlovalMethod
    {
        // 텍스트 하나짜리 출력 
        public static void prt(string str, int numA, int numB)
        {
            Console.SetCursorPosition(numA, numB);
            Console.WriteLine(str);
            Console.Out.Flush();

        }

        // 텍스트 출력 가운데 정렬은 옵션
        public static void oneprt(List<string> list, int numA, int numB, string anm, int animInitialLeft, int animInitialTop)
        {
            Random random = new Random();

            foreach (var sentence in list)
            {
                int initialCursorLeft = numA;
                int initialCursorTop = numB;

                Console.SetCursorPosition(initialCursorLeft, initialCursorTop);

                foreach (char character in sentence)
                {
                    int charWidth = GetCharacterWidth(character);
                    Console.Write(character);
                    initialCursorLeft += charWidth;
                    Thread.Sleep(80);
                    Console.Out.Flush();

                    var animalAnimations = Monster.Instance.GetAnimalAnimations();
                    var animalMovements = Monster.Instance.GetAnimalMovements();

                    if (animalAnimations.TryGetValue(anm, out List<string> animations))
                    {
                        // 랜덤하게 애니메이션을 선택합니다.

                        int randomIndex = random.Next(0, animations.Count);
                        string rabbitFrame = animations[randomIndex];
                        var movementList = animalMovements[anm];
                        // PrintAnimationFrame 메소드를 사용하여 프레임을 출력합니다.
                        PrintAnimationFrame(rabbitFrame, animInitialLeft, animInitialTop);
                    }
                }
                numB++;
                Thread.Sleep(100);
            }
            Console.Out.Flush();
        }

        // 텍스트 찌그러져서 출력되는 현상 해결해주는 함수
        private static int GetCharacterWidth(char character)
        {
            int width = 1;
            if (!char.IsControl(character) && char.IsLetterOrDigit(character))
            {
                width = 2;
            }
            return width;
        }
        public static void PrintAnimationFrame(string frame, int numA, int numB)
        {
            // 애니메이션 출력 전의 커서 위치 저장
            int originalCursorLeft = Console.CursorLeft;
            int originalCursorTop = Console.CursorTop;

            // 애니메이션 프레임 출력
            var frameLines = new List<string>(frame.Split('\n'));
            foreach (var line in frameLines)
            {
                Console.SetCursorPosition(numA, numB++);
                Console.Write(line);
                Console.Out.Flush();
                Thread.Sleep(10); // 각 줄 출력 후 지연
            }

            // 애니메이션 출력 후 원래 커서 위치로 복원
            Console.SetCursorPosition(originalCursorLeft, originalCursorTop);
        }


    }
}