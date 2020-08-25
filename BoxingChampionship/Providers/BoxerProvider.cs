using BoxingChampionship.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxingChampionship.Providers
{
    public class BoxerProvider
    {
        public List<Boxer> Get()
        {
            List<Boxer> boxers = null;

            using (var context = new BoxingChampionshipContext())
            {
                boxers = context.Boxers.ToList();
            }

            return boxers;
        }

        public Boxer GetById(Guid id)
        {
            Boxer boxer = null;

            using (var context = new BoxingChampionshipContext())
            {
                boxer = context.Boxers.FirstOrDefault(b => b.Id == id);
            }

            return boxer;
        }
    }
}