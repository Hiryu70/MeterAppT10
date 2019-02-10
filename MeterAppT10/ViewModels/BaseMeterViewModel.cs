using System;
using MeterAppT10.Models;
using Template10.Mvvm;

namespace MeterAppT10.ViewModels
{
    public class BaseMeterViewModel : ViewModelBase
    {
        protected BaseMeterViewModel()
        {
            EditCommand = new DelegateCommand(Edit);
        }


        public event EventHandler Editing;

        public string Name { get; set; }

        public string SerialNumber { get; set; }

        protected ServiceCategory Service { get; set; }

        public bool IsEditing { get; private set; }

        public DelegateCommand EditCommand { get; }


        private void Edit()
        {
            IsEditing = !IsEditing;
            Editing?.Invoke(this, EventArgs.Empty);
        }
    }
}