namespace FnafBattle.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int AttackMin { get; set; }
        public int AttackMax { get; set; }
        public int SpecialDamage { get; set; }
        public string SpecialName { get; set; }
        public string ImagePath { get; set; }

        public Character(
            string name,
            int maxHealth,
            int attackMin,
            int attackMax,
            int specialDamage,
            string specialName,
            string imagePath)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;
            AttackMin = attackMin;
            AttackMax = attackMax;
            SpecialDamage = specialDamage;
            SpecialName = specialName;
            ImagePath = imagePath;
        }

        public bool IsDead()
        {
            return Health <= 0;
        }

        public void ReceiveDamage(int damage)
        {
            Health -= damage;

            if (Health < 0)
                Health = 0;
        }

        public void Heal(int amount)
        {
            Health += amount;

            if (Health > MaxHealth)
                Health = MaxHealth;
        }
    }
}