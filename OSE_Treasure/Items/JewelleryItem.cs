namespace OSE_Treasure.Items
{
    public sealed class JewelleryItem : TreasureTableItem
    {
        public JewelleryItem(RollType dice, double percentage, int times = 1)
        {
            Dice = dice;
            Percentage = percentage;
            Times = times;
        }

        public string Roll()
        {
            var n = RandomUtils.RollDice(Dice) * Times;

            var count = 0;
            var worth = 0;

            for (int i = 0; i < n; i++)
            {
                if (RandomUtils.PercentageDice() < Percentage)
                {
                    count++;
                    worth += RandomUtils.RollDice(RollType.d6x3);
                }
            }

            return count == 0 ? string.Empty : $"{count} pieces of jewellery worth {worth*100} gold\n";
        }

        public RollType Dice { get; set; }
        public double Percentage { get; set; }
        public double Times { get; set; }
    }
}
