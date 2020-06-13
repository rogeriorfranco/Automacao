using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbFormulario")]
    public class Formulario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public long id_caso { get; set; }

        public int tipoFormularioId { get; set; }
        [ForeignKey("tipoFormularioId")]
        public virtual TipoFormulario TipoFormulario { get; set; }

        [MaxLength(150)] public string cliente { get; set; }
        [MaxLength(20)] public string cpf { get; set; }
        [MaxLength(50)] public string nro_linha { get; set; }
        [MaxLength(50)] public string nro_contrato { get; set; }
        [MaxLength(50)] public string nro_processo { get; set; }
        [MaxLength(50)] public string tipo_demanda { get; set; }
        public string resumo_reclamacao { get; set; }
        public string reclamacao_cliente { get; set; }
        public string observacoes { get; set; }
        public string empresa { get; set; }
        public string produto { get; set; }
        public string escritorio { get; set; }
        public string status { get; set; }
        public string dt_audiencia { get; set; }
        public string valor_requerido { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public bool atendido { get; set; }
    }
}
