using System;

namespace BoxingChampionship.Models
{
    public class RankingMember : IWithId
    {
        public Guid Id { get; set; }
        public string BoxerName { get; set; }
        public int CurrentRank { get; set; }
        public int AmountOfBattles { get; set; }
    }
}