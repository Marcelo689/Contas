using GestaoDeContas.Banco;
using GestaoDeContas.Model;
using GestaoDeContas.View;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace GestaoDeContas.ViewModel
{
    public class TelaPrincipalViewModel : BindableBase
    {
        public AtualizarContaView JanelaEditar;
        public bool atualizou = false;
        public string isVisible { get; set; } = "Hidden";

        public bool ComecaNesseMes { get; set; } = false;

        public bool isBoleto = false;
        public bool IsBoleto { get { return isBoleto; }
            set {
                isBoleto = value;
                isVisible = isBoleto ? "Visible" : "Hidden";
                OnPropertyChanged(nameof(isVisible));
                ; }
        }
        public List<int> Parcelas { get; set; } = new List<int>();
        public int NumeroParcelas { get; set; }
        public int NumeroDeDiasEntreParcelas { get; set; } = 30;
        public List<int> QuantidadeDeDias { get; set; } = new List<int>();
        public void PreencheParcelasCampos()
        {
            for (int i = 1; i <= 240; i++)
            {
                Parcelas.Add(i);
            }
            for (int i = 1; i <= 90; i++)
            {
                QuantidadeDeDias.Add(i);
            }

            AtualizaContasVencidas();
        }

        public TelaPrincipalViewModel()
        {
            NovaConta();
            Crud = new EntidadeCrud<Conta>();
            PreencheParcelasCampos();
            CadastrarCommand = new DelegateCommand(Cadastrar);
            FiltrarCommand = new DelegateCommand(Filtrar);
            LiquidarCommand = new DelegateCommand<int?>(Liquidar);
            EditarCommand = new DelegateCommand<int?>(Editar);
            DeletarCommand = new DelegateCommand<int?>(Deletar);
            AtualizarCommand = new DelegateCommand(Atualizar);
            PreencherListaContas();
        }

        private void Deletar(int? id)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja deletar?", "Tela de exclusão",MessageBoxButton.YesNo);
            if(resultado == MessageBoxResult.Yes)
            {
                Crud.Delete(id.Value);
            }
            Filtrar();
        }
        private void Atualizar()
        {
            atualizou = true;
            JanelaEditar.Close();
            Filtrar();
        }

        private void Editar(int? id)
        {
            ContaAtualizar = Crud.GetAll().Where(e => e.Id == id).First();
            JanelaEditar = new AtualizarContaView(this);
            var resultado = JanelaEditar.ShowDialog();
            
            if(atualizou)
                Crud.Update(ContaAtualizar);
            atualizou = false;
            Filtrar();
        }

        public void Liquidar(int? id)
        {
            var entidade = Crud.GetAll().Find(e => e.Id == id);
            entidade.DataFinalizacao = DateTime.Now;
            entidade.Situacao = 2;
            Crud.Update(entidade);
            Filtrar();
        }

        public Conta conta;
        public Conta ContaAtualizar { get; set; }
        public Conta Conta
        {
            get { return conta; }
            set
            {
                SetProperty(ref conta, value);
            }
        }
        public ICommand CadastrarCommand { get; set; }
        public ICommand FiltrarCommand { get; private set; }
        public ICommand LiquidarCommand { get; private set; }
        public ICommand EditarCommand { get; private set; }
        public DelegateCommand<int?> DeletarCommand { get; }
        public ICommand AtualizarCommand { get; }
        public ObservableCollection<Conta> Contas { get; set; }
        public decimal Total { get; set; } 
        public FiltroConta FiltrosConta { get; set; } = new FiltroConta();
        public List<string> ComboSituacao { get; set; } = new List<string>()
        {
                "Todas Situações","Conta à pagar","Conta Paga" , "Conta Vencida" 
        };
        public int SituacaoSelecionada { get; set; }
        public List<string> ComboNecessidade { get; set; } = new List<string>()
        {
            "Todas Necessidades","Necessidade Alta"  , "Necessidade Media"  ,"Necessidade Baixa"  
        };

        private EntidadeCrud<Conta> Crud;
        private void Filtrar()
        {
            Contas = FiltrarContas(FiltrosConta);
            CalcularTotal(Contas);
            OnPropertyChanged(nameof(Contas));
        }

        public void PreencherListaContas()
        {
            Contas = new ObservableCollection<Conta>(Crud.GetAll());
            CalcularTotal(Contas);
            OnPropertyChanged(nameof(Contas));

        }

        public void CalcularTotal(IEnumerable<Conta> contas)
        {
            Total = 0m;
            foreach (var conta in contas)
            {
                Total += conta.Preco;
            }
            OnPropertyChanged(nameof(Total));
        }

        public void NovaConta()
        {
            Conta = new Conta();
            Conta.DataAPagar = DateTime.Now;
            Conta.Necessidade = 0;
            Conta.Nome = "";
            Conta.Preco = 0m;
            OnPropertyChanged(nameof(Conta));
        }

        private void Cadastrar()
        {
            var lista = new List<Conta>();
            if (ContaFormatoCorreto())
            {
                if(Conta.DataAPagar.Date >= DateTime.Now.Date)
                    Conta.Situacao = 1;
                else
                    Conta.Situacao = 3;
                
                Conta.DataCadastro = DateTime.Now;

                int contadorId = Crud.Last().Id + 1;
                DateTime dataAPagarParcelado = Conta.DataAPagar;
                NumeroParcelas = !ComecaNesseMes ? ++NumeroParcelas : NumeroParcelas;
                if (NumeroParcelas > 0)
                {
                    for(int i=0; i< NumeroParcelas+1; i++) {

                        if (i == 0 && ComecaNesseMes || i != 0)
                        {
                            lista.Add(new Conta()
                            {
                                Id = contadorId++,
                                Necessidade = Conta.Necessidade,
                                Preco = Conta.Preco,
                                Nome = Conta.Nome,
                                Situacao = Conta.Situacao,
                                DataCadastro = Conta.DataCadastro,
                                DataAPagar = dataAPagarParcelado,
                            }
                            );
                        }
                        dataAPagarParcelado =  dataAPagarParcelado.AddDays(NumeroDeDiasEntreParcelas+1);
                    }
                    Crud.InsertMultipleEntities(lista);
                }
                else
                {
                    Crud.Create(Conta);
                }
                NovaConta();
                PreencherListaContas();
            }
        }

        public void AtualizaContasVencidas()
        {
            var listaContasVencidas = Crud.GetAll().Where(e => e.Situacao == 1 && DateTime.Now.Date > e.DataAPagar).ToList();
            foreach (var item in listaContasVencidas)
            {
                item.Situacao = 3;
                Crud.Update(item);
            }
        }
        public ObservableCollection<Conta> FiltrarContas(FiltroConta filtros)
        {
            AtualizaContasVencidas();
            string nome = filtros.Nome ?? "";
            DateTime dataI = filtros.DataFinalizacaoI ?? DateTime.MinValue;
            DateTime dataF = filtros.DataFinalizacaoF ?? DateTime.MaxValue;
            DateTime dataAPagarI = filtros.DataAPagarI;
            DateTime dataAPagarF = filtros.DataAPagarF == DateTime.MinValue ? DateTime.MaxValue : filtros.DataAPagarF;
            DateTime cadastroI = filtros.CadastroI;
            DateTime cadastroF = filtros.CadastroF == DateTime.MinValue ? DateTime.MaxValue : filtros.CadastroF;
            int situacao = filtros.Situacao;
            int necessidade = filtros.Necessidade;
            decimal precoI = filtros.PrecoI;
            decimal precoF = filtros.PrecoF == 0 ? decimal.MaxValue : filtros.PrecoF;
            return new ObservableCollection<Conta>(Crud.GetAll().Where(e =>
            ( e.DataAPagar.Date <= dataAPagarF.Date && e.DataAPagar.Date >= dataAPagarI.Date) && 
            ( e.DataCadastro.Date <= cadastroF.Date && e.DataCadastro.Date >= cadastroI.Date) && 
            (e.Preco >= precoI && e.Preco <= precoF) &&
            e.Nome.ToLower().Contains(nome.ToLower())
            ).ToList()
            .Where(e => (situacao == 0 || e.Situacao == situacao))
            .Where(e => (necessidade == 0 || e.Necessidade == necessidade))
            .ToList());
        }

        public bool ContaFormatoCorreto()
        {
            var preco = 0m;
            Decimal.TryParse(Conta.Preco.ToString(), out preco);
            if (!(preco > 0))
                return false;
            if (string.IsNullOrWhiteSpace(Conta.Nome))
                return false;
            
            return true;
        }

    }
}
