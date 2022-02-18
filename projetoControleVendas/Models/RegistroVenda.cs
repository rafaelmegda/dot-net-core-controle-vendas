using projetoControleVendas.Models.Enums;
using System;

namespace projetoControleVendas.Models
{
    public class RegistroVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantidade { get; set; }
        public StatusVenda Status { get; set; }
        public Departamento Departamento { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVenda()
        {

        }

        public RegistroVenda(int id, DateTime data, double quantidade, StatusVenda status, Departamento departamento, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantidade = quantidade;
            Status = status;
            Departamento = departamento;
            Vendedor = vendedor;
        }
    }
}
