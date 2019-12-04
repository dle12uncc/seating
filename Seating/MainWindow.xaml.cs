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

namespace Seating
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainWindow.Height = 300;
            mainWindow.Width = 550;
        }

        private void FindSeat(String seatClass, int numPass, String seatPref)
        {
            int[,] firstArray = new int[4, 3];
            int[,] economyArray = new int[14, 5];

        }


        private void addPassengersButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Height = 550;
            mainWindow.Width = 550;

        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Close();
        }

        public void classDrop_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (classDrop.SelectedIndex == 0)
            {
                passengersDrop.Items.Clear();
                prefDrop.Items.Clear();
                passengersDrop.Items.Add("1");
                passengersDrop.Items.Add("2");
                prefDrop.Items.Add("Aisle");
                prefDrop.Items.Add("Window");
            }
            if (classDrop.SelectedIndex == 1)
            {
                passengersDrop.Items.Clear();
                prefDrop.Items.Clear();
                passengersDrop.Items.Add("1");
                passengersDrop.Items.Add("2");
                passengersDrop.Items.Add("3");
                prefDrop.Items.Add("Center");
                prefDrop.Items.Add("Window");
            }
        }

        private void showSeatingButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Width = 780;
            mainWindow.Height = 530;
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            showSeatingButton_Click(sender, e);
        }
    }

}
