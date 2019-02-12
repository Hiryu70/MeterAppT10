using MeterAppT10.Models;
using MeterAppT10.Services.SettingsServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
                meterViewModel.StatusSet += MeterViewModelOnStatusSet;
            }
        }

        private void MeterViewModelOnStatusSet(object sender, EventArgs eventArgs)
        {
            var viewModel = (ZigbeeMeterViewModel) sender;
            SelectedZigbeeMeter = ZigbeeMeters.SkipWhile(m => m != viewModel).Skip(1).FirstOrDefault();
        }

        public ObservableCollection<ZigbeeMeterViewModel> ZigbeeMeters { get; } =
            new ObservableCollection<ZigbeeMeterViewModel>();

        public ZigbeeMeterViewModel SelectedZigbeeMeter
        {
            get => _selectedZigbeeMeter;
            set => Set(ref _selectedZigbeeMeter, value);
        }
    }
}
