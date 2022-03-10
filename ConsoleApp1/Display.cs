using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Display
    {
   

        private int Sec;

        public Display(int sec)
        {
            this.sec = sec;
        }

        public int sec { get => Sec; set => Sec = value; }
        public static void Secondsdis(int sec)
        {

            Console.WriteLine("прошло " + sec + " секунд");
        }
 


    }
}
