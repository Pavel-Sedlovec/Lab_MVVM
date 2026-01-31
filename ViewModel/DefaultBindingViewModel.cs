using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_MVVM.ViewModel
{
    class DefaultBindingViewModel : INotifyPropertyChanged
    {
        public string _textDB = "Начальный текст";

        public string TextDB
        {
            get { return _textDB; }
            set { _textDB = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
