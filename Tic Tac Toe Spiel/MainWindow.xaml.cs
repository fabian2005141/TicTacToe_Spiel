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

namespace Tic_Tac_Toe_Spiel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static bool Is_winner()
        {
            return false;
        }



        public MainWindow()
        {
            InitializeComponent();
        }

        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            // Button button = ;
            Button button = sender as Button;
            
            Console.WriteLine("Hi");
            Console.ReadLine();
            
        }

        
    }
}
