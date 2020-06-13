using AutomacaoModel;
using System.Configuration;
using System.Data.Entity;

namespace AutomacaoDal
{
    public class AutomacaoDbContext : DbContext
    {
        public AutomacaoDbContext()
               : base(ConfigurationManager.AppSettings["connectionString"])
        {
        }
        public DbSet<Imagem> Imagems { get; set; }
        public DbSet<Questionario> Questionarios { get; set; }
        public DbSet<TipoFormulario> TipoFormularios { get; set; }
        public DbSet<Formulario> Formularios { get; set; }
        public DbSet<Fraude> Fraudes { get; set; }
        public DbSet<AcordoPrevio> AcordoPrevio { get; set; }
        public DbSet<ExeLimiDesc> ExeLimiDescs { get; set; }
        public DbSet<Acidente> Acidentes { get; set; }
        public DbSet<Portabilidade> Portabilidades { get; set; }
        public DbSet<ProblemasComVenda> ProblemasComVendas { get; set; }
        public DbSet<MigracaoIndevida> MigracaoIndevidas { get; set; }
        public DbSet<NegativacaoIndevida> NegativacaoIndevidas { get; set; }
        public DbSet<Cancelamento> Cancelamentos { get; set; }
        public DbSet<EntregaAparelho> EntregaAparelhos { get; set; }
        public DbSet<ProblemaTecnico> ProblemaTecnicos { get; set; }
        public DbSet<ServicoAdicional> ServicoAdicionais { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<ResponsavelDescumprimento> ResponsavelDescumprimentos { get; set; }
        public DbSet<Ano> Anos { get; set; }
        public DbSet<Pendente> Pendentes { get; set; }
        public DbSet<AreaCausadora> AreaCausadoras { get; set; }
        public DbSet<CentroCusto> CentroCustos { get; set; }
        public DbSet<Motivo> Motivo { get; set; }
        public DbSet<SubMotivo> SubMotivo { get; set; }
        public DbSet<PercursoCobranca> PercursoCobrancas { get; set; }
        public DbSet<Questao5> Questao5s { get; set; }
        public DbSet<Questao6> Questao6s { get; set; }
        public DbSet<ParceiroOfensor> ParceiroOfensores { get; set; }
        public DbSet<Questao1> Questao1s { get; set; }
        public DbSet<Questao3> Questao3s { get; set; }
        public DbSet<Questao7> Questao7s { get; set; }
        public DbSet<FormularioAcordo> FormularioAcordos { get; set; }
        public DbSet<Questao4> Questao4s { get; set; }
        public DbSet<Questao3_4_APS> Questao3_4_APSs { get; set; }
        public DbSet<MotivoContestacao> MotivoContestacaos { get; set; }
        public DbSet<LogMudancaFormulario> LogMudancaFormularios { get; set; } 
        public DbSet<ReclamacaoCliente> ReclamacaoClientes { get; set; }
        public DbSet<Canal> Canals { get; set; }
        public DbSet<RedeCobertura> RedeCoberturas { get; set; }
        public DbSet<Outros> Outross { get; set; }
        public DbSet<RespostaOperacao> RespostaOperacaos { get; set; }
        public DbSet<StatusReabertura> StatusReaberturas { get; set; }
        public DbSet<Questao10> Questao10s { get; set; }
        public DbSet<Questao11> Questao11s { get; set; }
        public DbSet<Questao12> Questao12s { get; set; }
        public DbSet<Questao13> Questao13s { get; set; }
        public DbSet<Questao14> Questao14s { get; set; }
        public DbSet<QuestaoNet> QuestaoNets { get; set; }
        //public DbSet<SubContrato> SubContratos { get; set; }
    }
}
