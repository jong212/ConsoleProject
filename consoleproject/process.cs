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

        // 인트로를 시작하는 메서드
        public void StartIntro()
        {
            mainSet mainset = new mainSet();
            mainset.textView();

            //GlovalMethod.prt("안녕하세요", 4, 10);
  
            List<string> list = new List<string>();
            list.Add("평  화  롭  던");
            list.Add("떡 잎 마 을 에 ...");
            list.Add("다 수 의  괴 물  출몰");
            list.Add("마 을 은  쑥 대 밭  전 멸");
            list.Add("학 원 에 서  돌 아 온  경 일 이 . . ");
            list.Add(" ");

            GlovalMethod.oneprt(list,4,20,true );
            //Console.WriteLine("평화롭던 떡잎마을에 괴물이 출몰했습니다!");
            // 추가 인트로 로직...
        }

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
