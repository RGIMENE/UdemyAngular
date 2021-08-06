using ControleFinanceiro.DAL.Interfaces;
using ControleFinanceito.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Repositorios
{
    public class TipoRepositorio : RepositorioGenerico<Tipo>, ITipoRepositorio
    {
        public TipoRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
