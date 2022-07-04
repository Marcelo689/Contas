using Prism.Mvvm;
using System;
using System.ComponentModel.DataAnnotations;

namespace GestaoDeContas.Model
{
    public class Conta : DomainObject
    {
        public string Nome { get; set; }
        public decimal Preco{ get; set; }
        public DateTime DataAPagar{ get; set; }
        public int Situacao{ get; set; } // conta paga/vencida
        public int Necessidade{ get; set; } // conta paga/vencida
        //0 - em aberto,
        //1 - paga,
        //2 - vencida
        public DateTime? DataFinalizacao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
