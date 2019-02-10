using MeterAppT10.Models;

namespace MeterAppT10.ViewModels
{
    public sealed class ElectricMeterViewModel : BaseMeterViewModel
    {
        public ElectricMeterViewModel()
        {
            Service = ServiceCategory.Electric;
        }

        public int Electricity { get; set; }
    }
}