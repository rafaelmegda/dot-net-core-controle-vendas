using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoControleVendas.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Salario { get; set; }
        public ICollection<RegistroVenda> RegistrosVendas { get; set; } = new List<RegistroVenda>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salario)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Salario = salario;
        }

        //add venda para vendedor
        public void AdicionarVendas(RegistroVenda registroVenda)
        {
            RegistrosVendas.Add(registroVenda);
        }

        //remover venda do vendedor
        public void RemoverVenda(RegistroVenda registroVenda)
        {
            RegistrosVendas.Remove(registroVenda); 
        }

        //total vendas no periodo
        public double TotalVendas(DateTime dataInicial, DateTime dataFinal)
        {
            return RegistrosVendas.Where(registroVendas => registroVendas.Data >= dataInicial &&
                registroVendas.Data <= dataFinal).Sum(registroVendas => registroVendas.Quantidade);
        }
    }
}
