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
using System.Windows.Shapes;

namespace WpfApplication5
{
    /// <summary>
    /// Logique d'interaction pour Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
           
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
         
        

        private void retour(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
            this.Close();
        }

        private void ellipse1_MD(object sender, MouseButtonEventArgs e)
        {
            ellipse1.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFE6E60E"));
            ellipse2.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFBBBBB5"));
            ellipse3.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFBBBBB5"));
            img1.Visibility = Visibility.Visible;
            img2.Visibility = Visibility.Collapsed;
            img3.Visibility = Visibility.Collapsed;
        }


        private void ellipse2_MD(object sender, MouseButtonEventArgs e)
        {
            ellipse2.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFE6E60E"));
            ellipse1.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFBBBBB5"));
            ellipse3.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFBBBBB5"));
            img2.Visibility = Visibility.Visible;
            img1.Visibility = Visibility.Collapsed;
            img3.Visibility = Visibility.Collapsed;
        }


        private void ellipse3_MD(object sender, MouseButtonEventArgs e)
        {
            ellipse3.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFE6E60E"));
            ellipse1.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFBBBBB5"));
            ellipse2.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFBBBBB5"));
            img2.Visibility = Visibility.Collapsed;
            img1.Visibility = Visibility.Collapsed;
            img3.Visibility = Visibility.Visible;

        }
    }
}
