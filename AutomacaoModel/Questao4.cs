using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbQuestao4")]
    public class Questao4
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int? formularioId { get; set; }
        [ForeignKey("formularioId")]
        public virtual Formulario Formulario { get; set; }
        public bool? ClienteNegativado { get; set; }
        public bool? NegociacaoTerceiro { get; set; }
        public bool? TemGravacao { get; set; }
        public bool? GravacaoContra { get; set; }
        public bool? PagouFatura { get; set; }
        public bool? ContratoAssinado { get; set; }
        public bool? PUReclamacaoPeticao { get; set; }
        public bool? EsperandoPrazoEntrega { get; set; }
        public bool? EnderecoInformadoCorreto { get; set; }
        public bool? CompararEnderecoComAutor { get; set; }
        public string Comentario { get; set; }
        public bool? ReclamacaoAtendidaAnteriormente { get; set; }
        public string MemorandoAtendimento { get; set; }
    }
}
