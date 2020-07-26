using ProjectShopit.ShopViews;
using System.Windows;

namespace ProjectShopit.Views
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ItemlistButton_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new ItemList();
        }
    }
}
