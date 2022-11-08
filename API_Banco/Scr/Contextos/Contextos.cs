using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static API_Banco.Scr.Modelos.DadosClienteModelo;
using static API_Banco.Scr.Modelos.DadosTransferenciaModelo;

namespace API_Banco.Scr.Modelos.Contextos
{
    public class Contextos
    {
        ///Resumo: Classe contexto, responsavel por carregar contexto e definir DbSets

        public class API_BancoContexto : DbContext
        {
            #region Atributos
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Transferencia> Transferencias { get; set; }
            #endregion
            #region Construtores
            public API_BancoContexto(DbContextOptions<API_BancoContexto> opt) :
            base(opt)
            {
            }
            #endregion
        }
    }
}
