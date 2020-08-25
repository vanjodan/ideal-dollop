using System;

namespace BoxingChampionship.Models
{
    public interface IWithId
    {
        Guid Id { get; set; }
    }
}

// todo move to proper place later