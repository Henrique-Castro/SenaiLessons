using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.AutoPecas.WebApi.Domains;
using Senai.AutoPecas.WebApi.Interfaces;
using Senai.AutoPecas.WebApi.Repositories;

namespace Senai.AutoPecas.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class PecasController : ControllerBase
    {
        IPecasRepository IPecasRepository;

        public PecasController()
        {
            IPecasRepository = new PecasRepository();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(IPecasRepository.ListarTodas());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpGet("codigo")]
        public IActionResult BuscarPorCodigo(int codigo)
        {
            try
            {
                return Ok(IPecasRepository.BuscarPecaPorCodigo(codigo));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpPut("codigo")]
        public IActionResult Atualizar(int codigo, Pecas pecaModificada)
        {
            try
            {
                int IdFornecedor = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti).Value);
                Pecas pecaEncontrada = IPecasRepository.BuscarPecaPorCodigo(codigo);
                if(pecaEncontrada.FornecedorId != IdFornecedor)
                {
                    throw new Exception(message: "Esta peça não é sua, pilantra.");
                }
                else
                {
                IPecasRepository.Atualizar(pecaModificada);
                return Ok();
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpPost]
        public IActionResult Cadastrar(Pecas novaPeca)
        {
            try
            {
                novaPeca.FornecedorId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti).Value);
                IPecasRepository.Cadastrar(novaPeca);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /*Disponibilizar um endpoint para que seja mostrado o valor de ganho que a autopeças irá obter calculando
         * o preço de venda sob o preço de custo. Mostrar a porcentagem e um outro campo mostrando a diferença em reais entre um e outro.*/
        //[HttpGet("precos")]
        //public IActionResult ValorGanhos() { }

        /*Disponibilizar um endpoint público para que seja apresentado os dados de todos os fornecedores.
GET /api/fornecedores

Disponibilizar um endpoint público para que seja apresentado os dados de todos os usuários, mas com um detalhe: a senha não deverá ser mostrada.
GET /api/usuarios

Disponibilizar um endpoint para que ao enviar a quantidade de itens e o id da peça, seja calculado o valor total e este valor seja retornado.
POST /api/pecas/calcular*/
    }
}