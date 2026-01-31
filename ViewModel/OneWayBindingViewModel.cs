using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_MVVM.ViewModel
{
    class OneWayBindingViewModel : INotifyPropertyChanged
    {
        public string _textOWB = "Начальный текст";
        public string TextOWB
        {
            get { return _textOWB; }
            set { _textOWB = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
