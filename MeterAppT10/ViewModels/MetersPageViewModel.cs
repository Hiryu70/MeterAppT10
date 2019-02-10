using System;
using System.Collections.ObjectModel;
using Template10.Mvvm;

namespace MeterAppT10.ViewModels
{
    internal sealed class MetersPageViewModel : ViewModelBase
    {
        private bool _isEditing;


        public MetersPageViewModel()
        {
            UpdateMetersCommand = new DelegateCommand(UpdateMeters);
            UpdateMeters();
        }


        public BaseMeterViewModel EditedMeter { get; private set; }

        public ObservableCollection<BaseMeterViewModel> Meters { get; } = new ObservableCollection<BaseMeterViewModel>();

        public DelegateCommand UpdateMetersCommand { get; }

        public bool IsEditing
        {
            get => _isEditing;
            set => Set(ref _isEditing, value);
        }

        private void AddMeter(BaseMeterViewModel meter)
        {
            meter.Editing += MeterOnEditing;
            Meters.Add(meter);
        }

        private void MeterOnEditing(object sender, EventArgs eventArgs)
        {
            var meter = (BaseMeterViewModel) sender;
            if (meter!= null)
            {
                IsEditing = meter.IsEditing;
                EditedMeter = meter;
            }

        }

        private void UpdateMeters()
        {
            Meters.Clear();

            var random = new Random();
            var meter1 = new ElectricMeterViewModel
            {
                Name = "Meter1",
                SerialNumber = "ABC-123",
                Electricity = random.Next(0, 100)
            };
            AddMeter(meter1);

            var meter2 = new GasMeterViewModel
            {
                Name = "Meter2",
                SerialNumber = "GHJ-567",
                Gas = random.Next(0, 100)
            };
            AddMeter(meter2);
        }
    }
}