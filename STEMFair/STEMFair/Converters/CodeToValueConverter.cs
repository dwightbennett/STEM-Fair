using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace STEMFair.Converters
{
    public class CodeToValueConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is string code)
            {
                var index = System.Convert.ToInt32(parameter);
                if(code.Count() < index + 1)
                {
                    return "-";
                }

                return code.ElementAt(index).ToString();
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
