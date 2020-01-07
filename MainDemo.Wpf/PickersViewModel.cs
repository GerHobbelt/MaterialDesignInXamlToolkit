using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MaterialDesignColors.WpfExample
{
    public class PickersViewModel : INotifyPropertyChanged
    {
        private DateTime _date;
        private DateTime _time;
        private DateTime _doubleBindedDate;
        private string _validatingTime;
        private DateTime? _futureValidatingDate;

        public PickersViewModel()
        {
            Date = DateTime.Now;
            Time = DateTime.Now;
            DoubleBindedDate = DateTime.Now;
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        public DateTime Time
        {
            get { return _time; }
            set
            {
                _time = value;
                OnPropertyChanged();
            }
        }

        public DateTime DoubleBindedDate
        {
            get { return _doubleBindedDate; }
            set
            {
                _doubleBindedDate = value;
                OnPropertyChanged();
            }
        }

        public string ValidatingTime
        {
            get { return _validatingTime; }
            set
            {
                _validatingTime = value;
                OnPropertyChanged();
            }
        }

        public DateTime? FutureValidatingDate
        {
            get { return _futureValidatingDate; }
            set
            {
                _futureValidatingDate = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
