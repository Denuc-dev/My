using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameFolder
{
    public class ReDrawing
    {
        public static void Draw()
        {
            

            try
            {
                Console.Clear();

                foreach (string line in Maps.CurrentMap)
                    Console.WriteLine(line);

                Console.SetCursorPosition(Variables.XPlayer, Variables.YPlayer);

                Console.WriteLine(Variables.Player);

                Console.SetCursorPosition(Variables.XCursor, Variables.YCursor);
            }
            catch (System.NullReferenceException) { }
        }
    }
}
