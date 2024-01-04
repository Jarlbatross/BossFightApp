namespace BossFight
{
    internal class GameCharacter
    {
        public string Name { get; set; }
        public int Health;
        public int Strength;
        public int Stamina;

        public GameCharacter(string name, int health, int strength, int stamina)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Stamina = stamina;
        }


        public void Fight(GameCharacter attacker, GameCharacter defender)
        {
            defender.Health -= attacker.Strength;
            attacker.Stamina -= 10;
            Console.WriteLine($"{attacker.Name} angrep {defender.Name} for {attacker.Strength} skade. {defender.Name} har {defender.Health} liv igjen.");
        }
        public void Recharge(int rechargeFactor)
        {
            Stamina += rechargeFactor * 5;
        }

    }

}
