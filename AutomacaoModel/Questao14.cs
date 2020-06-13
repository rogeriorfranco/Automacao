using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbQuestao14")]
    public class Questao14
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int? formularioId { get; set; }
        [ForeignKey("formularioId")]
        public virtual Formulario Formulario { get; set; }
        public string resposta { get; set; }

    }
}
