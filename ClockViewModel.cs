using System;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Media;

class ClockViewModel : INotifyPropertyChanged
{
    private string _clockText = "00:00:00";
    private string _calenderText = "0000/00/00()";
    private SolidColorBrush _clockColor = new SolidColorBrush(Colors.White);
    private SolidColorBrush _calenderColor = new SolidColorBrush(Colors.White);

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

    public SolidColorBrush ClockColor
    {
        get
        {
            return this._clockColor;
        }
        set
        {
            this._clockColor = value;
            this.NotifyPropertyChanged(nameof(ClockColor));
            return;
        }
    }

    public SolidColorBrush CalenderColor
    {
        get
        {
            return this._calenderColor;
        }
        set
        {
            this._calenderColor = value;
            this.NotifyPropertyChanged(nameof(CalenderColor));
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