using CodingSeb.Localization;
using CodingSeb.Localization.Loaders;
using Lab_MVVM.ViewModel;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;

namespace Lab_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var loader = LocalizationLoader.Instance;

            loader.FileLanguageLoaders.Add(new JsonFileLoader());

            string localizationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources2", "Localization");

            if (Directory.Exists(localizationPath))
            {
                loader.AddDirectory(localizationPath);
            }

            Loc.Instance.CurrentLanguage = "ru";
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var vm = new MainViewModel();
            var mainWindow = new MainWindow(vm);
            mainWindow.Show();
        }
    }

}
