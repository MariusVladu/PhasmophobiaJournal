using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PhasmophobiaJournal.Domain.ViewModels
{
    public class MainPageVM : INotifyPropertyChanged
    {
        public ObservableCollection<EvidenceStateVM> Evidences { get; set; }

        private string _possibleGhosts;
        public string PossibleGhosts
        {
            get { return _possibleGhosts; }
            set
            {
                if (_possibleGhosts != value)
                {
                    _possibleGhosts = value;

                    OnPropertyChanged();
                }
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
