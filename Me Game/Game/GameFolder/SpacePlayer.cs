using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game.GameFolder
{
    public class SpacePlayer
    {
        public static int Num { get; set; }

        public static void Start()
        {
            int NumSpace = Variables.MaxSpace;

            try
            {
                if ((int)Num == 0)
                    NumSpace = Variables.MaxSpace;
                else if ((int)Num == 1)
                    NumSpace = Variables.TrampolineSpace;
            }
            catch (NullReferenceException){}

            ShiftVariable.SpaceThread = true;

            for (int append = 0; append < NumSpace - 1; append++)
            {
                ReDrawing.Draw();

                if (Collision.UpSpace())
                    break;

                Variables.YPlayer--;
                
                for (int fps = 0; fps < 25; fps++)
                {
                    ReDrawing.Draw();

                    if(Num == 0)
                        Thread.Sleep(1);
                }
            }

            new Thread(DownPlayer).Start();

            ShiftVariable.SpaceThread = false;
        }
        public static void DownPlayer()
        {

            ShiftVariable.SpaceThread = true;

            while (true)
            {
                ReDrawing.Draw();

                if (Collision.DownSpace())
                    break;

                Variables.YPlayer++;

                for (int fps = 0; fps < 25; fps++)
                {
                    ReDrawing.Draw();
                    Thread.Sleep(1);
                }
            }

            ShiftVariable.SpaceThread = false;
        }
    }
}
