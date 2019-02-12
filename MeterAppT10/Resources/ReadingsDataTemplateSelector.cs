using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MeterAppT10.ViewModels;

namespace MeterAppT10.Resources
{
    public sealed class ReadingsDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item)
        {
            if (item == null)
                return new DataTemplate();

            if (item is ZigbeeMeterViewModel zigbeeMeter)
            {
                switch (zigbeeMeter.Prototype)
                {
                    case 0:
                        return (DataTemplate) Application.Current.Resources["ZigbeeMeterReadingsTemplate"];
                    case 1:
                        return (DataTemplate)Application.Current.Resources["ZigbeeMeterReadingsTemplate"];
                    case 2:
                        return (DataTemplate)Application.Current.Resources["ZigbeeMeterReadingsTemplate"];
                }
            }

            throw new ArgumentOutOfRangeException(nameof(item) ,"Not found DataTemplate for this ViewModel");
        }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item == null)
                return new DataTemplate();

            if (item is ZigbeeMeterViewModel zigbeeMeter)
            {
                switch (zigbeeMeter.Prototype)
                {
                    case 0:
                        return (DataTemplate)Application.Current.Resources["ZigbeeMeterReadingsTemplate"];
                    case 1:
                        return (DataTemplate)Application.Current.Resources["ZigbeeMeterReadingsTemplate"];
                    case 2:
                        return (DataTemplate)Application.Current.Resources["ZigbeeMeterReadingsTemplate"];
                }
            }

            throw new ArgumentOutOfRangeException(nameof(item), "Not found DataTemplate for this ViewModel");
        }
    }
}