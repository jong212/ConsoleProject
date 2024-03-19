using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleproject
{
    public class GameProgressService
    {
        private static GameProgressService instance;
        private int currentLevel;
        private bool isBossDefeated;

        // 싱글톤 인스턴스를 얻는 프로퍼티
        public static GameProgressService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameProgressService();
                }
                return instance;
            }
        }

        // 생성자를 private으로 설정하여 외부에서 인스턴스 생성을 방지
        private GameProgressService()
        {
            currentLevel = 1; // 기본 레벨 설정
            isBossDefeated = false;
        }

        // 게임의 현재 레벨을 반환하는 프로퍼티
        public int CurrentLevel
        {
            get { return currentLevel; }
            set { currentLevel = value; }
        }

        // 보스전 상태를 반환하는 프로퍼티
        public bool IsBossDefeated
        {
            get { return isBossDefeated; }
            set { isBossDefeated = value; }
        }
        /*
        public Dictionary<string, List<string>> GetAnimalAnimations()
        {
            return animalAnimations;
        }*/

        // 인트로를 시작하는 메서드
        public void StartIntro()
        {
            /*
            해상도 오류 시 주석 해제
            int windowWidth = 130; 
            int windowHeight = 60;

            Console.SetWindowSize(windowWidth, windowHeight);
            Console.SetBufferSize(windowWidth, windowHeight);
            */
            Console.SetWindowSize(110, 60);
            Console.SetBufferSize(110, 60);

            viewSet mainset = new viewSet();
            mainset.BoxLine();
            mainset.ArtWorld();

            /*
            await GlovalMethod.DisplayAnimationsAsync();
            */
            //GlovalMethod.prt("안녕하세요", 4, 10);
            /*
            var allAnimations = GameProgressService.Instance.GetAnimalAnimations();
            foreach (var animal in allAnimations)
            {
                Console.WriteLine($"{animal.Key} animations:"); // 동물 이름 출력
                foreach (var animation in animal.Value)
                {
                    Thread.Sleep(300);

                    Console.WriteLine(animation); // 해당 동물의 애니메이션 출력
                }
                Console.WriteLine(); // 동물별로 구분하기 위해 빈 줄 추가
            }*/
            List<string> list = new List<string>();
            list.Add("평온함이 마을을 감싸던 그 때... ");
            list.Add("천호마을은 갑작스러운 변화의 소용돌이에 휩싸이게 됩니다.");
            list.Add("평화로웠던 일상은 어느덧 괴물들의 출몰로 인해 혼란과 공포로 가득 차게 되죠... ");
            list.Add("이전과는 다른, 불안한 분위기가 마을 전체를 집어삼키고, ");
            list.Add("마치 쑥대밭을 연상케 하는 전멸의 광경이 펼쳐집니다.....!");
            list.Add("그런 와중, 학원의 일과를 마치고 돌아온 경일이는 자신의 눈앞에 펼쳐진 참혹한 광경을 목격하게 됩니다. ");
            list.Add("그 순간, 갑작스러운 눈부신 빛이 경일이를 덮치고, 그 충격으로 기절하고 맙니다.");
            list.Add("의식을 되찾은 경일이의 눈앞에는 뜻밖의 광경이 펼쳐지는데, ");
            list.Add("바로 요술램프에서 나타난 지피티니가 그의 앞에 나타난 것입니다. ");
            list.Add("안녕, 나는 온라인 소원요정, 요술램프의 지피티니라고 해. ");
            list.Add("네가 입력한 단어를 무조건 만들어낼 수 있지. ");
            list.Add("이 마을을 구할 수 있는 키워드 세 개를 지금 당장 말해봐");


            GlovalMethod.oneprt(list, 4, 30, true);
            //Console.WriteLine("평화롭던 떡잎마을에 괴물이 출몰했습니다!");
            // 추가 인트로 로직...
        }

        /*
        Dictionary<string, List<string>> animalAnimations = new Dictionary<string, List<string>>()
        {
            { "rabbit", new List<string>
                {
                    "\r\n\r\n /\\_/\\\r\n ( o.o )\r\n (\")_(\")",
                    "\r\n\r\n /\\_/\\\r\n ( o.x )\r\n (\")_(\")",
                    "\r\n\r\n /\\_/\\\r\n ( x.o )\r\n (\")_(\")"
                }
            },
            { "cat", new List<string>
                {
                    "\r\n\r\n /\\_/\\\r\n ( =^.^= )\r\n (\")_(\")",
                    "\r\n\r\n /\\_/\\\r\n ( =^.o= )\r\n (\")_(\")",
                    "\r\n\r\n /\\_/\\\r\n ( o^.^= )\r\n (\")_(\")"
                }
            },
            // Add more animals here...
        };
       */
        // 맵 탐험을 시작하는 메서드
        public void ExploreMap()
        {
            Console.WriteLine($"현재 레벨 {currentLevel}. 탐험을 시작합니다.");
            // 맵 탐험 로직...
        }

        // 보스전을 시작하는 메서드
        public void EnterBossFight()
        {
            Console.WriteLine("보스전에 도전합니다!");
            // 보스전 로직...
        }
    }
}
