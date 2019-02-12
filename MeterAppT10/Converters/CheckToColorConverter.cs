using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using MeterAppT10.Models;

namespace MeterAppT10.Converters
{
    public class CheckToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var level = (CheckStatus) value;
            switch (level)
            {
                case CheckStatus.Unknown:
                    return new SolidColorBrush(Colors.Black);
                case CheckStatus.Ok:
                    return new SolidColorBrush(Colors.Green);
                case CheckStatus.NotOk:
                    return new SolidColorBrush(Colors.Red);
                case CheckStatus.NotChecked:
                    return new SolidColorBrush(Colors.Blue);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}