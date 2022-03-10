using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //Вывести колличество прошедших секунд в классе Display
    internal class Timer
    {
     public delegate void TimeDisplay(int sec);
        public event TimeDisplay TimeDisplaySec;   
        private int sec;

        public Timer(int sec)
        {
            Sec = sec;
        }

        public int Sec { get => sec; set => sec = value; }

        
        
        public void Start(int sec)
        {
            for (int i = 0; i < 100000; i++)
            {
                Thread.Sleep(1000);        
                TimeDisplaySec.Invoke(sec);
                sec+=1;
               
            }
        }
        
    
    }
}