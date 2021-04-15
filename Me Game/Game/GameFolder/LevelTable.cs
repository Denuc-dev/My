using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game.GameFolder
{
    public class LevelTable
    {
        private static void Level1()
        {
            Console.Clear();

            Console.WriteLine("                                                    ");
            Console.WriteLine("                                                    ");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("###################  ###  #  ### ###################");
            Console.WriteLine("###################  ###  #  #   ###################");
            Console.WriteLine("###################  ###  #  ### ###################");
            Console.WriteLine("###################  ###  #  ### ###################");
            Console.WriteLine("###################    ##   #### ###################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("                                                    ");
            Console.WriteLine("                                                    ");
        }
        private static void Level2()
        {
            Console.Clear();

            Console.WriteLine("                                                    ");
            Console.WriteLine("                                                    ");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("###################  ###  #  #   ###################");
            Console.WriteLine("###################  ###  #  # # ###################");
            Console.WriteLine("###################  ###  #  ### ###################");
            Console.WriteLine("###################  ###  #  ## ####################");
            Console.WriteLine("###################    ##   ##   ###################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("                                                    ");
            Console.WriteLine("                                                    ");
        }
        private static void Level3()
        {
            Console.Clear();

            Console.WriteLine("                                                    ");
            Console.WriteLine("                                                    ");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("###################  ###  #  #   ###################");
            Console.WriteLine("###################  ###  #  # # ###################");
            Console.WriteLine("###################  ###  #  ##  ###################");
            Console.WriteLine("###################  ###  #  # # ###################");
            Console.WriteLine("###################    ##   ##   ###################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("                                                    ");
            Console.WriteLine("                                                    ");
        }
        private static void Level4()
        {
            Console.Clear();

            Console.WriteLine("                                                    ");
            Console.WriteLine("                                                    ");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("###################  ###  #  # # ###################");
            Console.WriteLine("###################  ###  #  # # ###################");
            Console.WriteLine("###################  ###  #  #   ###################");
            Console.WriteLine("###################  ###  #  ### ###################");
            Console.WriteLine("###################    ##   #### ###################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("                                                    ");
            Console.WriteLine("                                                    ");
        }
        private static void Level5()
        {
            Console.Clear();

            Console.WriteLine("                                                    ");
            Console.WriteLine("                                                    ");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("###################  ###  #  #   ###################");
            Console.WriteLine("###################  ###  #  # #####################");
            Console.WriteLine("###################  ###  #  #   ###################");
            Console.WriteLine("###################  ###  #  ### ###################");
            Console.WriteLine("###################    ##   ##   ###################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("                                                    ");
            Console.WriteLine("                                                    ");
        }
        private static void Level6()
        {
            Console.Clear();

            Console.WriteLine("                                                    ");
            Console.WriteLine("                                                    ");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("###################  ###  #  #   ###################");
            Console.WriteLine("###################  ###  #  # #####################");
            Console.WriteLine("###################  ###  #  #   ###################");
            Console.WriteLine("###################  ###  #  # # ###################");
            Console.WriteLine("###################    ##   ##   ###################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("                                                    ");
            Console.WriteLine("                                                    ");
        }
        public static void Finish()
        {
            Console.Clear();

            Console.WriteLine("                                                    ");
            Console.WriteLine("                                                    ");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("###########     #  #  ##  #  #     #  #  ###########");
            Console.WriteLine("###########   ######   #  ####  ####  #  ###########");
            Console.WriteLine("###########     #  #      #  #     #     ###########");
            Console.WriteLine("###########   ###  #  #   #  ####  #  #  ###########");
            Console.WriteLine("###########   ###  #  ##  #  #     #  #  ###########");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("                                                    ");
            Console.WriteLine("                                                    ");
        }
        public static void DrawLevel(int level)
        {
            if (level == 1)
                Level1();
            else if (level == 2)
                Level2();
            else if (level == 3)
                Level3();
            else if (level == 4)
                Level4();
            else if (level == 5)
                Level5();
            else if (level == 6)
                Level6();
            else if (level == 7)
                Finish();

            Thread.Sleep(4000);
        }
    }
}
