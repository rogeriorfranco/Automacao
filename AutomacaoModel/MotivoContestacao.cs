using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbMotivoContestacao")]
    public class MotivoContestacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }        
        public string nome { get; set; }
        public bool? historicoCliente { get; set; }
        public bool? detalhamentoProblema { get; set; }
        public bool? dataHablitacao { get; set; }
        public bool? cobranca { get; set; }
        public bool? contratoObjetoAutor { get; set; }
        public bool? token { get; set; }
        public bool? gravacaoRelacionda { get; set; }
        public bool? problemaQuebraSigilo { get; set; }
        public bool? nro_contratoRelacionado { get; set; }
        public bool? multaContratual { get; set; }        
        public bool? gravacaoFavoravel { get; set; }
        public bool? haBoletimOcorrencia { get; set; }
        public bool? relatoTecnicoEnvolvido { get; set; }
        public bool? danosRessarcidos { get; set; }
        public bool? laudoTecnico { get; set; }
        public bool? acionamentoSeguro { get; set; }

        public bool? foiAtropelamento { get; set; }   
        public bool? batidaAutomovel { get; set; }      
        public bool? frotaDaEmpresa { get; set; }        
        public bool? veiculoEmpresaTerceira { get; set; }        
        public bool? qualEmpresaTerceira { get; set; }        
        public bool? empresaAtiva { get; set; }        
        public bool? placaVeiculo { get; set; }        
        public bool? culpaMotorista { get; set; }

        public bool? caboSolto { get; set; }        
        public bool? faltaSinal { get; set; }        
        public bool? infraPedial { get; set; }        
        public bool? infraDoGrupo { get; set; }        
        public bool? infraEmpresaTerceira { get; set; }        
        public bool? empresaTerceiraInfra { get; set; }
        public bool? empresaAtivaInfra { get; set; }
    }
}
