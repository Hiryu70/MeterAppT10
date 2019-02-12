namespace MeterAppT10.Models
{
    public sealed class VoltageChannel : ILevelChannel
    {
        public VoltageChannel(int value)
        {
            Value = value;
            Level = GetLevel(value);
        }


        public int Value { get; set; }

        public Level Level { get; set; }


        private static Level GetLevel(int value)
        {
            if (value < 200)
            {
                return Level.Critical;
            }

            if (200 <= value && value < 210)
            {
                return Level.High;
            }

            if (210 <= value && value < 230)
            {
                return Level.Normal;
            }

            if (230 <= value && value < 240)
            {
                return Level.High;
            }

            return Level.Critical;
        }
    }
}