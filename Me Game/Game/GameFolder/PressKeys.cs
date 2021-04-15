using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game.GameFolder
{
    public class PressKeys
    {
        public static Thread ThreadingSpace;

        public static void Start()
        {
            do
            {
                Console.SetCursorPosition(Variables.XCursor, Variables.YCursor); // Set cursor position

                ConsoleKeyInfo PressedKey = Console.ReadKey(); // Player press key

                SoundPlayer player = new SoundPlayer();

                switch (PressedKey.Key)
                {
                    case ConsoleKey.LeftArrow:

                        
                        player.Stream = GameFolder.Misc.Music.run;
                        player.Play();

                        Collision.Left();
                        
                        break;

                    case ConsoleKey.RightArrow:

                        player.Stream = GameFolder.Misc.Music.run;
                        player.Play();

                        Collision.Right();

                        break;
                    
                    case ConsoleKey.Spacebar:

                        if (!ShiftVariable.SpaceThread)
                        {
                            player.Stream = GameFolder.Misc.Music.smolJump;
                            player.Play();

                            SpacePlayer.Num = 0;
                            ThreadingSpace = new Thread(SpacePlayer.Start);
                            ThreadingSpace.Start();
                        }
                           
                        break;
                    
                    case ConsoleKey.UpArrow:

                        Collision.Up();
                        
                        break;
                    case ConsoleKey.DownArrow:

                        Collision.Down();

                        break;

                    case ConsoleKey.F:

                        Variables.Dead = 0;

                        if (Maps.NumMap == 1)
                        {
                            Variables.XPlayerStart = Maps.Map0X;
                            Variables.YPlayerStart = Maps.Map0Y;
                        }
                        else if (Maps.NumMap == 2)
                        {
                            Variables.XPlayerStart = Maps.Map1X;
                            Variables.YPlayerStart = Maps.Map1Y;
                        }
                        else if (Maps.NumMap == 3)
                        {
                            Variables.XPlayerStart = Maps.Map2X;
                            Variables.YPlayerStart = Maps.Map2Y;
                        }
                        else if (Maps.NumMap == 4)
                        {
                            Variables.XPlayerStart = Maps.Map3X;
                            Variables.YPlayerStart = Maps.Map3Y;
                        }
                        else if (Maps.NumMap == 5)
                        {
                            Variables.XPlayerStart = Maps.Map4X;
                            Variables.YPlayerStart = Maps.Map4Y;
                        }
                        else if (Maps.NumMap == 6)
                        {
                            Variables.XPlayerStart = Maps.Map5X;
                            Variables.YPlayerStart = Maps.Map5Y;
                        }
                        Maps.EnumMap(false);

                        ReTitle.Counter();
                        break;

                    case ConsoleKey.R:
                                                
                        Maps.EnumMap(false);
                        break;

                    default:
                        ReDrawing.Draw();
                        break;
                }
            } while (true);
        }
        public static bool ShiftOperator(bool Left) // Return true if player is in opened zone, else return false
        {
            if (Left && Variables.XPlayer > 0)
                return true;
            if (!Left && Variables.XPlayer < Console.BufferWidth - 1)
                return true;

            return false; 
        }
    }
}
