using System;
using static System.Net.Mime.MediaTypeNames;

namespace Roulette
{
    /*
     * The program will initialize a prompter, wheel, and have switch cases to determine the betting.
     */
    class Program
    {
        //switch case to ask the user what bet they want.
        static void Main(string[] args)
        {
            while (true)
            {
                Wheel.Spin();
                
                int winningNumber = Wheel.GetWinningNumber();
                string winningColor = Wheel.GetWinningColor();
                int[] bettingNumbers = Play.Welcome();
                Console.WriteLine("\n\nThe winning number is: " + winningNumber + " " + winningColor);
                if (bettingNumbers.Length == 1)//straight number, red or black
                {
                    if (bettingNumbers[0] == winningNumber)
                    {
                        Console.WriteLine("Congratulations you won $35!");
                    }
                    else if (bettingNumbers[0] == 39 && winningColor == "red")
                    {
                        Console.WriteLine("Congratulations you won!");
                    }
                    else if(bettingNumbers[0] == 40 && winningColor == "black")
                    {
                        Console.WriteLine("Congratulations you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you lost");
                    }
                }
                else
                {
                    bool won = false;
                    foreach (int num in bettingNumbers)
                    {
                        Console.WriteLine(num);
                        if (winningNumber == num)
                        {
                            Console.WriteLine("Congratulations you won");
                            won = true;
                            break;
                            
                        }
                    }
                    if(!won)
                    {
                        Console.WriteLine("SORRY YOU LOST!! PLAY AGAIN?");
                    }
                }
            }
        }
    }
}
