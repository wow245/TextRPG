using System;
using System.Threading;

namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 캐릭터 생성
            Character player = new Character("Chad", "전사", 01, 100, 10, 5, 100, 1500);

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태보기 \n2. 인벤토리\n3. 상점");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");
            string Answer= Console.ReadLine();

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":


                    player.ShowStatus();
                    break;
                case "2":
                    
                    break;
                case "3":
                    
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
                    break;
            }
        }
    }

    class Character
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public int MaxHealth { get; set; }
        public int AttackPoints { get; set; }
        public int DefensePoints { get; set; }
        public int ExperiencePoints { get; set; }
        public int Gold { get; set; }
        public bool IsAlive { get { return HealthPoints > 0; } }

        public Character(string name, string job, int level, int healthPoints, int attackPoints, int defensePoints, int experiencePoints, int gold)
        {
            Name = name;
            Job = job;
            Level = level;
            HealthPoints = healthPoints;
            MaxHealth = healthPoints;
            AttackPoints = attackPoints;
            DefensePoints = defensePoints;
            ExperiencePoints = experiencePoints;
            Gold = gold;
        }
    
        public void ShowStatus()
        {
            Console.WriteLine($"상태보기");
            Console.WriteLine($"캐릭터의 정보가 표시됩니다.");
            Console.WriteLine();
            Console.WriteLine($"LV: {Level}");
            Console.WriteLine($"{Name} ({Job})");
            Console.WriteLine($"공격력: {AttackPoints}");
            Console.WriteLine($"방어력: {DefensePoints}");
            Console.WriteLine($"체력: {HealthPoints}");
            Console.WriteLine($"Gold: {Gold}G");
        }
    }
}
