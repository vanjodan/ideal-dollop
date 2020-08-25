using BoxingChampionship.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxingChampionship.Providers
{
    public class MainProvider
    {
        BattleProvider _battleProvider { get; }
        BoxerProvider _boxerProvider { get; }

        public MainProvider(BattleProvider battleProvider, BoxerProvider boxerProvider)
        {
            _battleProvider = battleProvider;
            _boxerProvider = boxerProvider;
        }

       public List<RankingMember> Get()
        {
            List<RankingMember> rankingMembers = new List<RankingMember>();

            List<Battle> battles = _battleProvider.Get();
            List<Boxer> boxers = _boxerProvider.Get();

            foreach (Boxer boxer in boxers)
            {
                List<Battle> boxerBattles = battles.Where(b => b.FirstBoxerName == boxer.Name ||
                    b.SecondBoxerName == boxer.Name).ToList();

                RankingMember rankingMember = new RankingMember();
                rankingMember.BoxerName = boxer.Name;
                rankingMember.AmountOfBattles = boxerBattles.Count();
                rankingMember.CurrentRank = boxerBattles.Where(b => b.WinnerName == boxer.Name).Count();

                rankingMembers.Add(rankingMember);
            }

            return rankingMembers;
        }
    }
}