using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Avg_of_University
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            int cnt = 1;
            List<double> listNum = new List<double>();
            List<string> listName = new List<string>();
            List<int> listMod = new List<int>();
            
            do
            {
                /*
                Console.WriteLine("Please Insert Lesseon {0} Name:    ", cnt);
                string tmpCHK = Console.ReadLine();
                if (tmpCHK == "0")
                    break;

                listName.Add(tmpCHK);
                */

                Console.WriteLine("Please Insert Lesseon {0} Grade:    ", cnt);
                double tmpCHK = Convert.ToDouble(Console.ReadLine());
                if (tmpCHK < 0 || tmpCHK > 20)
                    break;

                listNum.Add(tmpCHK);

                Console.WriteLine("\r\nPlease Insert Lesseon {0} Module:    ", cnt);
                listMod.Add(Convert.ToInt32(Console.ReadLine()));

                cnt++;
                Console.Clear();

            } while (true);

            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Green;

            Console.WriteLine("You have {0} items in your list", listNum.Count);

            //int tmpSum = SumModules(listMod);
            double fnMod = GetAvg(SumModules(listMod), listMod, listNum, listName);

            Console.CursorSize = 70;
            Console.WriteLine("\r\nYour final module is \"{0}\"", fnMod);

            Console.ReadKey();


        }





        private static double GetAvg(int sumMod, List<int> Mod, List<double> Num, List<string> Name)
        {
            double calculator = 0;

            for (int i = 0; i < Num.Count; i++)
            {
                calculator += (double)Num[i] * Mod[i];
            }
            double fnModule = (double)calculator / (double)sumMod;

            return fnModule;

        }

        private static int SumModules(List<int> Mod)
        {
            int Sum = 0;

            for (int i = 0; i < Mod.Count; i++)
            {
                Sum += Mod[i];
            }

            return Sum;

        }
    }
}
