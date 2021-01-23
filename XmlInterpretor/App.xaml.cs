using System;
using System.Windows;

namespace XmlInterpretor {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {

            this.StartupUri = new Uri("Views/ShellView.xaml", UriKind.Relative);

        }
    }
}
