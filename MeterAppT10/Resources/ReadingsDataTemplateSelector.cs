using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MeterAppT10.ViewModels;

namespace MeterAppT10.Resources
{
    public sealed class ReadingsDataTemplateSelector : DataTemplateSelector
    {
        private readonly Dictionary<Type, DataTemplate> _templateDictionary;

        public ReadingsDataTemplateSelector()
        {
            _templateDictionary = new Dictionary<Type, DataTemplate>
            {
                {typeof(ElectricMeterViewModel), (DataTemplate) Application.Current.Resources["ElectricTemplate"]},
                {typeof(GasMeterViewModel), (DataTemplate) Application.Current.Resources["GasTemplate"]}
            };
        }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            if (item is ZigbeeMeterViewModel zigbeeMeter)
            {
                switch (zigbeeMeter.Prototype)
                {
                    case 0:
                        return (DataTemplate) Application.Current.Resources["ElectricTemplate"];
                    case 1:
                        return (DataTemplate)Application.Current.Resources["ElectricTemplate"];
                    case 2:
                        return (DataTemplate)Application.Current.Resources["ElectricTemplate"];
                }
            }

            throw new ArgumentOutOfRangeException(nameof(item) ,"Not found DataTemplate for this ViewModel");
        }

        //protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        //{
        //    Type itemType = item.GetType();
        //    DataTemplate dataTemplate = _templateDictionary.Keys.Contains(itemType)
        //        ? _templateDictionary[itemType]
        //        : null;

        //    return dataTemplate;
        //}
    }
}