using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_MVVM.ViewModel
{
    public partial class OneTimeBindingViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _textOTB = "424";
    }
}
