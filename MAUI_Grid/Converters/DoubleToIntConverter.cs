using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Grid.Converters
{
     
        public class DoubleToIntConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                string strParam = parameter as string;
                double multiplier = 1;

                if (!string.IsNullOrEmpty(strParam))
                {
                    Double.TryParse(strParam, out multiplier);
                }
                return (int)Math.Round((double)value * multiplier);
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                string strParam = parameter as string;
                double divider = 1;

                if (!string.IsNullOrEmpty(strParam))
                {
                    Double.TryParse(strParam, out divider);
                }

                return (int)value / divider;
            }
        }
    }
