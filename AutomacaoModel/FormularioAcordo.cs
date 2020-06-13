using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbFormularioAcordo")]
    public class FormularioAcordo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int? formularioId { get; set; }
        [ForeignKey("formularioId")]
        public virtual Formulario Formulario { get; set; }
        public DateTime? DataAcordo { get; set; }
        public DateTime? Mes { get; set; }
        public DateTime? DataUltimaAcao { get; set; }
        public string Cenario { get; set; }
        public int? MotivoProcesso { get; set; }
        public int? Fechamento { get; set; }
        public decimal? ValorSolicitado { get; set; }
        public decimal? ValorAlcada { get; set; }
        public decimal? ValorAcordoDanosMorais { get; set; }
        public decimal? ValorAcordoDanosMateriais { get; set; }
        public decimal? ValorAcordoObriogacao { get; set; }
        public int? ContatoCom { get; set; }
        [MaxLength(50)] public string Email { get; set; }
        [MaxLength(20)] public string Telefone { get; set; }
        public int? Alcada { get; set; }
        public int? Critico { get; set; }
        public int? Estado { get; set; }
        public DateTime? DataNascimento { get; set; }

    }
}

