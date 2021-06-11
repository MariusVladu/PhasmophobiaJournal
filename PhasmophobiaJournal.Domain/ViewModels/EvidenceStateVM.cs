using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PhasmophobiaJournal.Domain.ViewModels
{
    public class EvidenceStateVM : INotifyPropertyChanged
    {
        public string Evidence { get; set; }


        private string _state;
        public string State { 
            get { return _state; } 
            set
            {
                if (_state != value)
                {
                    _state = value;

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
