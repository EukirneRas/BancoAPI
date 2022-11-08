using API_Banco.Scr.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static API_Banco.Scr.Modelos.DadosClienteModelo;

namespace API_Banco.Scr.Controladores
{
    [ApiController]
    [Route("api/Clientes")]
    [Produces("application/json")]

    public class ClientesControlador
    {
        #region Atributos
        private readonly IDadosCliente _repositorio;
        #endregion
        #region Construtores
        public ClientesControlador(IDadosCliente repositorio)
        {
            _repositorio = repositorio;
        }
        #endregion
        #region Métodos
        #endregion


        [HttpGet("ChavePix/{chavepixUsuario}")]
        public async Task<ActionResult> PegarClientePelaChavePixAsync([FromRoute] string chavepixDadosCliente)
        {
            var cliente = await _repositorio.PegarClientePelaChavePixAsync(chavepixDadosCliente);
            if (cliente == null) return NotFound(new
            {
                Mensagem = "Cliente não encontrado"
            });
            return Ok(cliente);
        }

        [HttpPost]
        public async Task<ActionResult> NovoClienteAsync([FromBody] Cliente cliente)
        {
            await _repositorio.NovoDadosClienteAsync(cliente);
            return Created($"api/DadosCliente/{cliente.ChavePix}", cliente);
        }

    }
}
