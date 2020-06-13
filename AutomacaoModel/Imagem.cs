using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbImagem")]
    public class Imagem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int formularioId { get; set; }
        [ForeignKey("formularioId")]
        public virtual Formulario Formulario { get; set; }
        public int nro_pergunta { get; set; }
        public int? sub_nro { get; set; }
        public byte[] img { get; set; }
        public byte[] imgRedimensionada{ get; set; }
        public DateTime? dt_cadastro { get; set; } = DateTime.Now;
    }
}
