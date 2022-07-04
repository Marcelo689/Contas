using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestaoDeContas.UsersControl
{
    /// <summary>
    /// Interação lógica para PesquisarUserControl.xam
    /// </summary>
    public partial class PesquisarUserControl : UserControl
    {
        public PesquisarUserControl()
        {
            InitializeComponent();
            comboNecessidade.SelectedIndex = 3;
            comboSituacao.SelectedIndex = 3;
        }

        private void TextBoxPrecoF_LostFocus(object sender, RoutedEventArgs e)
        {
            var entrada = TextBoxPrecoF.Text;
            if (string.IsNullOrWhiteSpace(entrada))
                TextBoxPrecoF.Text = 0m.ToString();
        }

        private void TextBoxPrecoI_LostFocus(object sender, RoutedEventArgs e)
        {
            var entrada = TextBoxPrecoI.Text;
            if (string.IsNullOrWhiteSpace(entrada))
                TextBoxPrecoI.Text = 0m.ToString();
        }
    }
}
