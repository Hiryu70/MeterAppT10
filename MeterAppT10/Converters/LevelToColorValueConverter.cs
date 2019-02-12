using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using MeterAppT10.Models;

namespace MeterAppT10.Converters
{
    public class LevelToColorValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var level = (Level) value;
            switch (level)
            {
                case Level.Normal:
                    return new SolidColorBrush(Colors.LimeGreen);
                case Level.High:
                    return new SolidColorBrush(Colors.Orange);
                case Level.Critical:
                    return new SolidColorBrush(Colors.Red);
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