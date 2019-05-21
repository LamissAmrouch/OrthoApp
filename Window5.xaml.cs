using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Xml;

namespace WpfApplication5
{
    /// <summary>
    /// Logique d'interaction pour Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {    


        private XmlDocument monFichier = new XmlDocument();
        static private int CurrentQuestion;
        //private int i = 1;
        private int i = new Random().Next(20); //debut des questions l'indice de la premiere question
        private int rep ;
        private int totalQuestion;
        private string path;
        private XmlNode quest;
        private int cpt = 0 ;
        private XmlNode r ;
        private int score = 0;

        int nbQuest = 0;

      

        public int GetNbQuest()
        { return (nbQuest); }



        /*Affiche des images a partir d'un autre emplacement en donnant son chemin */
        private static BitmapImage GetImage(string imageUri)
        {
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(imageUri, UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            return bitmapImage;
        }


        /* Récupere la question et ses images associées a partir d'un fichier xml */
        private void GetQuestionFromFile(string path)
        {
            //Question.Inlines.Clear();
           // Question.Inlines.Add(new Run(monFichier.SelectSingleNode(path + "/Q").InnerText));
            String image1 = monFichier.SelectSingleNode(path + "/Prop1").InnerText;
            prop1.Source = GetImage(@"lettres/" + image1);
            String image2 = monFichier.SelectSingleNode(path + "/Prop2").InnerText;
            prop2.Source = GetImage(@"lettres/" + image2);
            String image3 = monFichier.SelectSingleNode(path + "/Prop3").InnerText;
            prop3.Source = GetImage(@"lettres/" + image3); 

       }
          




        /* constructeur de la classe */ 
        public Window5()
        {
            InitializeComponent();
          
            //Chargement du fichier XML
            monFichier.Load("Lettres.xml"); 

            Ok.IsEnabled = false;
            Next.IsEnabled = false;
            prop1.IsEnabled = false;
            prop2.IsEnabled = false;
            prop3.IsEnabled = false;


            prop1.Visibility = Visibility.Visible;
            prop2.Visibility = Visibility.Visible;
            prop3.Visibility = Visibility.Visible;
            Ok.Visibility = Visibility.Visible;
            Next.Visibility = Visibility.Visible;
            rectangle.Visibility = Visibility.Hidden;
            textBlock1.Visibility = Visibility.Hidden;
            boy.Visibility = Visibility.Visible;

            gift.Visibility = Visibility.Hidden;
            cup.Visibility = Visibility.Hidden;
            brain.Visibility = Visibility.Hidden;

           /* quest = monFichier.SelectSingleNode("//TestFinal/TotalQuestion");
            totalQuestion = int.Parse(quest.InnerText); */

            totalQuestion = 22; 
            t3.Visibility = Visibility.Hidden;
            t2.Visibility = Visibility.Hidden;
            t1.Visibility = Visibility.Hidden;

            f3.Visibility = Visibility.Hidden;
            f2.Visibility = Visibility.Hidden;
            f1.Visibility = Visibility.Hidden;

            //Sauvgarde de l'indice de la premiere question "utile pour le corigé"
            /* questionChoisi = monFichier.SelectSingleNode("//TestFinal/DebutQuestionsFaites");
             CurrentQuestion = int.Parse(questionChoisi.InnerText);
             //path = "//TestFinal/Probleme" + CurrentQuestion;*/
            CurrentQuestion = i ;
            path = "//TestFinal/Probleme" + i ;
            //Remplir le StackPanel par les images
            GetQuestionFromFile(path);

             
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
         

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            t3.Visibility = Visibility.Hidden;
            t2.Visibility = Visibility.Hidden;
            t1.Visibility = Visibility.Hidden;

            f3.Visibility = Visibility.Hidden;
            f2.Visibility = Visibility.Hidden;
            f1.Visibility = Visibility.Hidden; 


            Ok.IsEnabled = false;
            Next.IsEnabled = false;
            prop1.IsEnabled = false;
            prop2.IsEnabled = false;
            prop3.IsEnabled = false;

            c1.Visibility = Visibility.Collapsed;
           
            // on calcule le nombre de question 
            cpt++; 
            if (cpt == 10)
            {
                Ok.IsEnabled = false;
                Next.IsEnabled = false;
                prop1.Visibility = Visibility.Hidden;
                prop2.Visibility = Visibility.Hidden;
                prop3.Visibility = Visibility.Hidden;

                Ok.Visibility = Visibility.Hidden;
                Next.Visibility = Visibility.Hidden;
                boy.Visibility = Visibility.Hidden;

                if  ( score == 0 )
                {
                    rectangle.Visibility = Visibility.Visible;
                    textBlock1.Visibility = Visibility.Visible;
                    textBlock1.Text = " لقد تحصلت على العلامة " + " " + score + "/10" + " أعد المحاولة ";
                     brain.Visibility = Visibility.Visible;

                } 

                if (( score <= 5) && (score > 0 ) )
                {
                    rectangle.Visibility = Visibility.Visible;
                    textBlock1.Visibility = Visibility.Visible;
                    textBlock1.Text = "  أحسنت لقد تحصلت على العلامة " + " " + score +"/10";
                    gift.Visibility = Visibility.Visible;

                } 

                if ((score <= 10) && (score >5) )
                {
                    rectangle.Visibility = Visibility.Visible;
                    textBlock1.Visibility = Visibility.Visible;
                    textBlock1.Text = "  أحسنت لقد تحصلت على العلامة " + " " + score + "/10";
                    cup.Visibility = Visibility.Visible;
                }

            }


            //S'il est arrivé a la dernière case il remet CurrentQuestion a 1
            if (CurrentQuestion == totalQuestion) { CurrentQuestion = 1; }
            else CurrentQuestion++;

            path = "//TestFinal/Probleme" + CurrentQuestion;
            //Remplir le RichTextBox et le StackPanel par les images
            GetQuestionFromFile(path);
            //Incrémente le numéro de la question courante
            nbQuest++; 

        }


        private void Prop1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            rep = 1;
            Ok.IsEnabled = true;
           
            /* prop1.Height = 240 ;
              prop1.Width = 260;


              prop2.Height = 140;
              prop2.Width = 160;

              prop3.Height = 140;
              prop3.Width = 160; */
            //prop1.Margin = new Thickness(124, 815, 215, 285);
            //prop1.Margin = new Thickness(10, 0, 10, 0); 
        }
         


        private void Prop2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            rep = 2;
            Ok.IsEnabled = true;
            /*  prop2.Height = 160;
            prop2.Width = 180;

            prop1.Height = 140;
            prop1.Width = 160;

            prop3.Height = 140;
            prop3.Width = 160;*/
        }




        private void Prop3_MouseDown(object sender, MouseButtonEventArgs e)
        {   

            rep = 3;
            Ok.IsEnabled = true;
            /* prop3.Height = 160;
           prop3.Width = 180;

           prop2.Height = 140;
           prop2.Width = 160;

           prop1.Height = 140;
           prop1.Width = 160; */
        }



        private void Ok_Click(object sender, RoutedEventArgs e)
       {
             path = "//TestFinal/Probleme" + CurrentQuestion;
             r = monFichier.SelectSingleNode(path + "/R");
             int res = int.Parse(r.InnerText);


            Next.IsEnabled = true;

            if (res == rep)
           {  


                   Correct.Position = TimeSpan.Zero;
                   Correct.Play();

             
                score++;



            }
            else
            { 
                Wrong.Position = TimeSpan.Zero;
                Wrong.Play();
               
            }



            if (res == 1)
            {
                 t1.Visibility = Visibility.Visible;
                 t2.Visibility = Visibility.Hidden;
                 t3.Visibility = Visibility.Hidden;
                  f2.Visibility = Visibility.Visible;
                  f1.Visibility = Visibility.Hidden;
                 f3.Visibility = Visibility.Visible;
            }


            if ( res==2)
            {
                t2.Visibility = Visibility.Visible;
                t1.Visibility = Visibility.Hidden;
                t3.Visibility = Visibility.Hidden;

                 f1.Visibility = Visibility.Visible;
                f2.Visibility = Visibility.Hidden;
                f3.Visibility = Visibility.Visible;

            } 


            if ( res ==3 )
            {
                t3.Visibility = Visibility.Visible;
                t2.Visibility = Visibility.Hidden;
                t1.Visibility = Visibility.Hidden;

                f2.Visibility = Visibility.Visible;
                f3.Visibility = Visibility.Hidden;
                f1.Visibility = Visibility.Visible;

            }  

        }
         

        private void boy_MD(object sender, MouseButtonEventArgs e)
        {
            prop1.IsEnabled = true;
            prop2.IsEnabled = true;
            prop3.IsEnabled = true;

            if (CurrentQuestion == 1)
            {
               B.Position = TimeSpan.Zero;
               B.Play();

            }
             

            if (CurrentQuestion == 2)
            {
                T.Position = TimeSpan.Zero;
                T.Play();

            }


            if (CurrentQuestion == 3 )
            {
                aa.Position = TimeSpan.Zero;
                aa.Play();

            }

        
         if (CurrentQuestion == 4)
            {
                tt.Position = TimeSpan.Zero;
                tt.Play();


            }


            if (CurrentQuestion == 5)
            {
                T.Position = TimeSpan.Zero;
                T.Play();

            }

            

        if (CurrentQuestion == 6)
         {
             B.Position = TimeSpan.Zero;
             B.Play();

         }

           
            if (CurrentQuestion == 7)
            {
                kh.Position = TimeSpan.Zero;
                kh.Play();
            }



            if (CurrentQuestion == 8)
            {
                tta.Position = TimeSpan.Zero;
                tta.Play();
            }



            if (CurrentQuestion == 9)
            {
                dd.Position = TimeSpan.Zero;
                dd.Play();

            }

            if (CurrentQuestion == 10)
            {
                y.Position = TimeSpan.Zero;
                y.Play();

            }

            if (CurrentQuestion == 11)
            {
                z.Position = TimeSpan.Zero;
                z.Play();

            }


            if (CurrentQuestion == 12)
            {
                R.Position = TimeSpan.Zero;
                R.Play();

            }



            if (CurrentQuestion == 13)
            {
                h.Position = TimeSpan.Zero;
                h.Play();
            }



            if (CurrentQuestion == 14)
            {
                d.Position = TimeSpan.Zero;
                d.Play();
            }


            if (CurrentQuestion == 15)
            {
                dd.Position = TimeSpan.Zero;
                dd.Play();

            }
          

         if (CurrentQuestion == 16)
         {
             m.Position = TimeSpan.Zero;
             m.Play();
         }



         if (CurrentQuestion == 17)
         {
             tta.Position = TimeSpan.Zero;
             tta.Play();


         }



         if (CurrentQuestion == 18)
         {
             f.Position = TimeSpan.Zero;
             f.Play();


         }  


         if (CurrentQuestion == 19)
         {
             sa.Position = TimeSpan.Zero;
             sa.Play();
         }



         if (CurrentQuestion == 20)
         {  

             tta.Position = TimeSpan.Zero;
             tta.Play();

         }




         if (CurrentQuestion == 21)
         {
             w.Position = TimeSpan.Zero;
             w.Play();

         }




         if (CurrentQuestion == 22)
         {
             z.Position = TimeSpan.Zero;
             z.Play();
         }



        }
    }
}
