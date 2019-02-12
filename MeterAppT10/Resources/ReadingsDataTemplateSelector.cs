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
            return InnerSelectTemplate(item);
        }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            return InnerSelectTemplate(item);
        }

        private DataTemplate InnerSelectTemplate(object item)
        {
            switch (item)
            {
                case null:
                    return new DataTemplate();

                case ZigbeeMeterViewModel zigbeeMeter:
                    switch (zigbeeMeter.Prototype)
                    {
                        case 0:
                            return (DataTemplate)Application.Current.Resources["ZigbeeMeterPrototype0ReadingsTemplate"];
                        case 1:
                            return (DataTemplate)Application.Current.Resources["ZigbeeMeterPrototype1ReadingsTemplate"];
                        case 2:
                            return (DataTemplate)Application.Current.Resources["ZigbeeMeterPrototype2ReadingsTemplate"];
                        default:
                            throw new ArgumentOutOfRangeException(nameof(item), "Not found DataTemplate for this ViewModel");
                    }

                case MbusMeterViewModel mbusMeter:
                    switch (mbusMeter.Prototype)
                    {
                        case 0:
                            return (DataTemplate)Application.Current.Resources["MbusMeterPrototype0ReadingsTemplate"];
                        case 1:
                            return (DataTemplate)Application.Current.Resources["MbusMeterPrototype1ReadingsTemplate"];
                        case 2:
                            return (DataTemplate)Application.Current.Resources["MbusMeterPrototype2ReadingsTemplate"];
                        default:
                            throw new ArgumentOutOfRangeException(nameof(item), "Not found DataTemplate for this ViewModel");
                    }

                default:
                    throw new ArgumentOutOfRangeException(nameof(item), "Not found DataTemplate for this ViewModel");
            }
        }
    }
}