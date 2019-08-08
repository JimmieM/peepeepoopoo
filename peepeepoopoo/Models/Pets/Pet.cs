using System;
using System.Linq;
using System.Collections.Generic;
using peepeepoopoo.Models.Statistics;

namespace peepeepoopoo.Models.Pets
{
    public class Pet
    {
        public int Id;

        public Player.Player Player1;
        public Player.Player Player2;

        public Creature Creature;

        public readonly List<Creatures.CreatureAttack> Attacks;

        public string Name;

        public bool Dead;

        public Battles.Battle Battle;

        public DateTime LastUpdate;

        public DateTime LastFed;

        public DateTime LastWater;

        public Strength Strength;
        public Agility Agility;
        public Energy Energy;
        public Health Health;
        public Happiness Happiness;

        public int Overfeeding;
        public int HoursSlept;

        public DateTime SleepUntil;

        public Pet() { }

        public bool BusyInBattle()
        {
            return false;
        }

        public bool AddAttack(Creatures.CreatureAttack attack)
        {
            var exist = Attacks.First(findAttack => findAttack.Id.Equals(attack.Id));
            if(exist == null)
            {
                Attacks.Add(attack);
                return true;
            }
            return false;
        }

        public static Pet ConcreteStarterPet(Creature creature)
        {
            return CreatePet(creature, "");
        }

        public static Pet ConcreteStarterPet(Creature creature, string name)
        {
            return CreatePet(creature, name);
        }

        private static Pet CreatePet(Creature creature, string name)
        {
            var pet = new Pet
            {
                Creature = creature,
                Agility = new Agility(50),
                Energy = new Energy(50),
                Health = new Health(100),
                Happiness = new Happiness(75),
                LastUpdate = DateTime.Now,
                Strength = new Strength(50),
                Name = name
            };
            return pet;
        }

        public Pet(
            int id,
            Player.Player player1,
            Player.Player player2,
            Creature creature,
            List<Creatures.CreatureAttack> attacks,
            string name,
            bool dead,
            Battles.Battle battle,
            DateTime lastUpdate,
            DateTime lastFed,
            DateTime lastWater,
            Strength strength,
            Agility agility,
            Energy energy,
            Health health,
            Happiness happiness,
            int overfeeding,
            int hoursSlept)
        {
            Id = id;
            Player1 = player1;
            Player2 = player2;
            Creature = creature;
            Attacks = attacks;
            Name = name;
            Dead = dead;
            Battle = battle;
            LastUpdate = lastUpdate;
            LastFed = lastFed;
            LastWater = lastWater;
            Strength = strength;
            Agility = agility;
            Energy = energy;
            Health = health;
            Happiness = happiness;
            Overfeeding = overfeeding;
            HoursSlept = hoursSlept;
        }

        public Pet(
            int id,
            Player.Player player1,
            Creature creature,
            List<Creatures.CreatureAttack> attacks,
            string name,
            bool dead,
            Battles.Battle battle,
            DateTime lastUpdate,
            DateTime lastFed,
            DateTime lastWater,
            Strength strength,
            Agility agility,
            Energy energy,
            Health health,
            Happiness happiness,
            int overfeeding,
            int hoursSlept)
        {
            Id = id;
            Player1 = player1;
            Creature = creature;
            Attacks = attacks;
            Name = name;
            Dead = dead;
            Battle = battle;
            LastUpdate = lastUpdate;
            LastFed = lastFed;
            LastWater = lastWater;
            Strength = strength;
            Agility = agility;
            Energy = energy;
            Health = health;
            Happiness = happiness;
            Overfeeding = overfeeding;
            HoursSlept = hoursSlept;
        }
    }
}
