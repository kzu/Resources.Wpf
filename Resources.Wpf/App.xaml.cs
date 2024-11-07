using System.Globalization;
using System.Windows;

namespace Resources.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture = new("es-AR");
        }
    }
}
