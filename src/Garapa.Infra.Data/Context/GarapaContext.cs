using System;
using System.Collections.Generic;
using System.Text;
using Garapa.Domain.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Cantina.Infra.Data.Context
{
    public class GarapaContext : DbContext
    {
        public GarapaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
