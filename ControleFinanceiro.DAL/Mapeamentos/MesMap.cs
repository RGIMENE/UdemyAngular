using ControleFinanceito.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Mapeamentos
{
    public class MesMap : IEntityTypeConfiguration<Mes>
    {

        public void Configure(EntityTypeBuilder<Mes> builder)
        {

            builder.HasKey(m => m.MesId);
            builder.Property(m => m.Nome).IsRequired().HasMaxLength(20);
            builder.HasIndex(m => m.Nome).IsUnique();

            builder.HasMany(m => m.Despesas).WithOne(m => m.Mes);

            builder.HasMany(m => m.Ganhos).WithOne(m => m.Mes);


            builder.HasData(
                new Mes
                {
                    MesId = 1,
                    Nome = "Jan"
                },
                new Mes
                {
                    MesId = 2,
                    Nome = "Fev"
                },
                new Mes
                {
                    MesId = 3,
                    Nome = "Mar"
                },
                new Mes
                {
                    MesId = 4,
                    Nome = "Abr"
                },
                new Mes
                {
                    MesId = 5,
                    Nome = "Mai"
                },
                new Mes
                {
                    MesId = 6,
                    Nome = "Jun"
                },
                new Mes
                {
                    MesId = 7,
                    Nome = "Jul"
                },
                new Mes
                {
                    MesId = 8,
                    Nome = "Ago"
                },
                new Mes
                {
                    MesId = 9,
                    Nome = "Set"
                },
                new Mes
                {
                    MesId = 10,
                    Nome = "Out"
                },
                new Mes
                {
                    MesId = 11,
                    Nome = "Nov"
                },
                new Mes
                {
                    MesId = 12,
                    Nome = "Dez"
                });

            builder.ToTable("Meses");

        }
    }
}
