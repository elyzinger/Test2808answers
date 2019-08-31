using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace TestWpfTargil1
{
    class ValueConverterPrecentage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Double size = System.Convert.ToDouble(value);
            if (size < 25 * 100 / 100)
            {
                return "Small";
            }
            if (size < 50 * 100 / 100 && size > 25 * 100 / 100)
            {
                return "Medium";
            }
            if (size < 75 * 100 / 100 && size > 50 * 100 / 100)
            {
                return "Large";
            }
            if (size > 75 * 100 / 100)
            {
                return "ExtraLarge";
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
