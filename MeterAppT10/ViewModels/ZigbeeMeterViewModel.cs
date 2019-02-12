using MeterAppT10.Models;

namespace MeterAppT10.ViewModels
{
    public class ZigbeeMeterViewModel
    {
        public ZigbeeMeterViewModel(ZigbeeMeter meter)
        {
            SerialNumber = meter.SerialNumber;
            Prototype = meter.Prototype;
            Power1 = new PowerProperty(meter.Power1);
            Power2 = new PowerProperty(meter.Power2);
            Power3 = new PowerProperty(meter.Power3);
        }

        public CheckStatus CheckStatus { get; set; } = CheckStatus.Unknown;

        public string SerialNumber { get; set; }

        public int Prototype { get; set; }

        public ILevelProperty Power1 { get; set; }

        public ILevelProperty Power2 { get; set; }

        public ILevelProperty Power3 { get; set; }
    }
}