using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeterAppT10.Models;
using MeterAppT10.Services.SettingsServices;
using Template10.Mvvm;

namespace MeterAppT10.ViewModels
{
    public class ReadingsMetersViewModel : ViewModelBase
    {
        private ZigbeeMeterViewModel _selectedZigbeeMeter;

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

        public ZigbeeMeterViewModel SelectedZigbeeMeter
        {
            get => _selectedZigbeeMeter;
            set => Set(ref _selectedZigbeeMeter, value);
        }
    }
}
