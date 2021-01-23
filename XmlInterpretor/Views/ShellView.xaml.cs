using System.Windows;
using WpfApplication.ViewModels;

namespace WpfApplication.Views {
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : Window {
        public ShellView() {
            InitializeComponent();
            this.DataContext = new ShellViewModel();
        }
    }
}
