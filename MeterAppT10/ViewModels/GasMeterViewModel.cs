using MeterAppT10.Models;

namespace MeterAppT10.ViewModels
{
    public sealed class GasMeterViewModel : BaseMeterViewModel
    {
        public GasMeterViewModel()
        {
            Service = ServiceCategory.Gas;
        }

        public int Gas { get; set; }
    }
}