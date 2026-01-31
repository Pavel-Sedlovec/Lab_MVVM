using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_MVVM.ViewModel
{
    public partial class DefaultBindingViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _textDB = "Начальный текст";
    }
}
