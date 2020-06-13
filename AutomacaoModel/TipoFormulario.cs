using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbTipoFormulario")]
    public class TipoFormulario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [MaxLength(50)] public string tipo { get; set; }
        [MaxLength(300)] public string urlTemplate { get; set; }
    }
}
