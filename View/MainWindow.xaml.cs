using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LanguageComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string lang = selectedItem.Tag.ToString();
                var culture = new CultureInfo(lang);

                // 1. Меняем культуру для генератора ресурсов
                Lab_MVVM.Resources.Culture = culture;

                // 2. Меняем культуру потока (для дат, чисел и т.д.)
                Thread.CurrentThread.CurrentUICulture = culture;
                Thread.CurrentThread.CurrentCulture = culture;

                // 3. ПИНАЕМ наш Loc, чтобы он обновил Strings в XAML
                Lab_MVVM.Model.Loc.Instance.Update();
            }
        }

    }
}