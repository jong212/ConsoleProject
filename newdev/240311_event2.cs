namespace CSharp006
{
    public class Player
    {
        public event Action onGetCoin; // 코인을 얻었을 때 발생하는 이벤트

        public void GetCoin()
        {
            Console.WriteLine("플레이어가 코인을 획득함!");

            // onGetCoin 이벤트가 null이 아닐 경우, 이벤트를 발생시킴
            if (onGetCoin != null) onGetCoin();
        }
    }

    public class UI
    {
        public void UpdateUI()
        {
            // UI 창을 갱신하는 메서드
            Console.WriteLine(" UI창에 코인의 갯수를 갱신!");
        }
    }

    public class SFX
    {
        public void CoinSound() { Console.WriteLine("코인을 획득한 사운드 재생"); } // 코인 사운드 재생 메서드
    }

    public class VFX
    {
        public void CoinEffect()
        {
            // 코인 획득 이펙트를 재생하는 메서드
            Console.WriteLine("코인을 획득한 번쩍거리는 이펙트 효과!!");
        }
    }

    public class EventSender
    {
        public Action onDelegate; // 일반 델리게이트
        public event Action OnEvent; // 이벤트 기반 델리게이트

        public void DelegateCall()
        {
            // onDelegate가 null이 아니면 델리게이트 호출
            if (onDelegate != null) onDelegate();
        }

        public void EventCall()
        {
            // OnEvent가 null이 아니면 이벤트 호출
            if (OnEvent != null) OnEvent();
        }
    }

    public class EventListener
    {
        public void func()
        {
            // 간단한 호출 메시지를 출력하는 메서드
            Console.WriteLine("호출");
        }
    }

    internal class Event02
    {
        static void Main()
        {
            Player player = new Player();
            UI uI = new UI();
            SFX sFX = new SFX();
            VFX vFX = new VFX();

            // Player 객체의 onGetCoin 이벤트에 UI와 SFX 객체의 메서드를 연결
            player.onGetCoin += uI.UpdateUI;
            player.onGetCoin += sFX.CoinSound;

            // 코인 획득 시뮬레이션
            player.GetCoin();

            Console.WriteLine();
            // VFX 객체의 메서드를 onGetCoin 이벤트에 추가하여 코인 획득 시 이펙트 추가
            player.onGetCoin += vFX.CoinEffect;
            player.GetCoin();

            Console.WriteLine();

            // SFX 객체의 사운드 메서드 연결을 제거하여 사운드 없이 코인 획득
            player.onGetCoin -= sFX.CoinSound;
            player.GetCoin();

            Console.WriteLine("=========================================");

            EventSender sender = new EventSender();

            EventListener listener1 = new EventListener();
            EventListener listener2 = new EventListener();
            EventListener listener3 = new EventListener();

            // onDelegate에 여러 리스너의 메서드를 추가하지만, 마지막에 listener3.func로 설정하여 기존 리스너 초기화
            sender.onDelegate += listener1.func;
            sender.onDelegate += listener2.func;
            sender.onDelegate = listener3.func;

            // OnEvent에 리스너 메서드를 추가. 대입연산은 이벤트에 사용할 수 없음
            sender.OnEvent += listener1.func;
            sender.OnEvent += listener2.func;
            //sender.OnEvent = listener3.func; // 이벤트는 대입 연산을 사용할 수 없음

            // 델리게이트는 직접 호출 가능
            sender.onDelegate();

            // 이벤트는 외부에서 직접 호출할 수 없으며, 클래스 내부에서만 발생시킬 수 있음
            //sender.OnEvent(); // 오류: 이벤트는 외부에서 호출할 수 없음
        }
    }
}
