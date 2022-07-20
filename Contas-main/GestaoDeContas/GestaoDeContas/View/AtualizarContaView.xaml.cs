using GestaoDeContas.Banco;
using GestaoDeContas.Model;
using GestaoDeContas.ViewModel;
using System.Windows;

namespace GestaoDeContas.View
{
    /// <summary>
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class AtualizarContaView : Window
    {
        public AtualizarContaView(TelaPrincipalViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
