using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeterAppT10.Models;
using MeterAppT10.Services.SettingsServices;

namespace MeterAppT10.ViewModels
{
    public class ReadingsMetersViewModel
    {
        public ReadingsMetersViewModel()
        {
            IEnumerable<ZigbeeMeter> zigbeeMeters = MetersHelper.GetZigbeeMeters();

            foreach (ZigbeeMeter meter in zigbeeMeters)
            {
                var meterViewModel = new ZigbeeMeterViewModel(meter);
                ZigbeeMeters.Add(meterViewModel);
            }
        }

        public ObservableCollection<ZigbeeMeterViewModel> ZigbeeMeters { get; set; } =
            new ObservableCollection<ZigbeeMeterViewModel>();

        public ZigbeeMeterViewModel SelectedZigbeeMeter { get; set; }
    }
}
