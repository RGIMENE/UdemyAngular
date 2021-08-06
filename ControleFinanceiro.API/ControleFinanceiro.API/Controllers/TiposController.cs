using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControleFinanceiro.DAL;
using ControleFinanceito.BLL.Models;
using ControleFinanceiro.DAL.Interfaces;

namespace ControleFinanceiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposController : ControllerBase
    {
        private readonly ITipoRepositorio _tipoRepositorio;

        public TiposController(ITipoRepositorio tipoRepositorio)
        {
            _tipoRepositorio = tipoRepositorio;
        }

        // GET: api/Tipos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tipo>>> GetTipos()
        {
            return await _tipoRepositorio.PegarTodos().ToListAsync();
        }

    }
}
