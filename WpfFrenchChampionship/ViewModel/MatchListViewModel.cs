using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using SoccerRankingLib;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace WpfFrenchChampionship.ViewModel
{
    public class MatchListViewModel : ViewModel
    {
        private ObservableCollection<Match> matches;
        
        
       
        public MatchListViewModel(Ranking ranking)
        {
            matches = new ObservableCollection<Match>();
            //this._ranking.NewMatchRegistered += _ranking_NewMatchRegistered;
            ranking.NewMatchRegistered += new EventHandler<Ranking.MatchRegistrationEventArgs>(_ranking_NewMatchRegistered);

        }

        void _ranking_NewMatchRegistered(object sender, Ranking.MatchRegistrationEventArgs e)
        {
            //throw new NotImplementedException();
            matches.Add(e.NewMatch);
        }


        public INotifyPropertyChanged Matches
        {
           get
            {
                return matches;
            }

        }       
        

    }
}
