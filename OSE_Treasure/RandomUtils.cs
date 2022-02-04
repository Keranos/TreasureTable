using System;

namespace OSE_Treasure
{
    public static class RandomUtils
    {
        public static int RollDice(RollType rt)
        {
            switch (rt) {
                case RollType.d2:
                    return SingleDice(2, 1);
                case RollType.d3:
                    return SingleDice(3, 1);
                case RollType.d4:
                    return SingleDice(4, 1);
                case RollType.d4x2:
                    return SingleDice(4, 2);
                case RollType.d4x5:
                    return SingleDice(4, 5);
                case RollType.d6:
                    return SingleDice(6, 1);
                case RollType.d6x2:
                    return SingleDice(6, 2);
                case RollType.d6x3:
                    return SingleDice(6, 3);
                case RollType.d6x5:
                    return SingleDice(6, 5);
                case RollType.d6x6:
                    return SingleDice(6, 6);
                case RollType.d8:
                    return SingleDice(8, 1);
                case RollType.d8x3:
                    return SingleDice(8, 3);
                case RollType.d10:
                    return SingleDice(10, 1);
                case RollType.d10x2:
                    return SingleDice(10, 2);
                case RollType.d10x3:
                    return SingleDice(10, 3);
                case RollType.d12:
                    return SingleDice(12, 1);
                case RollType.d12x2:
                    return SingleDice(12, 2);
                case RollType.d20:
                    return SingleDice(20, 1);
                case RollType.d100:
                    return SingleDice(100, 1);
                case RollType.d400:
                    return SingleDice(400, 1);
                default:
                    return 0;
            }
        }

        public static int SingleDice(int side, int num)
        {
            var output = 0;
            for(int i = 0; i < num; i++)
                output += rand.Next(1, side + 1);
            return output;
        }

        public static double PercentageDice()
        {
            return rand.NextDouble();
        }

        public static Random rand = new Random();
    }
}
