using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            
            Timer timer = new Timer(0);
            timer.TimeDisplaySec += Display.Secondsdis;
            
             
             
            
            timer.Start(0);
             
    
        }


    }
}
