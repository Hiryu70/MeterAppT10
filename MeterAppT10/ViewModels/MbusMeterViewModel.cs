using MeterAppT10.Models;

namespace MeterAppT10.ViewModels
{
    public class MbusMeterViewModel : ReadingsMeterViewModel
    {
        public MbusMeterViewModel(MbusMeter meter) : base(meter.SerialNumber, meter.Prototype)
        {
            CommunicationType = CommunicationType.Mbus;

            Voltage1 = new PowerChannel(meter.Voltage1);
            Voltage2 = new PowerChannel(meter.Voltage2);
            Voltage3 = new PowerChannel(meter.Voltage3);
        }


        public ILevelChannel Voltage1 { get; }

        public ILevelChannel Voltage2 { get; }

        public ILevelChannel Voltage3 { get; }
    }
}