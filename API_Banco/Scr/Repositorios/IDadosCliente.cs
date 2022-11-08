using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Banco.Scr.Repositorios
{
    ///Resumo: Responsavel por representar ações de CRUD de usuario
    public interface IDadosCliente
    {
        Task<DadosCliente> PegarDadosClientePeloChavePixAsync(string ChavePix);
        Task NovoDadosClienteAsync(DadosCliente dadosCliente);
        Task PegarClientePelaChavePixAsync(object chavepixDadosCliente);
    }
}
