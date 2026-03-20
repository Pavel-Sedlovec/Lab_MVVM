using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingSeb.Localization;
using CodingSeb.Localization.WPF;

namespace Lab_MVVM
{
    public static class LocalizationConfig
    {
        public static void Initialize()
        {
            var lp = CodingSeb.Localization.LocalizationProvider.Instance;


            // Заголовки вкладок в MainWindow
            lp.AddTranslation("TabDefault", "ru", "Привязка по умолчанию");
            lp.AddTranslation("TabDefault", "en", "Default Binding");

            lp.AddTranslation("TabTwoWay", "ru", "Двухсторонняя привязка");
            lp.AddTranslation("TabTwoWay", "en", "Two-Way Binding");

            lp.AddTranslation("TabOneTime", "ru", "Одноразовая привязка");
            lp.AddTranslation("TabOneTime", "en", "One-Time Binding");

            lp.AddTranslation("TabOneWay", "ru", "Односторонняя привязка");
            lp.AddTranslation("TabOneWay", "en", "One-Way Binding");

            lp.AddTranslation("TabTriggers", "ru", "Триггеры");
            lp.AddTranslation("TabTriggers", "en", "Triggers");

            // Пример текста внутри View (DefaultBindingView)
            lp.AddTranslation("InputPrompt", "ru", "Введите что-нибудь:");
            lp.AddTranslation("InputPrompt", "en", "Type something:");

            lp.CurrentLanguage = "ru"; // Язык при запуске
        }
    }
}
