﻿using System;
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
using System.Data;
using System.Threading;


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


        public MainWindow()
        {
            InitializeComponent();
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
                if(Draw == 1 && button.Content == "") { button.Content = "X"; dran = "X"; zug++; Draw++; }else if(Draw == 2 && button.Content == "") { zug++; dran = "O"; Draw--; button.Content = "O"; }
            }
            
            if(is_winner() == true)
            {
              Draw = 0;
              if (dran == "O") { O.Content = "O is Winner"; }else 
              if(dran == "X") { X.Content = "X is Winner"; }

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

        public void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        
        public void Debug(object sender, RoutedEventArgs e)
        {


            //KIData Data = new KIData();
            KIData Ki_Data = new KIData();
            //Dat.Ki_Main_System();
            //Ki_Data.Writer();
            Ki_Data.reader();

           


        }


        public void Ki_manege()
        {
            return;
        }


        public void KI_Set(int Feld)
        {
            if (is_winner() == false)
            {

            }
            else
            {
                return;
            }

        }
        
        
    }
}
