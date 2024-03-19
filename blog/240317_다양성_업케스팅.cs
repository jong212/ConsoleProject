using System;

namespace shop
{
    internal class _240306_std
    {
        // 스킬을 추상화한 클래스
        class Skill
        {
            public virtual void Excute() // 가상 메소드, 재정의 가능
            {
                Console.WriteLine("스킬 재사용 대기시간을 진행한다.");
            }
        }

        // Skill 클래스를 상속받아 구체적인 스킬을 나타내는 FireBall 클래스
        class FireBall : Skill
        {
            public override void Excute() // 오버라이딩으로 Excute 메소드 구현
            {

                Console.WriteLine("화염구 발사!");
            }
        }

        // Skill 클래스를 상속받아 구체적인 스킬을 나타내는 Dash 클래스
        class Dash : Skill
        {
            public override void Excute() // 오버라이딩으로 Excute 메소드 구현
            {
                Console.WriteLine("돌진공격");
            }
        }

        // 플레이어를 나타내는 클래스
        class Player
        {
            Skill skill; // Skill 타입의 참조 변수
            public void SetSkill(Skill skill) // 스킬 설정 메소드
            {
                this.skill = skill;
            }
            public void UseSkill() // 설정된 스킬 사용 메소드
            {
                skill.Excute();
            }
        }

        // 메인 메소드
        static void Main(string[] args)
        {
            Player player = new Player();

            Skill fire = new FireBall(); // FireBall 객체 생성 및 업캐스팅
            player.SetSkill(fire); // 플레이어의 스킬로 설정
            player.UseSkill(); // 플레이어가 스킬 사용

            Skill dash = new Dash(); // Dash 객체 생성 및 업캐스팅
            player.SetSkill(dash); // 플레이어의 스킬로 설정
            player.UseSkill(); // 플레이어가 스킬 사용
        }
    }
}
