using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbMotivo")]
    public class Motivo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int? areaCausadoraId { get; set; }
        [ForeignKey("areaCausadoraId")]
        public virtual AreaCausadora AreaCausadora { get; set; }
        public string nome { get; set; }
    }
}
