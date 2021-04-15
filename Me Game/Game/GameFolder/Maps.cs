using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameFolder
{
    public class Maps
    {
        public static int NumMap = 0;

        private static string[] Map0 = {"###################################################",
                                        "#                    '                            #",
                                        "#                                    =            #",
                                        "#                                    =         ---#",
                                        "#                                    =            #",
                                        "#                *##+##              =            #",
                                        "#               *                    =            #",
                                        "#          #   *                     =            #",
                                        "#             *    '''      *        =            #",
                                        "#            *             * *                    #",
                                        "#        ######           *   *                   #",
                                        "#                        *     *         ~~~~     #",
                                        "########################################''''''''''#"};
        public static int Map0X = 2;
        public static int Map0Y = 11;

        private static string[] Map1 = {"####################################################",
                                        "#                                                  #",
                                        "#                                                  #",
                                        "#                      #######                     #",
                                        "#                                                  #",
                                        "#                                                  #",
                                        "# --                                           --  #",
                                        "#                                     ~~           #",
                                        "#                   #                              #",
                                        "#                                                  #",
                                        "#             #                                    #",
                                        "#    ~~~                      ~~~                  #",
                                        "#''''''''''''''''''''''''''''''''''''''''''''''''''#"};
        public static int Map1X = 26;
        public static int Map1Y = 2;

        private static string[] Map2 = {"###########'''######################################",
                                        "#''''''''                                          #",
                                        "#'''''''  #+                                      ##",
                                        "#''''''   '                                        #",
                                        "#'''''   '                                         #",
                                        "#''''   '                                          #",
                                        "#'''   '               ~                           #",
                                        "#'''   '                     ''     ~~~~           #",
                                        "#'''   '                 +#                        #",
                                        "#''   '                      ##                    #",
                                        "#''   '                                            #",
                                        "#   -          #~#                           ~     #",
                                        "#''''''''''''''''''''''''''''''''''''''''''''''''''#"};
        public static int Map2X = 50;
        public static int Map2Y = 1;

        private static string[] Map3 = {"####################################################",
                                        "#                   '''                            #",
                                        "#                   '''                            #",
                                        "#        #+#        '''                            #",
                                        "#                   ''' ##                         #",
                                        "#                   '''  '                         #",
                                        "#                   '''  '     ''             ######",
                                        "#                   '''  ''###*  '          '      #",
                                        "#                              #* '         '      #",
                                        "#                                * ''''''''''  ##  #",
                                        "#                                 *                #",
                                        "# -             ~~       #+        ####+#####      #",
                                        "#''''''''''''''''''''''''''''''''''''''''''''''''''#"};
        public static int Map3X = 48;
        public static int Map3Y = 5;

        private static string[] Map4 = {"####################################################",
                                        "####-###''    '+'                                  #",
                                        "#                 ' #            +*                #",
                                        "########''     ##   '              *             --#",
                                        "#                ##   '             *              #",
                                        "#                  ##   '            *             #",
                                        "#                    ##   ' ~         *            #",
                                        "#                      ##   '          *           #",
                                        "#                        ##   '         *          #",
                                        "#                          ##   '        ~         #",
                                        "#                            ##   '''''''''''''''''#",
                                        "#            ~                 ##                  #",
                                        "####################################################"};
        public static int Map4X = 48;
        public static int Map4Y = 11;

        private static string[] Map5 = {"#################################################'##",
                                        "#                                         ''       #",
                                        "#          +          =                ' *'  #'''  #",
                                        "#                     =                '* '  ''''  #",
                                        "#                     =                ''* '  '''  #",
                                        "#                     =                '' * '  ''  #",
                                        "#                     =                ' * '  '''  #",
                                        "#             ' '     =      '         '* '  ''''  #",
                                        "#             ' '            '         ''* '  '''  #",
                                        "#             ' '        #   '   +#    '' * '  ''  #",
                                        "#             ' '                      ''* '  '''  #",
                                        "#-            '~'                     ~'''*   '''~ #",
                                        "##''''''''''''''''''''''''''''''''''''######'''''''#"};
        public static int Map5X = 50;
        public static int Map5Y = 11;

        public static void EnumMap(bool NewMap)
        {
            if (NewMap)
            {
                if (NumMap + 1 != 7)
                    NumMap++;
                else
                    NumMap = 7;

                LevelTable.DrawLevel(NumMap);

                if (NumMap == 7)
                    NumMap = 1;
            }
                

            if (NumMap == 1)
            {
                CurrentMap = Map0;

                if (NewMap)
                {
                    Variables.XPlayerStart = Map0X;
                    Variables.YPlayerStart = Map0Y;
                }
                Variables.XPlayer = Variables.XPlayerStart;
                Variables.YPlayer = Variables.YPlayerStart;
            }
            if (NumMap == 2)
            {
                CurrentMap = Map1;

                if (NewMap)
                {
                    Variables.XPlayerStart = Map1X;
                    Variables.YPlayerStart = Map1Y;
                }

                Variables.XPlayer = Map1X;
                Variables.YPlayer = Map1Y;
            }
            if (NumMap == 3)
            {
                CurrentMap = Map2;

                if (NewMap)
                {
                    Variables.XPlayerStart = Map2X;
                    Variables.YPlayerStart = Map2Y;
                }

                Variables.XPlayer = Map2X;
                Variables.YPlayer = Map2Y;
            }
            if (NumMap == 4)
            {
                CurrentMap = Map3;

                if (NewMap)
                {
                    Variables.XPlayerStart = Map3X;
                    Variables.YPlayerStart = Map3Y;
                }

                Variables.XPlayer = Map3X;
                Variables.YPlayer = Map3Y;
            }
            if (NumMap == 5)
            {
                CurrentMap = Map4;

                if (NewMap)
                {
                    Variables.XPlayerStart = Map4X;
                    Variables.YPlayerStart = Map4Y;
                }

                Variables.XPlayer = Map4X;
                Variables.YPlayer = Map4Y;
            }
            if (NumMap == 6)
            {
                CurrentMap = Map5;

                if (NewMap)
                {
                    Variables.XPlayerStart = Map5X;
                    Variables.YPlayerStart = Map5Y;
                }

                Variables.XPlayer = Map5X;
                Variables.YPlayer = Map5Y;
            }
            ReDrawing.Draw();
            SpacePlayer.DownPlayer();
        }
        public static string[] CurrentMap;
    }
}
