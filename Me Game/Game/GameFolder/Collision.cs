using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game.GameFolder
{
#pragma optimize("", on)
    public class Collision
    {
        public static void Left()
        {
            try
            {
                string Line = Maps.CurrentMap[Variables.YPlayer];
                string Line0 = Maps.CurrentMap[Variables.YPlayer + 1];
                string Line1 = Maps.CurrentMap[Variables.YPlayer - 1];

                if (Variables.Finish.Contains(Line.Substring(Variables.XPlayer - 1, 1)) || Line1.Substring(Variables.XPlayer - 1, 1) == "-")
                {
                    Variables.Level++;

                    ReTitle.Counter();
                    SoundPlayer player = new SoundPlayer();
                    player.Stream = GameFolder.Misc.Music.finish;
                    player.Play();

                    Maps.EnumMap(true);
                }

                else if (Line0.Substring(Variables.XPlayer - 1, 1) == "+")
                {
                    if (!ShiftVariable.ReSaveTitleThread)
                    {
                        ShiftVariable.ReSaveTitleThread = true;

                        new Thread(ReTitle.Save).Start();
                    }
                    Variables.XPlayerStart = Variables.XPlayer - 1;
                    Variables.YPlayerStart = Variables.YPlayer;

                    Variables.XPlayer--;
                }
                else if (Line.Substring(Variables.XPlayer - 1, 1) == "+")
                {
                    if (!ShiftVariable.ReSaveTitleThread)
                    {
                        ShiftVariable.ReSaveTitleThread = true;

                        new Thread(ReTitle.Save).Start();
                    }
                    Variables.XPlayerStart = Variables.XPlayer - 1;
                    Variables.YPlayerStart = Variables.YPlayer;

                }
                else if (Variables.BackGroundDead.Contains(Line.Substring(Variables.XPlayer - 1, 1)))
                {
                    Variables.Dead++;

                    ReTitle.Counter();

                    SoundPlayer player = new SoundPlayer();
                    player.Stream = GameFolder.Misc.Music.dead;
                    player.Play();

                    Maps.EnumMap(false);
                }
                else if (Line.Substring(Variables.XPlayer - 1, 1) == "*" && !Variables.BackGround.Contains(Line1.Substring(Variables.XPlayer - 1, 1)))
                {
                    Variables.XPlayer--;
                    Variables.YPlayer--;
                }
                else if (PressKeys.ShiftOperator(true) && !Variables.BackGround.Contains(Line.Substring(Variables.XPlayer - 1, 1)))
                    Variables.XPlayer--;

                if (!ShiftVariable.SpaceThread)
                    new Thread(GameFolder.SpacePlayer.DownPlayer).Start();
            }
            catch (System.ArgumentOutOfRangeException) { }
            catch (System.NullReferenceException) { }
        }
        public static void Right()
        {
            try
            {
                string Line = Maps.CurrentMap[Variables.YPlayer];
                string Line0 = Maps.CurrentMap[Variables.YPlayer + 1];
                string Line1 = Maps.CurrentMap[Variables.YPlayer - 1];

                if (Variables.Finish.Contains(Line.Substring(Variables.XPlayer + 1, 1)) || Line1.Substring(Variables.XPlayer + 1, 1) == "-")
                {
                    Variables.Level++;

                    ReTitle.Counter();

                    SoundPlayer player = new SoundPlayer();
                    player.Stream = GameFolder.Misc.Music.finish;
                    player.Play();

                    Maps.EnumMap(true);
                }

                else if (Line0.Substring(Variables.XPlayer + 1, 1) == "+" || Line.Substring(Variables.XPlayer + 1, 1) == "+")
                {
                    if (!ShiftVariable.ReSaveTitleThread)
                    {
                        ShiftVariable.ReSaveTitleThread = true;

                        new Thread(ReTitle.Save).Start();
                    }

                    Variables.XPlayerStart = Variables.XPlayer + 1;
                    Variables.YPlayerStart = Variables.YPlayer;
                }
                if (Variables.BackGroundDead.Contains(Line.Substring(Variables.XPlayer + 1, 1)))
                {
                    Variables.Dead++;

                    ReTitle.Counter();

                    SoundPlayer player = new SoundPlayer();
                    player.Stream = GameFolder.Misc.Music.dead;
                    player.Play();

                    Maps.EnumMap(false);
                }
                else if (Line.Substring(Variables.XPlayer + 1, 1) == "*" && !Variables.BackGround.Contains(Line1.Substring(Variables.XPlayer + 1, 1)))
                {
                    Variables.XPlayer++;
                    Variables.YPlayer--;
                }
                else if (PressKeys.ShiftOperator(false) && !Variables.BackGround.Contains(Line.Substring(Variables.XPlayer + 1, 1)))
                    Variables.XPlayer++;

                if (!ShiftVariable.SpaceThread)
                {
                    new Thread(GameFolder.SpacePlayer.DownPlayer).Start();
                }
            }
            catch (System.ArgumentOutOfRangeException) { }
            catch (System.NullReferenceException) { }
        }
        public static void Up()
        {
            try
            {
                string Line = Maps.CurrentMap[Variables.YPlayer + 1];

                if (Line.Substring(Variables.XPlayer, 1) == "=")
                {
                    SoundPlayer player = new SoundPlayer();
                    player.Stream = GameFolder.Misc.Music.run;
                    player.Play();

                    Variables.YPlayer--;
                }
                if (!ShiftVariable.SpaceThread)
                {
                    new Thread(GameFolder.SpacePlayer.DownPlayer).Start();
                }
            }
            catch (System.ArgumentOutOfRangeException) { }
            catch (System.NullReferenceException) { }
        }
        public static void Down()
        {
            try
            {
                string Line = Maps.CurrentMap[Variables.YPlayer + 1];

                if (Line.Substring(Variables.XPlayer, 1) == "=")
                {
                    SoundPlayer player = new SoundPlayer();
                    player.Stream = GameFolder.Misc.Music.run;
                    player.Play();

                    Variables.YPlayer++;
                }

                if (!ShiftVariable.SpaceThread)
                {
                    new Thread(GameFolder.SpacePlayer.DownPlayer).Start();
                }
            }
            catch (System.ArgumentOutOfRangeException) { }
            catch (System.NullReferenceException) { }
        }
        public static bool UpSpace()
        {
            try
            {
                string Line = Maps.CurrentMap[Variables.YPlayer - 1];

                if (Variables.Finish.Contains(Line.Substring(Variables.XPlayer, 1)))
                {
                    Variables.Level++;

                    ReTitle.Counter();

                    SoundPlayer player = new SoundPlayer();
                    player.Stream = GameFolder.Misc.Music.finish;
                    player.Play();

                    Maps.EnumMap(true);
                }

                if (Line.Substring(Variables.XPlayer, 1) == "+")
                {

                    if (!ShiftVariable.ReSaveTitleThread)
                    {
                        ShiftVariable.ReSaveTitleThread = true;

                        new Thread(ReTitle.Save).Start();
                    }

                    Variables.XPlayerStart = Variables.XPlayer;
                    Variables.YPlayerStart = Variables.YPlayer;
                }
                else if (Variables.BackGroundDead.Contains(Line.Substring(Variables.XPlayer, 1)))
                {
                    Variables.Dead++;

                    ReTitle.Counter();

                    SoundPlayer player = new SoundPlayer();
                    player.Stream = GameFolder.Misc.Music.dead;
                    player.Play();

                    Maps.EnumMap(false);
                    return true;
                }
                else if (Line.Substring(Variables.XPlayer, 1) == "=")
                {
                    Variables.YPlayer -= 2;
                    return true;
                }
                else if (Variables.BackGround.Contains(Line.Substring(Variables.XPlayer, 1)))
                    return true;

            }
            catch (System.ArgumentOutOfRangeException) { }
            catch (System.NullReferenceException) { }

            return false;
        }
        public static bool DownSpace()
        {
            try
            {
                string Line = Maps.CurrentMap[Variables.YPlayer + 1];

                if (Line.Substring(Variables.XPlayer, 1) == "+")
                {

                    if (!ShiftVariable.ReSaveTitleThread)
                    {
                        ShiftVariable.ReSaveTitleThread = true;

                        new Thread(ReTitle.Save).Start();
                    }

                    Variables.XPlayerStart = Variables.XPlayer;
                    Variables.YPlayerStart = Variables.YPlayer;
                }
                else if (Variables.Finish.Contains(Line.Substring(Variables.XPlayer, 1)))
                {
                    Variables.Level++;

                    ReTitle.Counter();

                    SoundPlayer player = new SoundPlayer();
                    player.Stream = GameFolder.Misc.Music.finish;
                    player.Play();

                    Maps.EnumMap(true);
                    return true;
                }
                else if (Variables.BackGroundDead.Contains(Line.Substring(Variables.XPlayer, 1)))
                {
                    Variables.Dead++;

                    ReTitle.Counter();

                    SoundPlayer player = new SoundPlayer();
                    player.Stream = GameFolder.Misc.Music.dead;
                    player.Play();

                    Maps.EnumMap(false);
                    return true;
                }
                else if (Line.Substring(Variables.XPlayer, 1) == "~")
                {
                    SoundPlayer player = new SoundPlayer();
                    player.Stream = GameFolder.Misc.Music.longJump;
                    player.Play();

                    SpacePlayer.Num = 1;
                    new Thread(SpacePlayer.Start).Start();
                    return true;
                }
                if (Variables.BackGround.Contains(Line.Substring(Variables.XPlayer, 1)) || Variables.BackGroundSpaceDown.Contains(Line.Substring(Variables.XPlayer, 1)))
                    return true;

                
            }
            catch (System.ArgumentOutOfRangeException) { }
            catch (System.NullReferenceException) { }

            return false;
        }
    }
#pragma optimize("", on)
}
