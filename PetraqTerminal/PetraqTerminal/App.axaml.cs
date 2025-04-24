using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using PetraqTerminal.ViewModels;
using PetraqTerminal.Views;
using System.Globalization;

namespace PetraqTerminal
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            CultureInfo.CurrentCulture = new CultureInfo("ar-DZ");
            ChangeCulture(CultureInfo.CurrentCulture);
            AvaloniaXamlLoader.Load(this);
        }
        
        public override void OnFrameworkInitializationCompleted()
        {
            // Register common services
            var collection = new ServiceCollection();
            collection.AddCommonServices();

            var services = collection.BuildServiceProvider();

            var vm = services.GetRequiredService<MainViewModel>();
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = vm
                };
            }
            else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
            {
                singleViewPlatform.MainView = new MainView
                {
                    DataContext = vm
                };
            }

            base.OnFrameworkInitializationCompleted();
        }


        private static void ChangeCulture(CultureInfo cultureInfo)
        {
            Lang.Resources.Culture = cultureInfo;
        }

    }
}