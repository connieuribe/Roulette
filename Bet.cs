using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
/*
* 1.Numbers: Any number of the bin
* 2.Evens/Odds: even or odd numbers
* 3.Reds/Blacks: red or black colored numbers
* 4.Lows/Highs: Los(1-18) or high(19-38) numbers
* 5.Dozens: row thirds. 1-12, 13-24, 25-36
* 6.Columns: first, second, third columns
* 7.Street: row e.g.1/2/3 or 22/23/24
* 8.6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26
* 9.split: at the edge of any two contiguous numbers e.t 1/2, 11/14, or 35/36
* 10.corner: at the intersection of any four contiguous numbers e.g.1/2/4/5 or 23/24/26/27
*/
namespace Roulette
{
    class Bet
    {
        //1. just a number
        public static void StraightBet()
        {
            //Alredy handled
        }
        //2.
        public static int[] EvenOddBet(bool evenOdd)
        {
            int[] arr = new int[18];
            int count = 0;
            if (evenOdd)//Even
            {
                for(int i = 1; i <=36; i++)
                {
                    if(i%2 == 0)
                    {
                        arr[count] = i;
                        count++;
                    }
                }
            }
            else//odd
            {
                for (int i = 1; i <= 36; i++)
                {
                    if (i % 2 != 0)
                    {
                        arr[count] = i;
                        count++;
                    }
                }
            }
            return arr;
        }
        //3.
        public static void RedBlackBet()
        {
            //Does not need to be implemented. We will simply check the winning number
        }
        //4.
        public static int[] LowHighBet(bool lowHigh)
        {
            int[] arr = new int[18];
            int count = 0;
            if (lowHigh)//low
            {
                for(int i=1; i<=18;i++)
                {
                    arr[count] = i;
                    count++;
                }
            }
            else
            {
                
                for (int i = 19; i <= 36; i++)
                {
                    arr[count] = i;
                    count++;
                }
            }
            return arr;
        }
        //5.
        public static int[] DozenBet(int dozen)
        {
            int[] arr = new int[12];
            int count = 0;
            if (dozen == 1)
            {
                for (int i = 1; i <= 12; i++)
                {
                    arr[count] = i;
                    count++;
                }
            }
            else if(dozen==2)
            {
                for (int i = 13; i <= 24; i++)
                {
                    arr[count] = i;
                    count++;

                }
            }
            else
            {
                for (int i = 25; i <= 36; i++)
                {
                    arr[count] = i;
                    count++;
                }
            }
            return arr;
        }
        //6.
        public static int[] ColumnBet(int column)
        {
            int[] arr = new int[12];
            int count = 0;
                for (int i = column; i <= 36; i+=3)
                {
                    arr[count] = i;
                    count++;
                }
            return arr;
        }
        //7.
        public static int[] StreetBet(int street)
        {
            int[] arr = new int[3];
            int beginningOfStreet = 0;
            for(int i = 1; i <= street; i++)
            {
                beginningOfStreet += 2;
            }
            for(int j = 0; j<3; j++)
            {
                arr[j] = beginningOfStreet;
                beginningOfStreet++;
            }
            return arr;
        }
        //8.
        public static int[] DoubleStreetBet(int street)
        {
            int[] arr = new int[6];
            int count = 0;
            switch(street)
            {
                case 1://1 - 6
                    for(int i = 1; i<=6; i++)
                    {
                        arr[count] = i;
                        count++;
                    }
                    return arr;
                case 2://7-12
                    for (int i = 7; i <= 12; i++)
                    {
                        arr[count] = i;
                        count++;
                    }
                    return arr;
                case 3://13-18
                    for (int i = 13; i <= 18; i++)
                    {
                        arr[count] = i;
                        count++;
                    }
                    return arr;
                case 4://19-24
                    for (int i = 19; i <= 24; i++)
                    {
                        arr[count] = i;
                        count++;
                    }
                    return arr;
                case 5://25-30
                    for (int i = 25; i <= 30; i++)
                    {
                        arr[count] = i;
                        count++;
                    }
                    return arr;
                case 6:
                    for (int i = 31; i <= 36; i++)
                    {
                        arr[count] = i;
                        count++;
                    }
                    return arr;
            }
            return arr;
        }
        //9.
        public static int[] SplitBet(int num1, int num2)
        {
            
            if (num1 == num2-1 || num1 == num2 +1)
            {
                int[] arr = { num1, num2 };
                return arr;
            }
            int[] arrs = {41};
            return arrs;
        }
        //10.
        public static int[] CornerBet(int corner)
        {
            int start = 0;
            int[] arr = new int[4];
            for(int i=1; i<=corner; i+=2)//where the corner starts
            {
                i += start;
                start++;
            }
            if (start != corner)
                start++;
            arr[0] = start;
            arr[1] = start++;
            arr[2] = start + 4;
            arr[3] = start + 5;
            return arr;
        }
    }
}
