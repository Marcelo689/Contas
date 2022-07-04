using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace GestaoDeContas.Converters
{
    public class NecessidadeConverter : IValueConverter
    {
        Dictionary<int, string> NecessidadeString = new Dictionary<int, string>()
        {

            { 0, "Todas Necessidades" },
            { 1, "Necessidade Alta" },
            { 2, "Necessidade Media" },
            { 3, "Necessidade Baixa" },
        };
        Dictionary<string, int> NecessidadeInt = new Dictionary<string, int>()
        {
            { "Todas Necessidades" , 0},
            { "Necessidade Alta" , 1},
            { "Necessidade Baixa" , 2},
            { "Necessidade Media" , 3},
        };
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            int indice = (int)value;
            return NecessidadeString[indice];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var indice = (string)value;
            return NecessidadeInt[indice];
        }
    }
}
