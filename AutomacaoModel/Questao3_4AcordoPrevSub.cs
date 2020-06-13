using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbQuestao3_4_APS")]
    public class Questao3_4_APS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int? formularioId { get; set; }
        [ForeignKey("formularioId")]
        public virtual Formulario Formulario { get; set; }
        [MaxLength(3)] public string token { get; set; }
        [MaxLength(3)] public string gravacaoServicoAdicional { get; set; }
        [MaxLength(3)] public string erroTerceiroPrestadora { get; set; }
        [MaxLength(3)] public string faturaPagaNaoContestada { get; set; }
        [MaxLength(3)] public string contratoObjetoAutor { get; set; }
        public DateTime? dataIntalacao { get; set; }
        public int? motivoId { get; set; }
        [ForeignKey("motivoId")]
        public virtual MotivoContestacao MotivoContestacao { get; set; }
        [MaxLength(3)] public string problemaQuebraSigilo { get; set; }
        [MaxLength(50)] public string nro_contratoRelacionado { get; set; }
        [MaxLength(3)] public string multaContratual { get; set; }
        [MaxLength(3)] public string gravacaoFavoravel { get; set; }
        [MaxLength(3)] public string haBoletimOcorrencia { get; set; }
        [MaxLength(3)] public string relatoTecnicoEnvolvido { get; set; }
        [MaxLength(3)] public string danosRessarcidos { get; set; }
        [MaxLength(3)] public string laudoTecnico { get; set; }
        [MaxLength(3)] public string acionamentoSeguro { get; set; }

        [MaxLength(3)] public string foiAtropelamento { get; set; }
        [MaxLength(3)] public string batidaAutomovel { get; set; }
        [MaxLength(3)] public string frotaDaEmpresa { get; set; }
        [MaxLength(3)] public string veiculoEmpresaTerceira { get; set; }
        [MaxLength(50)] public string qualEmpresaTerceira { get; set; }
        [MaxLength(3)] public string empresaAtiva { get; set; }
        [MaxLength(3)] public string placaVeiculo { get; set; }
        [MaxLength(3)] public string culpaMotorista { get; set; }


        [MaxLength(3)] public string caboSolto { get; set; }
        [MaxLength(3)] public string faltaSinal { get; set; }
        [MaxLength(3)] public string infraPedial { get; set; }
        [MaxLength(3)] public string infraDoGrupo { get; set; }
        [MaxLength(3)] public string infraEmpresaTerceira { get; set; }
        [MaxLength(50)] public string empresaTerceiraInfra { get; set; }
        [MaxLength(3)] public string empresaAtivaInfra { get; set; }

    }
}
