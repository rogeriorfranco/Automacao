using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbQuestionario")]
    public class Questionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string questao { get; set; }
        public int numero { get; set; }
        public int? sub_nro { get; set; }
        public int tipoFormularioId { get; set; }

        [ForeignKey("tipoFormularioId")]
        public virtual TipoFormulario TipoFormulario { get; set; }
    }
}
