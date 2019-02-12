namespace MeterAppT10.Models
{
    public sealed class PowerChannel : ILevelChannel
    {
        public PowerChannel(int value)
        {
            Value = value;
            Level = GetLevel(value);
        }


        public int Value { get; set; }

        public Level Level { get; set; }


        private static Level GetLevel(int value)
        {
            if (50 <= value)
            {
                return Level.Normal;
            }

            if (20 <= value && value < 50)
            {
                return Level.High;
            }

            return Level.Critical;
        }
    }
}