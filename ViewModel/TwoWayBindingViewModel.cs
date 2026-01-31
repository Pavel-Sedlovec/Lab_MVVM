using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_MVVM.ViewModel
{
    class TwoWayBindingViewModel : INotifyPropertyChanged
    {
        public string _textTWB = "Начальный текст";
        public string TextTWB
        {
            get { return _textTWB; }
            set { _textTWB = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
