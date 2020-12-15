using System.Threading;
using System.Windows;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// TODO 11 FAIT!!!: Ajouter les ressources linguistiques au projet
        public App()
        {
            var lang = WeatherApp.Properties.Settings.Default.language;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
        }
        /// TODO 12 FAIT!!!: Charger la langue d'affichage

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ApplicationView app = new ApplicationView();


            app.Show();

        }
    }
}
