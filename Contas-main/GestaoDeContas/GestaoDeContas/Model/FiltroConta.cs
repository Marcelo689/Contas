using Prism.Mvvm;
using System;
using System.ComponentModel.DataAnnotations;

namespace GestaoDeContas.Model
{
    public class FiltroConta : DomainObject
    {
        public DateTime? DataFinalizacaoI { get; set; }
        public DateTime? DataFinalizacaoF { get; set; }
        public DateTime DataAPagarI { get; set; }// ja foi
        public DateTime DataAPagarF { get; set; }// ja foi
        public DateTime CadastroI { get; set; }
        public DateTime CadastroF { get; set; }
        public int Situacao { get; set; }
        public int Necessidade { get; set; }
        public string Nome { get; set; } // ja foi
        public decimal PrecoI{ get; set; }// ja foi
        public decimal PrecoF{ get; set; }// ja foi
    }
}
