using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbSubMotivo")]
    public class SubMotivo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int? motivoId { get; set; }
        [ForeignKey("motivoId")]
        public virtual Motivo Motivo { get; set; }
        public string nome { get; set; }
    }
}
