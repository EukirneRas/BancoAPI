using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API_Banco.Scr.Modelos
{
    public class DadosTransferenciaModelo
    {
        ///Resumo: Classe responsavel por representar tb_transferencia no banco.
        [Table("tb_transferencias")]
        public class Transferencia
        {

            #region Atributos
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public string ChavePixOrigem { get; set; }
            public float Valor { get; set; }
            public string ChavePixDestino { get; set; }
            #endregion
            
        }
    }
}
