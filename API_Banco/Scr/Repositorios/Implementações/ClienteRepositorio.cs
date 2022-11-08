using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static API_Banco.Scr.Modelos.Contextos.Contextos;
using static API_Banco.Scr.Modelos.DadosClienteModelo;

namespace API_Banco.Scr.Repositorios.Implementações
{
    ///Resumo: Classe responsavel por implementar IUsuario
    public class ClienteRepositorio : IDadosCliente
    {
        #region Atributos
        private readonly API_BancoContexto _contexto;
        #endregion

        #region Construtores
        public ClienteRepositorio(API_BancoContexto contexto)
        {
            _contexto = contexto;
        }
        #endregion

        #region Métodos
        ///Resumo: Método assíncrono para pegar um usuario pelo email
        public async Task<Cliente> PegarClientePeloPixAsync(string pix)
        {
            return await _contexto.Clientes.FirstOrDefaultAsync(u => u.ChavePix == pix);
        }

        #endregion
    }

    ///Resumo: Método assíncrono para salvar um novo usuario
    public async Task NovoClienteAsync(Cliente cliente)
    {
        await _contexto.Clientes.AddAsync(
        new Cliente
        {
            Nome = cliente.Nome,
            Documento = cliente.Documento,
            ChavePix = cliente.ChavePix
        });
        await _contexto.SaveChangesAsync();
    }

}