using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbQuestao5")]
    public class Questao5
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int? formularioId { get; set; }
        [ForeignKey("formularioId")]
        public virtual Formulario Formulario { get; set; }
        public DateTime? DataTentativa1 { get; set; }
        public Decimal? ValorProposta1 { get; set; }
        public DateTime? DataTentativa2 { get; set; }
        public Decimal? ValorProposta2 { get; set; }
        public DateTime? DataTentativa3 { get; set; }
        public Decimal? ValorProposta3 { get; set; }
        public Decimal? ValorPropostaAcordo { get; set; }
        public int? reclamacaoClienteId { get; set; }
        [ForeignKey("reclamacaoClienteId")]
        public virtual ReclamacaoCliente ReclamacaoCliente { get; set; }
        public bool? AcordoPrevio { get; set; }
        public string Comentario1 { get; set; }
        public string Comentario2 { get; set; }
        public string Comentario3 { get; set; }
    }
}
