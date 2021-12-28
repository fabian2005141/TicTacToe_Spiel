using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tic_Tac_Toe_Spiel
{
    internal class KIData
    {

        
            

        public void reader()
        {

           

            string[] data = File.ReadAllLines(@"D:\Dokumente\GitHub\TicTacToe_Spiel\Tic Tac Toe Spiel\Data\KiData.dat");
            int Length = data.Length;

            for (int i = 0; i < Length; i++){
            
            }


            


            
        }

        public void Writer()
        {

        }

        public class Array_Saver
        {
            public string[,] Daten { get; set; }
        }





    }
}
