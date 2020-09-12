using System;

namespace Roulette
{
    class Play
    {
        public static int[] Welcome()
        {
            try
            {
                bool even = true;
                bool low = true;
                string input = "";

                Console.WriteLine("\n\nWELCOME TO ROULETTE! \nAre you ready to play?" +
                "\n\nSelect your betting option " +
                "(Attention: only include the digit number.)");
                var option = LetsPlay();
                
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter a number: ");
                        input = Console.ReadLine();
                        int[] playerNumber = { Int32.Parse(input) };
                        return playerNumber;
                    case 2:
                        return Bet.EvenOddBet(even);
                    case 3:
                        return Bet.EvenOddBet(!even);
                    case 4:
                        int[] color = { 39 };
                        return color;
                    case 5:
                        int[] colors = { 40 };
                        return colors;
                    case 6:
                        return Bet.LowHighBet(low);
                    case 7:
                        return Bet.LowHighBet(!low);
                    case 8:
                        Console.WriteLine("\n\nOption 1: Dozen 1-12" +
                            "\n\nOption 2: Dozen 13-24" +
                            "\n\nOption 3: Dozen 25-36");
                        input = Console.ReadLine();
                        return Bet.DozenBet(Int32.Parse(input));
                    case 9:
                        Console.WriteLine("\n\nOption 1: First Column" +
                    "\n\nOption 2: Second Column" +
                    "\n\nOption 3: Third Column");
                        input = Console.ReadLine();
                        return Bet.ColumnBet(Int32.Parse(input));
                    case 10:
                        Console.WriteLine("\n\nOption 1: Street 1 - 3" +
                    "\n\nOption 2: Street 4-6" +
                    "\n\nOption 3: Street 7-9" +
                    "\n\nOption 4: Street 10-12" +
                    "\n\nOption 5: Street 13-15" +
                    "\n\nOption 6: Street 16-18" +
                    "\n\nOption 7: Street 19-21" +
                    "\n\nOption 8: Street 22-24" +
                    "\n\nOption 9: Street 25-27" +
                    "\n\nOption 10: Street 28-30" +
                    "\n\nOption 11: Street 31-33" +
                    "\n\nOption 12: Street 34-36");
                        input = Console.ReadLine();
                        return Bet.StreetBet(Int32.Parse(input));
                    case 11:
                        Console.WriteLine("\n\nOption 1: Double Stree 1 - 6" +
                    "\n\nOption 2: Double Stree 7-12" +
                    "\n\nOption 3: Double Stree 13-18" +
                    "\n\nOption 4: Double Stree 19-24" +
                    "\n\nOption 5: Double Stree 25-30" +
                    "\n\nOption 6: Double Stree 30-36");
                        input = Console.ReadLine();
                        return Bet.DoubleStreetBet(Int32.Parse(input));
                    case 12:
                        Console.WriteLine("Enter the first continuous numbers: ");
                        input = Console.ReadLine();
                        Console.WriteLine("Enter the second continuous numbers: ");
                        string str = Console.ReadLine();
                        return Bet.SplitBet(Int32.Parse(input), Int32.Parse(str));
                    case 13:
                        int count = 1;
                        for (int i = 1; i <= 36; i++) 
                        {
                            if (i % 3 != 0)//ignore multiple of three
                            {
                                Console.WriteLine($"\nOption {count}: Corner {i}, {i + 1}, {i + 3} {i + 4}");
                                count++;
                            }
                        }
                        input = Console.ReadLine();
                        return Bet.CornerBet(Int32.Parse(input));
                    default:
                        return playerNumber = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public static int LetsPlay()
        {
            Console.WriteLine("\n\t\t\tOption 1: Straight Number" +
                    "\n\t\t\tOption 2: Even numbers" +
                    "\n\t\t\tOption 3: Odd numbers" +
                    "\n\t\t\tOption 4: Red numbers" +
                    "\n\t\t\toption 5: Black numbers" +
                    "\n\t\t\toption 6: Low numbers 1-18" +
                    "\n\t\t\tOption 7: High numbers 19-36" +
                    "\n\t\t\tOption 8: Dozen" +
                    "\n\t\t\tOption 9: Column" +
                    "\n\t\t\tOption 10: Street" +
                    "\n\t\t\tOption 11: Double Street" +
                    "\n\t\t\tOption 12: Split" +
                    "\n\t\t\tOption 13: Corner");
            string input = Console.ReadLine();
            return Int32.Parse(input);
        }
    }
}
