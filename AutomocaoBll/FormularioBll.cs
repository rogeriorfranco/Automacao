using AutomacaoDal;
using AutomacaoModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class FormularioBll
    {
        IFormularioDal formularioBll = new FormularioDal();

        public async Task<Formulario> readAsync(int idCaso, int id_tipo_formulario)
        {
            return await formularioBll.readAsync(idCaso, id_tipo_formulario);
        }

        public Formulario read(int idCaso, int id_tipo_formulario)
        {
            return formularioBll.read(idCaso, id_tipo_formulario);
        }
        public Formulario read(int id_caso)
        {
            return formularioBll.read(id_caso);
        }
        public List<Formulario> list(int idCaso, int id_tipo_formulario)
        {
            return formularioBll.list(idCaso, id_tipo_formulario);
        }
        public List<Formulario> list(int idCaso)
        {
            return formularioBll.list(idCaso);
        }

        public DataTable listaFormulario(int idCaso, string cliente, string cpf, string tipo_demanda)
        {
            return formularioBll.listaFormulario(idCaso, cliente, cpf, tipo_demanda);
        }

        public DataTable cabecalhoPdf(int idCaso, int id_tipo_formulario)
        {
            return formularioBll.cabecalhoPdf(idCaso, id_tipo_formulario);
        }

        public void save(Formulario f)
        {
            formularioBll.save(f);
        }

        public void deleteFormulario(int id, string tabela)
        {
            formularioBll.deleteFormulario(id, tabela);
        }

        public void update(int id, string nro_linha, string nro_contrato, bool atendido)
        {
            formularioBll.update(id, nro_linha, nro_contrato, atendido);
        }
        public List<Formulario1> apiTeste()
        {
          return  formularioBll.apiTeste();
        }
        public Tuple<int, string, string> subsidioPreenchido(int idCaso)
        {
            var form = formularioBll.read(idCaso);
            Tuple<int, string, string> t = null;
            if (form != null)
            {
                switch (form.tipoFormularioId)
                {
                    case 1:
                        FraudeDal fraude = new FraudeDal();
                        var f = fraude.read().Where(x => x.Formulario.id_caso == idCaso);
                        if (f.Count() > 0)
                            t = new Tuple<int, string, string>(f.FirstOrDefault().id, "Fraude", "TbFraude");

                        break;

                    case 6:
                        AcidenteDal acidente = new AcidenteDal();
                        var a = acidente.read().Where(x => x.Formulario.id_caso == idCaso);
                        if (a.Count() > 0)
                            t = new Tuple<int, string, string>(a.FirstOrDefault().id, "Acidente", "TbAcidente");

                        break;

                    case 7:
                        PortabilidadeDal portabilidade = new PortabilidadeDal();
                        var p = portabilidade.read().Where(x => x.Formulario.id_caso == idCaso);
                        if (p.Count() > 0)
                            t = new Tuple<int, string, string>(p.FirstOrDefault().id, "Portabilidade", "TbPortabilidade");

                        break;

                    case 8:
                        ProblemasComVendasDal problemasComVendas = new ProblemasComVendasDal();
                        var pr = problemasComVendas.read().Where(x => x.Formulario.id_caso == idCaso);
                        if (pr.Count() > 0)
                            t = new Tuple<int, string, string>(pr.FirstOrDefault().id, "Problemas Com Vendas", "TbProblemasComVendas");

                        break;

                    case 9:
                        MigracaoIndevidaDal migracaoIndevida = new MigracaoIndevidaDal();
                        var m = migracaoIndevida.read().Where(x => x.Formulario.id_caso == idCaso);
                        if (m.Count() > 0)
                            t = new Tuple<int, string, string>(m.FirstOrDefault().id, "Migração Indevida", "TbMigracaoIndevida");

                        break;

                    case 10:
                        NegativacaoIndevidaDal negativacaoIndevida = new NegativacaoIndevidaDal();
                        var n = negativacaoIndevida.read().Where(x => x.Formulario.id_caso == idCaso);
                        if (n.Count() > 0)
                            t = new Tuple<int, string, string>(n.FirstOrDefault().id, "Negativação Indevida", "TbNegativacaoIndevida");

                        break;

                    case 11:
                        CancelamentoDal cancelamento = new CancelamentoDal();
                        var c = cancelamento.read().Where(x => x.Formulario.id_caso == idCaso);
                        if (c.Count() > 0)
                            t = new Tuple<int, string, string>(c.FirstOrDefault().id, "Cancelamento", "TbCancelamento");

                        break;

                    case 12:
                        EntregaAparelhoDal entregaAparelho = new EntregaAparelhoDal();
                        var e = entregaAparelho.read().Where(x => x.Formulario.id_caso == idCaso);
                        if (e.Count() > 0)
                            t = new Tuple<int, string, string>(e.FirstOrDefault().id, "Entrega Aparelho", "TbEntregaAparelho");

                        break;

                    case 13:
                        ProblemaTecnicoDal problemaTecnico = new ProblemaTecnicoDal();
                        var pt = problemaTecnico.read().Where(x => x.Formulario.id_caso == idCaso);
                        if (pt.Count() > 0)
                            t = new Tuple<int, string, string>(pt.FirstOrDefault().id, "Problema Técnico", "TbProblemasTecnicos");

                        break;

                    case 14:
                        ServicoAdicionalDal servicoAdicional = new ServicoAdicionalDal();
                        var s = servicoAdicional.read().Where(x => x.Formulario.id_caso == idCaso);
                        if (s.Count() > 0)
                            t = new Tuple<int, string, string>(s.FirstOrDefault().id, "Servico Adicional", "TbServicoAdicional");

                        break;

                    case 16:
                        RedeCoberturaDal redeCobertura = new RedeCoberturaDal();
                        var r = redeCobertura.read().Where(x => x.Formulario.id_caso == idCaso);
                        if (r.Count() > 0)
                            t = new Tuple<int, string, string>(r.FirstOrDefault().id, "Rede Cobertura", "TbRedeCobertura");

                        break;

                    case 17:
                        OutrosDal outros = new OutrosDal();
                        var o = outros.read().Where(x => x.Formulario.id_caso == idCaso);
                        if (o.Count() > 0)
                            t = new Tuple<int, string, string>(o.FirstOrDefault().id, "Outros", "TbOutros");

                        break;
                }
            }
            return t;        
        }
    }
}
