using System;
using MeterAppT10.Models;
using Template10.Mvvm;

namespace MeterAppT10.ViewModels
{
    public class ZigbeeMeterViewModel : ViewModelBase
    {
        private CheckStatus _checkStatus = CheckStatus.Unknown;

        public ZigbeeMeterViewModel(ZigbeeMeter meter)
        {
            SerialNumber = meter.SerialNumber;
            Prototype = meter.Prototype;
            Power1 = new PowerProperty(meter.Power1);
            Power2 = new PowerProperty(meter.Power2);
            Power3 = new PowerProperty(meter.Power3);

            OkCommand = new DelegateCommand(Ok);
            NotOkCommand = new DelegateCommand(NotOk);
            NotCheckedCommand = new DelegateCommand(NotChecked);
            SkipCommand = new DelegateCommand(Skip);
        }


        public event EventHandler StatusSet;

        public CheckStatus CheckStatus
        {
            get => _checkStatus;
            set => Set(ref _checkStatus, value);
        }

        public string SerialNumber { get; }

        public int Prototype { get; }

        public ILevelProperty Power1 { get; }

        public ILevelProperty Power2 { get; }

        public ILevelProperty Power3 { get; }

        public DelegateCommand OkCommand { get; }

        public DelegateCommand NotOkCommand { get; }

        public DelegateCommand NotCheckedCommand { get; }

        public DelegateCommand SkipCommand { get; }

        private void Ok()
        {
            CheckStatus = CheckStatus.Ok;
            StatusSet?.Invoke(this, EventArgs.Empty);
        }

        private void NotOk()
        {
            CheckStatus = CheckStatus.NotOk;
            StatusSet?.Invoke(this, EventArgs.Empty);
        }

        private void NotChecked()
        {
            CheckStatus = CheckStatus.NotChecked;
            StatusSet?.Invoke(this, EventArgs.Empty);
        }

        private void Skip()
        {
            StatusSet?.Invoke(this, EventArgs.Empty);
        }
    }
}