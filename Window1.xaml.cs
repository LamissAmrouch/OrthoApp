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
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
          
         MyMediaElement.Position = TimeSpan.Zero;
            MyMediaElement.Play();
            //Sons.Play();
        }

      

        private void ExitButton_Click  (object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
           /* Sons.Position = TimeSpan.Zero;
            Sons.Play();*/

           
            Window2 win2 = new Window2();
            win2.Show();
            this.Close();
           

        }


        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Window3 win3 = new Window3();
            win3.Show();
            this.Close();
           


        }


        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Window4 win4 = new Window4();
            win4.Show();
            this.Close();
           
        }


        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Window5 win5 = new Window5();
            win5.Show();
            this.Close();

        }

        private void btn1_MD(object sender, MouseButtonEventArgs e)
        {
       
        }
    }
}
