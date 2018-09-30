using System.Windows;
using Microsoft.Win32;

namespace Dedup
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

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            TreeViewForm form = new TreeViewForm();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
