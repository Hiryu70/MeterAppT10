namespace MeterAppT10.Models
{
    public interface ILevelChannel
    {
        int Value { get; set; }
        Level Level { get; set; }
    }
}