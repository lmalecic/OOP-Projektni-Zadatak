using DAL;
using System.Configuration;
using System.Data;
using System.Windows;

namespace App_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IRepository<Config> ConfigRepository = RepositoryFactory.GetConfigRepository();

        public static Config Config { get; private set; } = ConfigRepository.Get();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            this.ShutdownMode = ShutdownMode.OnExplicitShutdown;

            if (!ConfigRepository.Exists())
            {
                SettingsWindow startupSettings = new();
                if (!(startupSettings.ShowDialog() ?? false))
                {
                    this.Shutdown();
                    return;
                }
            }

            this.ShutdownMode = ShutdownMode.OnMainWindowClose;
        }
    }

}
