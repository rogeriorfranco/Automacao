using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbAcordoPrevio")]
    public class AcordoPrevio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int formularioId { get; set; }
        [ForeignKey("formularioId")]
        public virtual Formulario Formulario { get; set; }

        [MaxLength(15)] public string questao_1 { get; set; }
        public string obs_questao_1 { get; set; }
        [MaxLength(15)] public string questao_1_1 { get; set; }
        public string obs_questao_1_1 { get; set; }
        [MaxLength(15)] public string questao_1_2 { get; set; }
        public string obs_questao_1_2 { get; set; }
        [MaxLength(15)] public string questao_1_3 { get; set; }
        public string obs_questao_1_3 { get; set; }
        [MaxLength(15)] public string questao_1_4 { get; set; }
        public string obs_questao_1_4 { get; set; }       
        public string obs_questao_2 { get; set; }        
        public string obs_questao_3 { get; set; }
        [MaxLength(50)] public string questao_4 { get; set; }
        public string obs_questao_4 { get; set; }
        [MaxLength(50)] public string questao_5 { get; set; }
        public string obs_questao_5 { get; set; }
        [MaxLength(50)] public string questao_6 { get; set; }
        public string obs_questao_6 { get; set; }
        [MaxLength(50)] public string questao_7 { get; set; }
        public string obs_questao_7 { get; set; }      
        public string consideracao { get; set; }
        public string obs_questao_9 { get; set; }
        public bool preenchimentoCompleto { get; set; }
    }
}
