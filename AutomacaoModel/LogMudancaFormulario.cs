using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbLogMudancaFormulario")]
    public class LogMudancaFormulario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public long id_caso { get; set; }
        public int tipoFormularioId { get; set; }
        [ForeignKey("tipoFormularioId")]
        public virtual TipoFormulario TipoFormulario { get; set; }
        public DateTime dataCadastro  { get; set; } = DateTime.Now;
    }
}
