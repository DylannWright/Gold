using System;

namespace Gold
{
    class Program
    {
        public static int ContainsGold(string p1, string p2)
        {
            int gold = 0;
            p1 = p1.ToUpper();
            p2 = p2.ToUpper();

            if (p1.Contains("GOLD"))
            {
                gold++;

                if (p2.Contains("GOLD"))
                {
                    gold++;
                }

            }
            return (gold);
        }
    }