using BoxingChampionship.Models;
using System;
using System.Linq;

namespace BoxingChampionship
{
    public class BattleService
    {
        public bool Create(Battle battle)
        {
            if (battle.Date == default)
            {
                battle.Date = DateTime.Now;
            }

            using (var context = new BoxingChampionshipContext())
            {
                try
                {
                    battle.Id = Guid.NewGuid();
                    context.Battles.Add(battle);
                    context.SaveChanges();
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }

        public bool Delete(Guid id)
        {
            using (var context = new BoxingChampionshipContext())
            {
                try
                {
                    Battle battleToDelete = context.Battles.FirstOrDefault(b => b.Id == id);

                    if (battleToDelete != null)
                    {
                        context.Battles.Remove(battleToDelete);
                        context.SaveChanges();
                    }
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }
    }
}