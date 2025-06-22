using Big_Finish_Tracker.Core;
using Big_Finish_Tracker.MVVM.ViewModel;
using Big_Finish_Tracker.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace Big_Finish_Tracker
{
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;
        /// <summary>
        /// Interaction logic for App.xaml
        /// </summary>
        public App()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<MainWindow>(provider => new MainWindow
            {
                DataContext = provider.GetRequiredService<MainViewModel>()
            });

            services.AddSingleton<MainViewModel>();
            services.AddSingleton<HomeViewModel>();
            services.AddSingleton<DiscoveryViewModel>();
            services.AddSingleton<INavigationService, NavigationService>();

            services.AddSingleton<Func<Type, ViewModel>>(serviceProvider => viewModelType => (ViewModel)serviceProvider.GetRequiredService(viewModelType));

            _serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
            base.OnStartup(e);
        }
    }
}
