using System.ComponentModel;


namespace Api.ViewModel
{
    public class ViewModelMain : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChange(string Info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Info));
            }
        }
        string region;

        public string Region
        {
            get { return region; }
            set { region = value; NotifyPropertyChange("Region"); }
        }
        string summonerName;

        public string SummonerName
        {
            get { return summonerName; }
            set { summonerName = value; NotifyPropertyChange("SummonerName"); }
        }
    }
}
