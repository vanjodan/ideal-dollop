using BoxingChampionship.Models;
using BoxingChampionship.Providers;
using System;
using System.Linq;

namespace BoxingChampionship
{
    public class BoxerService
    {
        public bool Create(Boxer boxer)
        {
            using (var context = new BoxingChampionshipContext())
            {
                try
                {
                    boxer.Id = Guid.NewGuid();
                    context.Boxers.Add(boxer);
                    context.SaveChanges();
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