using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbQuestao3")]
    public class Questao3
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int? formularioId { get; set; }
        [ForeignKey("formularioId")]
        public virtual Formulario Formulario { get; set; }
        public string detalheExecCumprimento { get; set; }
        public string respDescumprimento { get; set; }
        public string pendenteCom { get; set; }  
        public string pendenteComValue { get; set; }     
    }
}
