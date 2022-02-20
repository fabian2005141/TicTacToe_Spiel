using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.IO;


namespace Tic_Tac_Toe_Spiel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // 1 = X || 2 = O
        static int Draw = 2;
        static int zug = 0;
        static string dran;
        public bool debugmode = false;
        static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TikTakToe_data/Kilearn.dat");
        static string path_dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TikTakToe_data");

        bool is_winner()
        {
            if ((B1.Content == B2.Content) && (B2.Content == B3.Content) && B1.Content != "") { return true; }
            if ((B4.Content == B5.Content) && (B5.Content == B6.Content) && B5.Content != "") { return true; }
            if ((B7.Content == B8.Content) && (B8.Content == B9.Content) && B7.Content != "") { return true; }

            if ((B1.Content == B4.Content) && (B4.Content == B7.Content) && B1.Content != "") { return true; }
            if ((B2.Content == B5.Content) && (B5.Content == B8.Content) && B2.Content != "") { return true; }
            if ((B3.Content == B6.Content) && (B6.Content == B9.Content) && B3.Content != "") { return true; }

            if ((B1.Content == B5.Content) && (B5.Content == B9.Content) && B1.Content != "") { return true; }
            if ((B3.Content == B5.Content) && (B5.Content == B7.Content) && B3.Content != "") { return true; }

            return false;
        }

        //Basisspiel (multiplayer ohne KI)
        public MainWindow()
        {
            InitializeComponent();
            IfFile();
            Clear();

        }
        public void New_game(object sender, RoutedEventArgs e)
        {
            Clear();
            Draw = 1;
            zug = 0;
            dran = null;

        }


        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            if (zug <= 9 || is_winner() == false)
            {

                Console.WriteLine("Button Klick Alle Variablen:" + zug + Draw);
                if (Draw == 1 && button.Content == "") { button.Content = "X"; dran = "X"; zug++; Draw++; } else if (Draw == 2 && button.Content == "") { zug++; dran = "O"; Draw--; button.Content = "O"; }
            }

            if (is_winner() == true)
            {
                Draw = 0;
                if (dran == "O") { O.Content = "O is Winner"; }
                else
                if (dran == "X") { X.Content = "X is Winner"; }

            }//else if (zug == 9) { Draw = 0; .Content = "Unendschieden"; }


        }

        public void Clear()
        {
            B1.Content = "";
            B2.Content = "";
            B3.Content = "";
            B4.Content = "";
            B5.Content = "";
            B6.Content = "";
            B7.Content = "";
            B8.Content = "";
            B9.Content = "";
            O.Content = "O :";
            X.Content = "X :";

            

        }

        //Exit Button
        public void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }



        //Debug function
        public void Debug(object sender, RoutedEventArgs e)
        {


            //KIData Data = new KIData();
            KIData Ki_Data = new KIData();
            //Dat.Ki_Main_System();
            //Ki_Data.Writer();
            //Ki_Data.reader();
            updater();
           



        }



        // Ki integration
        public void Ki_manege()
        {
            return;
        }


        // funktion für die KI um zu setzen
        public void KI_Set(int Feld, string content)
        {
            if (is_winner() == false)
            {
                //makieren und STRG + r + r !!!
                Dictionary<int, Button> Button_dict = new Dictionary<int, Button>();
                Button_dict.Add(1, B1);
                Button_dict.Add(2, B2);
                Button_dict.Add(3, B3);
                Button_dict.Add(4, B4);
                Button_dict.Add(5, B5);
                Button_dict.Add(6, B6);
                Button_dict.Add(7, B7);
                Button_dict.Add(8, B8);
                Button_dict.Add(9, B9);

                Button_dict[Feld].Content = Content;
            }
            else
            {
                return;
            }
        }

        

        public void updater()
        {
            string pt = "";
            string xx;
            
            Dictionary<int, Button> Button_dict_ki = new Dictionary<int, Button>();
            Button_dict_ki.Add(1, B1);
            Button_dict_ki.Add(2, B2);
            Button_dict_ki.Add(3, B3);
            Button_dict_ki.Add(4, B4);
            Button_dict_ki.Add(5, B5);
            Button_dict_ki.Add(6, B6);
            Button_dict_ki.Add(7, B7);
            Button_dict_ki.Add(8, B8);
            Button_dict_ki.Add(9, B9);


            for (int i = 1; i < Button_dict_ki.Count + 1; i++)
            {
                if (Button_dict_ki[i].Content == "X")
                {
                    xx = Convert.ToString(1);

                }
                else if (Button_dict_ki[i].Content == "O")
                {
                    xx = Convert.ToString(2);

                }
                else if (Button_dict_ki[i].Content == "")
                {
                    xx = Convert.ToString(0);

                }
                else
                {
                    MessageBoxResult messageBoxResult = MessageBox.Show("Error 404, Ki Data Are Not Correct!!");
                    Environment.Exit(0);
                }

                 //pt += xx + ",";
                 KIData kidata = new KIData();
                 kidata.reader();
                 Console.WriteLine(pt);

            }

            //Console.WriteLine(pt.Length);
            pt = pt.Substring(0, pt.Length - 1);
            File.WriteAllText(path, pt);
            Console.WriteLine(pt);

        }


        //schaut ob der path existiert und erstellt wenn nötig Dateien
        static void IfFile()
        {
            if (!File.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path_dir);
                File.WriteAllText(path, "");
            }
        }




    }
}
