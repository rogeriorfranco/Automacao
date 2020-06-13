using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbProduto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int empresaId { get; set; }
        [ForeignKey("empresaId")]
        public virtual Empresa Empresa { get; set; }
        [MaxLength(200)] public string nome { get; set; }
    }
}
