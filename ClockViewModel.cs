using System;
using System.Text;
using System.ComponentModel;

class ClockViewModel : INotifyPropertyChanged
{
    private string _clockText = "00:00:00";
    private string _calenderText = "0000/00/00()";

    public String ClockText
    {
        get
        {
            return this._clockText;
        }
        set
        {
            this._clockText = value;
            this.NotifyPropertyChanged(nameof(ClockText));
            return;
        }
    }

        public String CalenderText
    {
        get
        {
            return this._calenderText;
        }
        set
        {
            this._calenderText = value;
            this.NotifyPropertyChanged(nameof(CalenderText));
            return;
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;
    private void NotifyPropertyChanged(String info)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}