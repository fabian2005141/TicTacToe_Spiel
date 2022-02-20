using System;
using System.IO;
using System.Windows;
//strg+k+e == :))))))


namespace Tic_Tac_Toe_Spiel
{
    internal class KIData : Window
    {
        public int[,] field = { { 1, 2, 3 }, { 6, 0, 0 }, { 0, 9, 0 } };
        public string put_together;
        public string n;
        //static int p = 0;
        static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TikTakToe_data/Kilearn.dat");
        static string path_dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TikTakToe_data");




        public void reader()
        {

            
            int p = 0;
            string build = File.ReadAllText(path);
            string[] buid_data = build.Split(',');

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    field[x, y] = Convert.ToInt32(buid_data[p]);
                    p++;
                }
            }
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine(field[x, 0]);
            }
        }

        public void Writer()
        {
            //Ausgeben des Spielfeldes ( array to String )
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    if (i == 3 && f == 3)
                    {
                        n = field[i, f].ToString();
                        n = n;
                        Console.WriteLine(n);
                        put_together += n;
                    }
                    else
                    {
                        n = field[i, f].ToString() + ",";
                        n = n;
                        Console.WriteLine(n);
                        put_together += n;
                    }
                }
            }

            put_together = put_together.Substring(0, put_together.Length - 1);
            Console.WriteLine(put_together);
            File.WriteAllText(path, put_together);
        }
    }
	
        //public void reader()
        //{
        //    string build = File.ReadAllText(path);
        //    string[] buid_data = build.Split(',');

        //    for (int x = 0; x < 3; x++)
        //    {
        //        for (int y = 0; y < 3; y++)
        //        {
        //            field[x, y] = Convert.ToInt32(buid_data[p]);
        //            p++;
        //        }
        //    }
        //    for (int x = 0; x < 3; x++)
        //    {
        //        Console.WriteLine(field[x, 0]);
        //    }
        //}

        //public void Writer()
        //{
        //    //Ausgeben des Spielfeldes ( array to String )
        //    for (int i = 0; i < field.GetLength(0); i++)
        //    {
        //        for (int f = 0; f < 3; f++)
        //        {
        //            if (i == 3 && f == 3)
        //            {
        //                n = field[i, f].ToString();
        //                n = n;
        //                Console.WriteLine(n);
        //                put_together += n;
        //            }
        //            else
        //            {
        //                n = field[i, f].ToString() + ",";
        //                n = n;
        //                Console.WriteLine(n);
        //                put_together += n;
        //            }
        //        }
        //    }
        //    put_together = put_together.Substring(0, put_together.Length - 1);
        //    Console.WriteLine(put_together);
        //    File.WriteAllText(path, put_together);
        //}

        
    

    
}
