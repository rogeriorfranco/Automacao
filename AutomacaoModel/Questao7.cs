using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbQuestao7")]
    public class Questao7
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int? formularioId { get; set; }
        [ForeignKey("formularioId")]
        public virtual Formulario Formulario { get; set; }
        public bool? ExclusaoNegativacao { get; set; }
        public bool? CorrecaoCobrancaIndevida { get; set; }
        public bool? CancelamentoIsencao { get; set; }
        public bool? CancelamentoCobranca { get; set; }
        public int? ReclamacaoCliente { get; set; }
        public virtual string Pendente { get; set; }
        public int? parceiroOfensorId { get; set; }
        [ForeignKey("parceiroOfensorId")]
        public virtual ParceiroOfensor ParceiroOfensor { get; set; }        
        public string ConsideracoesFinais { get; set; }
        public string SolucaoProblemas { get; set; }
        public int? Fechamento { get; set; }
        public string PendenteValor { get; set; }
    }
}
