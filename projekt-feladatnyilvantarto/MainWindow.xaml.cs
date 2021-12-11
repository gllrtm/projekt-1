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

namespace projekt_feladatnyilvantarto
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

        //1.feladat

        // a)

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            feladatListaLb.Items.Add(feladatSzovTb.Text);
            
        }


        // b)

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            while (feladatListaLb.SelectedItems.Count > 0)
            {
                string feladat = (string)feladatListaLb.SelectedItems[0];
                toroltFeladatListaLb.Items.Add(feladat);
                feladatListaLb.Items.Remove(feladat);
            }
            
        }


        //c)

        private void feladatListaLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string kijeloltSzoveg = (string)feladatListaLb.SelectedItems[0];
            feladatSzovTb.Text = kijeloltSzoveg;

        }


        // d)

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }



        //2. feladat

        // a)

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            while (toroltFeladatListaLb.SelectedItems.Count > 0)
            {
                string feladat = (string)toroltFeladatListaLb.SelectedItems[0];
                feladatListaLb.Items.Add(feladat);
                toroltFeladatListaLb.Items.Remove(feladat);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            toroltFeladatListaLb.Items.RemoveAt(toroltFeladatListaLb.Items.IndexOf(toroltFeladatListaLb.SelectedItem));
        }

    }
}
