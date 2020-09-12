using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.Metadata;
using System.Text;
/*
 * The wheel spins and yields a number between 1 and 36 when a ball drops into a numbered slot. There are also slot numbers 0 and 00.
 * The 0 and 00 slots are green and each of the other slots is red or black (chosen randomly).
 */
namespace Roulette
{
    public class Wheel
    {
        private static string[] numbers = {"0","1","2","3","4","5","6","7","8","9","10",
            "11","12","13","14","15","16","17","18","19","20",
            "21","22","23","24","25","26","24","25","26","27","28","29","30",
            "31", "32","33","34","35","36","00"};
        private static string[] colors = { "red", "black" };
        private static int winningNumber;
        private static string winningColor;
        public static void Spin()
        {
            Random r = new Random();
            winningNumber = int.Parse(numbers[r.Next(38)]);
            winningColor = colors[r.Next(1, 2)];
        }

        /*public int WinningNumber { get; }
        public string WinningColor { get; }*/
        public  static int GetWinningNumber()
        {
            return winningNumber;
        }

        public static string GetWinningColor()
        {
            return winningColor;
        }
    }
}
