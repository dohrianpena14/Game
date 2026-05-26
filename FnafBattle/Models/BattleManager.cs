using System;

namespace FnafBattle.Models
{
    public class BattleManager
    {
        private Random random = new Random();

        public Character Player { get; set; }
        public Character Boss { get; set; }
        public int Turn { get; set; }

        public BattleManager(Character player)
        {
            Player = player;
            Turn = 1;

            Boss = new Character(
                "Springtrap",
                1300,
                20,
                90,
                140,
                "Jumpscare Supremo",
                "Resources/Springtrap.png"
            );
        }

        public int PlayerAttack()
        {
            return random.Next(Player.AttackMin, Player.AttackMax + 1);
        }

        public int BossAttack()
        {
            return random.Next(Boss.AttackMin, Boss.AttackMax + 1);
        }

        public int PlayerSpecial()
        {
            return Player.SpecialDamage;
        }

        public int BossSpecial()
        {
            return Boss.SpecialDamage;
        }
    }
}