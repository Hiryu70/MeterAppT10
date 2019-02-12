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
        private ReadingsMeterViewModel _selectedMeter;

        public ReadingsMetersViewModel()
        {
            IEnumerable<ZigbeeMeter> zigbeeMeters = MetersHelper.GetZigbeeMeters();
            foreach (ZigbeeMeter meter in zigbeeMeters)
            {
                var meterViewModel = new ZigbeeMeterViewModel(meter);
                Meters.Add(meterViewModel);
                meterViewModel.StatusSet += MeterViewModelOnStatusSet;
            }

            IEnumerable<MbusMeter> mbusMeters = MetersHelper.GetMbusMeters();
            foreach (MbusMeter meter in mbusMeters)
            {
                var meterViewModel = new MbusMeterViewModel(meter);
                Meters.Add(meterViewModel);
                meterViewModel.StatusSet += MeterViewModelOnStatusSet;
            }
        }

        private void MeterViewModelOnStatusSet(object sender, EventArgs eventArgs)
        {
            var viewModel = (ZigbeeMeterViewModel) sender;
            SelectedMeter = Meters.SkipWhile(m => m != viewModel).Skip(1).FirstOrDefault();
        }

        public ObservableCollection<ReadingsMeterViewModel> Meters { get; } =
            new ObservableCollection<ReadingsMeterViewModel>();

        public ReadingsMeterViewModel SelectedMeter
        {
            get => _selectedMeter;
            set => Set(ref _selectedMeter, value);
        }
    }
}