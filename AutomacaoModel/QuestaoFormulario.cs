using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbQuestaoFormulario")]
    public class QuestaoFormulario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int formularioId { get; set; }
        [ForeignKey("formularioId")]
        public virtual Formulario Formulario { get; set; }
        public int nro_pergunta { get; set; }
        public int? sub_nro { get; set; }
        [MaxLength(15)] public string flag_questao { get; set; }
        public string questao { get; set; }
    }
}
