using System;
using System.Collections.Generic;
using static test.vs;

namespace test
{
    internal class vs
    {
        public class Monster
        {
            private List<MakeMonster> Monlevel { get; set; }
            public Monster()
            {
                Monlevel = new List<MakeMonster>();
                DefaultMonSetting();
            }
            public void DefaultMonSetting()
            {
                Monlevel.Add(new MakeMonster("빨간달팽이", 1, 100, 10));
                Monlevel.Add(new MakeMonster("큰달팽이", 3, 500, 100));
                Monlevel.Add(new MakeMonster("보스", 5, 1000, 700));
            }
            public void RemoveFirstMonster()
            {
                if (Monlevel.Count > 0)
                {
                    Monlevel.RemoveAt(0);
                }
            }
            public MakeMonster GetFirstMonsterName()
            {
                if (Monlevel.Count > 0)
                    return Monlevel[0];
                else
                    return null;
            }
            public MakeMonster getmonster()
            {
                return Monlevel[0];
            }
        }
        public class MakeMonster
        {
            public  string Name {  get; set; }
            public int Level { get; set; }
            public int hp { get; set; }
            public int atk { get; set; }  
            public MakeMonster(string Name,int Level, int hp, int atk)
            {
                this.Name = Name;
                this.Level= Level;
                this.hp = hp;
                this.atk = atk;
            }
             

        }

        public class Item
        {
            public string Name { get; set; }
            public int AttackPower { get; set; }

            public Item(string name, int attackPower)
            {
                Name = name;
                AttackPower = attackPower;
            }
        }

        public class Player
        {
            private int hp;
            private string name;
            public List<Item> Inventory { get; private set; }
            public Player()
            {
                Inventory = new List<Item>();
                DefaultSettings();
            }
            public void DefaultSettings()
            {
                hp = 2000;
                Inventory.Add(new Item("기본 무기", 100));
                Inventory.Add(new Item("중급 무기", 200));
                Inventory.Add(new Item("고급 무기", 300));
            }

            public void UseItem(string itemName, Monster monster)
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    if (Inventory[i].Name == itemName)
                    {
                        int attackPower = Inventory[i].AttackPower;
                        Console.WriteLine($"{itemName}을(를) 사용했습니다.");
                        Inventory.RemoveAt(i); // 아이템 사용 후 삭제
                        //monster.TakeDamage(attackPower);
                        return;
                    }
                }
                Console.WriteLine($"{itemName}은(는) 인벤토리에 없습니다.");
            }
        }
        static bool combat(Player player, Monster monster)
        {

            //몬스터는 레벨 1부터 등장한다
            //공격 가능한 무기는 플레이어가 정한다
            //플레이어는 공격 한 번 하면 아이템이 사라진다
            //무기가 소멸되면 플레이어가 패배하고 소멸되기 전에 몬스터가 모두 죽으면 플레이어가 승리한다.
            while (true)
            {
                MakeMonster firstMonster = monster.GetFirstMonsterName();
                Console.WriteLine($@"
이번 대결 상대의 이름은 {firstMonster.Name}  !!
몬스터 정보는 아래와 같습니다

  HP: {firstMonster.hp}
  Attack power: {firstMonster.atk}
  Level: {firstMonster.Level}

몬스터 처치를 위해 어떤 무기를 드시겠습니까? 
공격은 1회만 가능하며 공격 후 무기는 소멸됩니다
번호를 입력해 주세요 !

");


                foreach (var item in player.Inventory)
                {
                    Console.WriteLine($@"{player.Inventory.IndexOf(item) + 1}번 : {item.Name} 공격력 :{item.AttackPower}");
                }
                var inputNumStr = Console.ReadLine();
                int inputNum;
                if (int.TryParse(inputNumStr, out inputNum))
                {
                    if (firstMonster.hp > player.Inventory[inputNum - 1].AttackPower)
                    {
                        firstMonster.hp -= player.Inventory[inputNum - 1].AttackPower;

                    }
                    else
                    {
                       monster.RemoveFirstMonster(); // Remove the first monster (index 0)

                    }
                    player.Inventory.RemoveAt(inputNum - 1);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }


            }
           
            return true;
        }
        static void Main(string[] args)
        {
            //플레이어 무기 세팅
            Player player = new Player();

            //몬스터 세팅
            Monster monster = new Monster();

            combat( player,  monster);
            MakeMonster defeatedMonster = monster.GetFirstMonsterName();
            Console.WriteLine($@"
    Versus battle is over! 
    Monster Name: {defeatedMonster.Name} 
    HP Remaining: {defeatedMonster.hp} 
    Attack Power: {defeatedMonster.atk}
    Level: {defeatedMonster.Level}
    ");
        }
    }
}
