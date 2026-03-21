using CodingSeb.Localization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace Lab_MVVM.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public string CurrentLanguage
        {
            get => Loc.Instance.CurrentLanguage;
            set
            {
                if (Loc.Instance.CurrentLanguage != value)
                {
                    Loc.Instance.CurrentLanguage = value;
                    OnPropertyChanged(nameof(CurrentLanguage));
                }
            }
        }
        [RelayCommand]
        private void ChangeLanguage(string langCode)
        {
            CurrentLanguage = langCode;
        }



    }
}
