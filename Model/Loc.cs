using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab_MVVM.Model
{
    public class Loc : INotifyPropertyChanged
    {
        // Ссылка на твои ресурсы (которые в корне проекта)
        public global::Lab_MVVM.Resources Strings => new global::Lab_MVVM.Resources();

        public event PropertyChangedEventHandler PropertyChanged;

        public void Update()
        {
            // Эта строка КРИТИЧЕСКИ важна. Она говорит XAML: "Эй, Strings изменились, перерисуй их!"
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Strings)));
        }

        public static Loc Instance { get; } = new Loc();
    }
}