using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Comida.convertidores
{
    class FontConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string comida = value as string;
            FontFamily salida;

            if (comida == "China")
            {
                salida = new FontFamily("Chinese Wok Food St");
            }
            else if (comida == "Mexicana")
            {
                salida = new FontFamily("Taco Salad");
            }
            else
            {
                salida = new FontFamily("Slim Summer");
            }

            return salida;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
