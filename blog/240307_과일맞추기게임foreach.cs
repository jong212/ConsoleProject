/*
이 C# 코드는 사용자가 여러 과일 중 하나를 맞추는 간단한 콘솔 게임을 구현합니다. 
게임은 10개의 과일 중 랜덤으로 하나를 선택하고, 사용자는 해당 과일을 맞추어야 합니다. 
아래는 코드의 주석을 통해 각 부분의 작동 방식을 설명합니다.


*/

using System;


namespace shop
{
    internal class _240307_std
    {
        // OnePick 클래스: 게임의 주요 로직을 처리합니다.
        class OnePick
        {

            // _Food 배열에 10개의 과일 이름을 저장합니다.
            private string[] _Food = { "Apple", "Grapes", "Fig", "Jujube", "Yaja", "Watermelon", "Orange", "Mandarin", "Lime", "Plum" };

            // _AnswerBool은 사용자가 정답을 맞췄는지 여부를 저장합니다. 여기서는 사용되지 않습니다.
            private bool _AnswerBool;

            // RandNum은 랜덤으로 선택된 과일의 인덱스를 저장합니다.
            public int RandNum;

            // 생성자에서 randsetindex 메서드를 호출하여 RandNum을 초기화합니다.
            public OnePick()
            {
                randsetindex();
            }

            // 읽기 전용 프로퍼티들
            public bool AnswerBool { get { return _AnswerBool; } }
            public string[] Food { get { return _Food; } }

            // randsetindex 메서드: 0에서 9까지의 랜덤 숫자를 생성하여 RandNum에 할당합니다.
            public void randsetindex()
            {
                Random temp = new Random();
                RandNum = temp.Next(0, 10); // 0부터 9까지의 숫자 중 하나를 랜덤으로 선택합니다.
            }

            // checkString 메서드: 사용자가 입력한 문자열이 선택된 과일과 일치하는지 확인합니다.
            public bool checkString(string str)
            {
                // 대소문자를 구분하지 않도록 비교를 개선할 필요가 있습니다.
                return string.Equals(str, _Food[RandNum], StringComparison.OrdinalIgnoreCase);
            }

        }

        // 메인 메서드: 프로그램의 진입점
        static void Main()
        {
            // OnePick 인스턴스 생성
            OnePick FoodList = new OnePick();
            Console.WriteLine("아래 열 개의 과일 중 하나의 과일을 골라 입력하세요");

            // 사용자에게 과일 목록을 출력합니다.
            foreach (string temp in FoodList.Food)
            {
                Console.WriteLine(temp);
            }

            // 사용자가 정답을 맞출 때까지 반복합니다.
            while (true)
            {
                string inputText = Console.ReadLine(); // 사용자 입력 받기
                bool isCorrect = FoodList.checkString(inputText); // 입력된 과일이 정답과 일치하는지 확인

                // 정답 여부를 출력합니다.
                Console.WriteLine($"컴퓨터가 고른 과일은 : {FoodList.Food[FoodList.RandNum]}");
                Console.WriteLine($"사용자가 입력한 과일은 : {inputText}");
                if (isCorrect)
                {
                    Console.WriteLine("정답!");
                    break; // 정답인 경우 루프를 빠져나갑니다.
                }
                else
                {
                    Console.WriteLine("틀렸습니다. 다시 시도하세요.");
                }
            }
        }
    }
}