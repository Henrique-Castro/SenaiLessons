﻿using Microsoft.AspNetCore.Mvc;
using Senai.Filmes.WebApi.Domains;
using Senai.Filmes.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Filmes.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        GeneroRepository repositorio = new GeneroRepository();
        [HttpGet]
        public IEnumerable<GeneroDomain> ListarTodos()
        {
            return repositorio.Listar();
        }
    }
}