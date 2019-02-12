using System;
using MeterAppT10.Models;
using Template10.Mvvm;

namespace MeterAppT10.ViewModels
{
    public class ReadingsMeterViewModel : ViewModelBase
    {
        private CheckStatus _checkStatus = CheckStatus.Unknown;

        protected ReadingsMeterViewModel(string serialNumber, int prototype)
        {
            SerialNumber = serialNumber;
            Prototype = prototype;

            OkCommand = new DelegateCommand(Ok);
            NotOkCommand = new DelegateCommand(NotOk);
            NotCheckedCommand = new DelegateCommand(NotChecked);
            SkipCommand = new DelegateCommand(Skip);
        }

        public event EventHandler StatusSet;

        public string SerialNumber { get; }

        protected CommunicationType CommunicationType { get; set; }

        public int Prototype { get; }

        public string FullType => $"{CommunicationType} ({Prototype})";

        public CheckStatus CheckStatus
        {
            get => _checkStatus;
            set => Set(ref _checkStatus, value);
        }

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