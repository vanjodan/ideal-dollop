using BoxingChampionship.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxingChampionship.Providers
{
    public class BattleProvider
    {
        public List<Battle> Get()
        {
            List<Battle> battles = null;

            using (var context = new BoxingChampionshipContext())
            {
                battles = context.Battles.ToList();
            }

            return battles;
        }

        public Battle GetById(Guid id)
        {
            Battle battle = null;

            using (var context = new BoxingChampionshipContext())
            {
                battle = context.Battles.FirstOrDefault(b => b.Id == id);
            }

            return battle;
        }
    }
}