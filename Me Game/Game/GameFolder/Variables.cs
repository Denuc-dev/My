using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameFolder
{
    public class Variables
    {
        // Player symbol
        public static string Player = "0";

        // Player cordinate
        public static int XPlayer = 1;
        public static int YPlayer = 11;

        // Player start cordinate
        public static int XPlayerStart = 0;
        public static int YPlayerStart = 0;

        // Max space
        public static int MaxSpace = 5;
        public static int TrampolineSpace = 10;

        // Cursor position
        public static int XCursor = 0;
        public static int YCursor = 0;

        // Char firmly(background)
        public static string[] BackGround = { "#" , "*", "~" , "+"};
        public static string[] BackGroundSpaceDown = { "=" };
        public static string[] BackGroundDead = { "'" };
        public static string[] Finish = { "-" };

        // Counter player
        public static int Dead = 0;
        public static int Level = 1;
    }
}
