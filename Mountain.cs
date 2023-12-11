using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evip_zh2
{
    public class Mountain : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        private int _height;
        private bool _didClimb;

        public void Notify (string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                Notify(nameof(Name));
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                Notify(nameof(Height));
            }
        }
        
        public bool DidClimb
        {
            get
            {
                return _didClimb;
            }
            set
            {
                _didClimb = value;
                Notify(nameof(DidClimb));
            }
        }

    }
}
