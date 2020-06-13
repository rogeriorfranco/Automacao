using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbCidade")]
    public class Cidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int estadoId { get; set; }
        [ForeignKey("estadoId")]
        public virtual Estado Estado { get; set; }
        [MaxLength(200)] public string nome { get; set; }
    }
}
