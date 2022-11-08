using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static API_Banco.Scr.Modelos.DadosTransferenciaModelo;

namespace API_Banco.Scr.Modelos
{
    public class DadosClienteModelo
    {
        ///Resumo: Classe responsavel por representar tb_clientes no banco.
        [Table("tb_clientes")]
        public class Cliente
        {
            #region Atributos
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Documento { get; set; }
            public string ChavePix { get; set; }

            [JsonIgnore, InverseProperty("Pix")]
            public List<Transferencia> MinhaTransferencia { get; set; }

            [ForeignKey("fk_transferencia")]
            public DadosTransferenciaModelo Transferencia { get; set; }
            #endregion
        }

    }
}
