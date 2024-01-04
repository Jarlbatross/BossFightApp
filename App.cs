namespace BossFight
{
    internal class App
    {
        public void Play(GameCharacter hero, GameCharacter boss) { 
        while (boss.Health > 0 && hero.Health > 0)
            {
                boss.Strength = rng(0, 31);
                if (hero.Stamina <= 0)
                {
                    hero.Recharge(4);
                    Console.WriteLine("Hero is resting");
                    Timer();
                }
                else
                {
                    hero.Fight(hero, boss);
                    Timer();
                }

                if (boss.Stamina <= 0) { 
                    boss.Recharge(1);
                    Console.WriteLine("Boss is resting");
                    Timer();
                }
                else 
                { 
                    boss.Fight(boss, hero);
                    Timer();
                }
                CheckGameState(hero, boss);
            }
        }

        public void CheckGameState(GameCharacter hero, GameCharacter boss)
        {
            if (hero.Health <= 0)
            {
                Console.WriteLine("Spillet er over. Du tapte.");
            }
            else if (boss.Health <=0 )
            {
                Console.WriteLine("Du drepte bossen, bra jobbet");
            }
        }
        public int rng(int min, int max) {
            var rand = new Random();
            var bossStrength = rand.Next(min, max);
            return bossStrength;
        }

        public void Timer()
        {
            Thread.Sleep(1000);
        }

    }
}
