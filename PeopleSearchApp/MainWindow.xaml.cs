using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PeopleSearchApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller controller;

        public MainWindow()
        {
            InitializeComponent();
            controller = new Controller(this);
        }

        public void viewDatabase()
        {
            searchText.Visibility = Visibility.Hidden;
            searchButton.Visibility = Visibility.Hidden;
            searchLabel.Visibility = Visibility.Hidden;
            dataGrid.Visibility = Visibility.Visible;
        }

        public void viewSearchForm()
        {
            searchText.Visibility = Visibility.Visible;
            searchButton.Visibility = Visibility.Visible;
            searchLabel.Visibility = Visibility.Visible;
            dataGrid.Visibility = Visibility.Hidden;
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            controller.runSearch(searchText.Text);
        }
    }
}
