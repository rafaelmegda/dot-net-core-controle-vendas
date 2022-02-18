﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoControleVendas.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendasDoDepartamento(DateTime dataInicial, DateTime dataFinal)
        {
            return Vendedores.Sum(vendedores => vendedores.TotalVendas(dataInicial, dataFinal));
        }
    }

    

}
