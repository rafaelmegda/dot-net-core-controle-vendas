﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projetoControleVendas.Models;

namespace projetoControleVendas.Data
{
    public class projetoControleVendasContext : DbContext
    {
        public projetoControleVendasContext (DbContextOptions<projetoControleVendasContext> options)
            : base(options)
        {
        }

        public DbSet<projetoControleVendas.Models.Departamento> Departamento { get; set; }
    }
}
