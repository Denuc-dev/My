using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game.GameFolder
{
    public class ReTitle
    {
        public static void Save()
        {
            for (int append = 0; append <= 7; append++)
            {
                Thread.Sleep(250);
                Console.Title = "! Saved !";
                Thread.Sleep(250);
                Console.Title = "";
            }

            Counter();

            ShiftVariable.ReSaveTitleThread = false;
        }
        public static void Counter()
        {
            Console.Title = "Dead - " + Variables.Dead + " | Level - " + Variables.Level + " \\ 6";
        }
    }
}
