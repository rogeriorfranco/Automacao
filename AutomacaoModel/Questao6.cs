using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbQuestao6")]
    public class Questao6
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int? formularioId { get; set; }
        [ForeignKey("formularioId")]
        public virtual Formulario Formulario { get; set; }
        public int? areaCausadoraId { get; set; }
        [ForeignKey("areaCausadoraId")]
        public virtual AreaCausadora AreaCausadora { get; set; }
        public int? centroCustoId { get; set; }
        [ForeignKey("centroCustoId")]
        public virtual CentroCusto CentroCusto { get; set; }
        public int? motivoId { get; set; }
        [ForeignKey("motivoId")]
        public virtual Motivo Motivo { get; set; }
        public int? subMotivoId { get; set; }
        [ForeignKey("subMotivoId")]
        public virtual SubMotivo SubMotivo { get; set; }
        public int? mes { get; set; }
        public int? anoId { get; set; }
        [ForeignKey("anoId")]
        public virtual Ano Ano { get; set; }
        public int? percursoCobrancaId { get; set; }
        [ForeignKey("percursoCobrancaId")]
        public virtual PercursoCobranca PercursoCobranca { get; set; }
        public bool? CanalCritico { get; set; }
        public string MemorandoAtendimento { get; set; }
        [MaxLength(20)] public string NumeroConta { get; set; }
        public int? qualCanalID { get; set; }
        [ForeignKey("qualCanalID")]
        public virtual Canal Canal { get; set; }
        public string ProtocoloManifesto { get; set; }
    }
}
