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
                ChangeLanguage(lang);
            }
        }

        private void ChangeLanguage(string lang)
        {
            // Находим старый словарь ресурсов (ru или en)
            ResourceDictionary oldDict = Application.Current.Resources.MergedDictionaries
                .FirstOrDefault(d => d.Source != null && d.Source.OriginalString.Contains("Dict."));

            if (oldDict != null)
            {
                Application.Current.Resources.MergedDictionaries.Remove(oldDict);
            }

            // Загружаем новый словарь
            ResourceDictionary newDict = new ResourceDictionary();
            newDict.Source = new Uri($"Langs/Dict.{lang}.xaml", UriKind.Relative);

            Application.Current.Resources.MergedDictionaries.Add(newDict);

            // Пример перевода сообщения из кода (Задание п.2)
            string welcomeMsg = Application.Current.TryFindResource("m_Welcome") as string;
            // MessageBox.Show(welcomeMsg); 
        }

    }
}