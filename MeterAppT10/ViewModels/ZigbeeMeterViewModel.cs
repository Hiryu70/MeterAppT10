using MeterAppT10.Models;

namespace MeterAppT10.ViewModels
{
    public class ZigbeeMeterViewModel : ReadingsMeterViewModel
    {
        public ZigbeeMeterViewModel(ZigbeeMeter meter) : base(meter.SerialNumber, meter.Prototype)
        {
            CommunicationType = CommunicationType.Zigbee;

            Power1 = new PowerChannel(meter.Power1);
            Power2 = new PowerChannel(meter.Power2);
            Power3 = new PowerChannel(meter.Power3);
        }
        
        public ILevelChannel Power1 { get; }

        public ILevelChannel Power2 { get; }

        public ILevelChannel Power3 { get; }
    }
}