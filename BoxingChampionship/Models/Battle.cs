using System;

namespace BoxingChampionship.Models
{
    public class Battle : IWithId
    {
        public Guid Id { get; set; }
        public string FirstBoxerName{ get; set; }
        public string SecondBoxerName { get; set; }
        public string WinnerName { get; set; }
        public string Battlefield { get; set; }
        public DateTime Date { get; set; } 
        public int AmountOfRounds { get; set; }
        public int RefereePoints { get; set; }
    }
}