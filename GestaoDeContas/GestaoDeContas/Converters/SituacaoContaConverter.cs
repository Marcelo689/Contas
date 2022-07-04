using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace GestaoDeContas.Converters
{
    public class SituacaoContaConverter : IValueConverter
    {
        Dictionary<int, string> SituacaoString = new Dictionary<int, string>()
        {
            { 0, "Todas Situações" },
            { 1, "Conta à pagar" },
            { 2, "Conta Paga" },
            { 3, "Conta Vencida" }
        };
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int indice = (int)value;
            return SituacaoString[indice];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
