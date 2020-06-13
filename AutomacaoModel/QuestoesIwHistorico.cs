using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("QuestoesIwHistorico")]
    public class QuestoesIwHistorico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //Questao 1
        public string cidade { get; set; }
        public string telefone { get; set; }
        //Questao 3_4
        public string token { get; set; }
        public string gravacaoServicoAdicional { get; set; }
        public string erroTerceiroPrestadora { get; set; }
        public string faturaPagaNaoContestada { get; set; }
        public string contratoObjetoAutor { get; set; }
        public string dataIntalacao { get; set; }
        public string motivo { get; set; }     
        public string problemaQuebraSigilo { get; set; }
        public string nro_contratoRelacionado { get; set; }
        public string multaContratual { get; set; }
        public string gravacaoFavoravel { get; set; }
        public string haBoletimOcorrencia { get; set; }
        public string relatoTecnicoEnvolvido { get; set; }
        public string danosRessarcidos { get; set; }
        public string laudoTecnico { get; set; }
        public string acionamentoSeguro { get; set; }
        public string foiAtropelamento { get; set; }
        public string batidaAutomovel { get; set; }
        public string frotaDaEmpresa { get; set; }
        public string veiculoEmpresaTerceira { get; set; }
        public string qualEmpresaTerceira { get; set; }
        public string empresaAtiva { get; set; }
        public string placaVeiculo { get; set; }
        public string culpaMotorista { get; set; }
        public string caboSolto { get; set; }
        public string faltaSinal { get; set; }
        public string infraPedial { get; set; }
        public string infraDoGrupo { get; set; }
        public string infraEmpresaTerceira { get; set; }
        public string empresaTerceiraInfra { get; set; }
        public string empresaAtivaInfra { get; set; }
        //Questao 5
        public string DataTentativa1 { get; set; }
        public string ValorProposta1 { get; set; }
        public string DataTentativa2 { get; set; }
        public string ValorProposta2 { get; set; }
        public string DataTentativa3 { get; set; }
        public string ValorProposta3 { get; set; }
        public string ValorPropostaAcordo { get; set; }
        public string reclamacaoCliente { get; set; }
        public string AcordoPrevio { get; set; }
        public string Comentario1 { get; set; }
        public string Comentario2 { get; set; }
        public string Comentario3 { get; set; }
        //Questao 6
        public string areaCausadora { get; set; }
        public string centroCusto { get; set; }
        public string motivoQ5 { get; set; }
        public string subMotivoId { get; set; }
        public string mes { get; set; }
        public string ano { get; set; }
        public string percursoCobranca { get; set; }
        public string MemorandoAtendimento { get; set; }
        public string NumeroConta { get; set; }
        public string Canal { get; set; }
        public string ProtocoloManifesto { get; set; }
        //Questao 7
        public string ExclusaoNegativacao { get; set; }
        public string CorrecaoCobrancaIndevida { get; set; }
        public string CancelamentoIsencao { get; set; }
        public string CancelamentoCobranca { get; set; }
        public string ReclamacaoCliente { get; set; }
        public string Pendente { get; set; }
        public string parceiroOfenso { get; set; }
        public string ConsideracoesFinais { get; set; }
        public string SolucaoProblemas { get; set; }
        public string Fechamento { get; set; }
        public string PendenteValor { get; set; }
        //Questao 10
    }
}