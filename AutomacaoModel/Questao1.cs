using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbQuestao1")]
    public class Questao1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int? formularioId { get; set; }
        [ForeignKey("formularioId")]
        public virtual Formulario Formulario { get; set; }
        //public int? EmpresaId { get; set; }
        //[ForeignKey("EmpresaId")]
        //public virtual Empresa Empresa { get; set; }
        //public int? ProdutoId { get; set; }
        //[ForeignKey("ProdutoId")]
        //public virtual Produto Produto { get; set; }
        public int? CidadeId { get; set; }
        [ForeignKey("CidadeId")]
        public virtual Cidade Cidade { get; set; }
        public string telefone { get; set; }
        public bool iscliente { get; set; }       
    }
}
