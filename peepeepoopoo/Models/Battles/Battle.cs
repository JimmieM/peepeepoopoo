using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Battles;
using peepeepoopoo.Models.Pets;

namespace peepeepoopoo.Models.Battles
{
    public class Battle
    {
        public int Id;

        public Pet FirstPet;
        public Pet SecondPet;

        public List<Player.Player> FirstPetOwners { get => new List<Player.Player> { FirstPet.Player1, FirstPet.Player2 }; }
        public List<Player.Player> SecondPetOwners { get => new List<Player.Player> { SecondPet.Player1, SecondPet.Player2 }; }

        public Reward Reward;

        public DateTime StartDate;
        public DateTime EndDate;

        public Pet WinnerPet;

        public IBattleType Type;

        public Battle(
            int id,
            Pet pet1,
            Pet pet2,
            Reward reward,
            IBattleType type,
            DateTime startDate,
            DateTime endDate,
            Pet winnerPet)
        {
            Id = id;
            FirstPet = pet1;
            SecondPet = pet2;
            Reward = reward;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
            WinnerPet = winnerPet;
        }

        public Battle(
            int id,
            Pet pet1,
            Pet pet2,
            Reward reward,
            IBattleType type,
            DateTime startDate,
            DateTime endDate)
        {
            Id = id;
            FirstPet = pet1;
            SecondPet = pet2;
            Reward = reward;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
