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
    /// Logique d'interaction pour Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
          
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
         

        private void retour (object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
            this.Close();
        }
         


        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            A.Position = TimeSpan.Zero;
            A.Play();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            B.Position = TimeSpan.Zero;
            B.Play();
         }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            T.Position = TimeSpan.Zero;
            T.Play();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            TT.Position = TimeSpan.Zero;
            TT.Play();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            j.Position = TimeSpan.Zero;
            j.Play();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            h.Position = TimeSpan.Zero;
            h.Play();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            kh.Position = TimeSpan.Zero;
            kh.Play();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {

            d.Position = TimeSpan.Zero;
            d.Play();

        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            dd.Position = TimeSpan.Zero;
            dd.Play();
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            r.Position = TimeSpan.Zero;
            r.Play();

        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            z.Position = TimeSpan.Zero;
            z.Play();

        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            s.Position = TimeSpan.Zero;
            s.Play();
        }

        private void btn13_Click(object sender, RoutedEventArgs e)
        {
            ch.Position = TimeSpan.Zero;
            ch.Play();
        }

        private void btn14_Click(object sender, RoutedEventArgs e)
        {
            sa.Position = TimeSpan.Zero;
            sa.Play();
        }

        private void btn15_Click(object sender, RoutedEventArgs e)
        {
            dda.Position = TimeSpan.Zero;
            dda.Play();
        }

        private void btn16_Click(object sender, RoutedEventArgs e)
        {
            tt.Position = TimeSpan.Zero;
            tt.Play();
        }

        private void btn17_Click(object sender, RoutedEventArgs e)
        {
            tta.Position = TimeSpan.Zero;
            tta.Play();
        }

        private void btn18_Click(object sender, RoutedEventArgs e)
        {
            aa.Position = TimeSpan.Zero;
            aa.Play();
        }

        private void btn19_Click(object sender, RoutedEventArgs e)
        {
            gh.Position = TimeSpan.Zero;
            gh.Play();
        }

        private void btn20_Click(object sender, RoutedEventArgs e)
        {
          f.Position = TimeSpan.Zero;
          f.Play();
        }

        private void btn21_Click(object sender, RoutedEventArgs e)
        {
            fa.Position = TimeSpan.Zero;
            fa.Play();
        }

        private void btn22_Click(object sender, RoutedEventArgs e)
        {
           k.Position = TimeSpan.Zero;
           k.Play();
        }

        private void btn23_Click(object sender, RoutedEventArgs e)
        {
            l.Position = TimeSpan.Zero;
             l.Play();
        }

        private void btn24_Click(object sender, RoutedEventArgs e)
        {
           m.Position = TimeSpan.Zero;
           m.Play();
        }

        private void btn25_Click(object sender, RoutedEventArgs e)
        {
           n.Position = TimeSpan.Zero;
            n.Play();
        }

        private void btn26_Click(object sender, RoutedEventArgs e)
        {
            hha.Position = TimeSpan.Zero;
            hha.Play();
        }

        private void btn27_Click(object sender, RoutedEventArgs e)
        {
            w.Position = TimeSpan.Zero;
            w.Play();
        }

        private void btn28_Click(object sender, RoutedEventArgs e)
        {
            y.Position = TimeSpan.Zero;
            y.Play();
        }

        private void btn29_Click(object sender, RoutedEventArgs e)
        {
           hhha.Position = TimeSpan.Zero;
            hhha.Play();
        }

        private void btn30_Click(object sender, RoutedEventArgs e)
        {
           tttta.Position = TimeSpan.Zero;
            tttta.Play();

        }
    }
}
