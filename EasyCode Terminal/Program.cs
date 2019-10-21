using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCode_Terminal
{
    class Program
    {
        public static void export_to_web(string dir)
        {

        }
        static void Main(string[] args)
        {
            #region Before Starting visual
            
            #endregion

            start:
            Console.Clear();
            Console.Title = "EasyCode Terminal";
            Console.WriteLine("(c) 2020 Yunis Huseynzade");
            Console.WriteLine("Type \"help\" for help");
            Console.WriteLine();
            string input;
            do
            {
                Console.Write("EC>> ");
                input = Console.ReadLine();

                if (input=="clear")
                {
                    goto start;
                }
                else if (input =="help")
                {

                }
                else if (input == "export-to-web")
                {
                    Console.Write("...Enter directory to export:");
                    string dir = Console.ReadLine();
                    export_to_web(dir);
                }


            } while (input!="exit");
        }
    }
}
