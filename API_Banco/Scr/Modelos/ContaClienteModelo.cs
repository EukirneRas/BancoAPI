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
    public class ContaClienteModelo

    {
        #region Atributos
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Depositario { get; set; }
        public string Depositante { get; set; }
        public string ChavePix { get; set; }

        #endregion
    }
}
