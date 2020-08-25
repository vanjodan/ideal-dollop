using System;

namespace BoxingChampionship.Models
{
    public class Boxer : IWithId
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
// todo vi di rename all rankinMembers to rankinG