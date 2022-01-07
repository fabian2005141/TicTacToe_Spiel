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
using System.Data;
using System.Threading;
using System.IO;

namespace Tic_Tac_Toe_Spiel
{
    internal class KIData : Window
    {
        public string put_together;
        public string n;
        static int p = 0;


        public void reader()
        {

           

            string[] data = File.ReadAllLines(@"D:\Dokumente\GitHub\TicTacToe_Spiel\Tic Tac Toe Spiel\Data\KiData.dat");
            int Length = data.Length;
            Console.WriteLine(Length);
            string Convert;
            string Buffer;
            


            for (int i = 0; i < Length; i++)
            {
                
                
                
            }


            


            
        }
        

        public void Writer()
        {

        }

        public class Array_Saver
        {
            public string[,] Daten { get; set; }
        }




        public void Ki_Main_System(string buildfield)
        {
            //Einlesen des Spielfeldes (string to array)
            int[,] field = { { 2, 0, 0 }, { 4, 0, 0 }, { 5, 0, 0 } };
            string[] buid_data = buildfield.Split(',');
            
            for (int x = 0; x < 3; x++){
                for (int y = 0; y < 3; y++) {
                    field[x, y] = Convert.ToInt32(buid_data[p]);
                    p++;
                }
            }





            
            //Ausgeben des Spielfeldes ( array to String )
            for (int i = 0; i < field.GetLength(0); i++) {
                for (int f = 0; f < 3; f++)
                {
                    n = field[i, f].ToString();
                    n = n;
                    Console.WriteLine(n);
                    put_together += n;
                }
            }
            Console.WriteLine(put_together);




        }




    }
}
