using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MeterAppT10.ViewModels;

namespace MeterAppT10.Resources
{
    public sealed class CustomDataTemplateSelector : DataTemplateSelector
    {
        private readonly Dictionary<Type, DataTemplate> _templateDictionary;

        public CustomDataTemplateSelector()
        {
            _templateDictionary = new Dictionary<Type, DataTemplate>
            {
                {typeof(ElectricMeterViewModel), (DataTemplate) Application.Current.Resources["ElectricTemplate"]},
                {typeof(GasMeterViewModel), (DataTemplate) Application.Current.Resources["GasTemplate"]}
            };
        }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            Type itemType = item.GetType();
            DataTemplate dataTemplate = _templateDictionary.Keys.Contains(itemType)
                ? _templateDictionary[itemType]
                : null;

            return dataTemplate;
        }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            Type itemType = item.GetType();
            DataTemplate dataTemplate = _templateDictionary.Keys.Contains(itemType)
                ? _templateDictionary[itemType]
                : null;

            return dataTemplate;
        }
    }
}