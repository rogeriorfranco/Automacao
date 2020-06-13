using AutomacaoModel;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoDal
{
    public class FormularioDal : GenericCrudDal<Formulario>, IFormularioDal
    {
        public async Task<Formulario> readAsync(int idCaso, int id_tipo_formulario)
        {
            return await readAsync(x => x.id_caso == idCaso && x.tipoFormularioId == id_tipo_formulario);
        }

        public Formulario read(int idCaso, int id_tipo_formulario)
        {
            return read().Where(x => x.id_caso == idCaso && x.tipoFormularioId == id_tipo_formulario).FirstOrDefault();
        }
        public Formulario read(int id_caso)
        {
            return read().Where(x => x.id_caso == id_caso).FirstOrDefault();
        }
        public List<Formulario> list(int idCaso, int id_tipo_formulario)
        {
            return read().Where(x => x.id_caso == idCaso && x.tipoFormularioId == id_tipo_formulario).ToList();
        }

        public DataTable cabecalhoPdf(int idCaso, int id_tipo_formulario)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("select id, cliente, cpf, nro_linha, nro_contrato, nro_processo, resumo_reclamacao, reclamacao_cliente ");
            sql.Append(", observacoes, empresa, produto, escritorio ");
            sql.Append("from TbFormulario ");
            sql.Append("where id_caso=" + idCaso + " ");
            sql.Append("and tipoFormularioId=" + id_tipo_formulario + " ");

            return ConexaoAdo.ExecutaSqlRetorno(sql.ToString());
        }

        public List<Formulario1> apiTeste()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select id, cliente, cpf ");          
            sql.Append("from TbFormulario where id_caso=12312312 ");

            return (from rw in ConexaoAdo.ExecutaSqlRetorno(sql.ToString()).AsEnumerable()
                    select new Formulario1
                    {
                        cliente = rw["cliente"].ToString(),
                        cpf = rw["cpf"].ToString(),
                        id = rw["id"].ToString()
                    }).ToList();

        }

        public void deleteFormulario(int id, string tabela)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("delete from");
            sql.Append(" "+ tabela + " ");
            sql.Append("where id=" + id + " ");

             ConexaoAdo.ExecutaSql(sql.ToString());
        }

        public void save(Formulario f)
        {
            update(f);
        }

        public void update(int id, string nro_linha, string nro_contrato, bool atendido)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("update TbFormulario ");
            sql.Append("set nro_linha='" + nro_linha + "' ");
            sql.Append(",nro_contrato='" + nro_contrato + "' ");

            if (atendido)
                sql.Append(",atendido='true' ");

            sql.Append("where id=" + id + " ");

            ConexaoAdo.ExecutaSql(sql.ToString());
        }

        public DataTable listaFormulario(int idCaso, string cliente, string cpf, string tipo_demanda)
        {

            StringBuilder sql = new StringBuilder();

            sql.Append("select f.id_caso, f.cliente, f.cpf, f.nro_processo, f.nro_linha, f.nro_contrato, f.estado, f.cidade ");
            sql.Append(",(select tf.tipo from TbTipoFormulario tf where tf.id = f.tipoFormularioId) as formulario ");
            sql.Append("from TbFormulario f ");
            sql.Append("where f.atendido = 'true' ");

            if (idCaso != 0)
                sql.Append("and f.id_caso=" + idCaso + " ");

            if (cliente != null)
                sql.Append("and f.cliente like '%" + cliente + "%' ");

            if (cpf != null)
                sql.Append("and f.cpf='" + cpf + "' ");

            if (tipo_demanda != "0")
                sql.Append("and f.tipo_demanda='" + tipo_demanda + "' ");

            sql.Append("order by f.id_caso desc ");

            return ConexaoAdo.ExecutaSqlRetorno(sql.ToString());
        }

        public List<Formulario> list(int idCaso)
        {
            return read().Where(x => x.id_caso == idCaso).ToList();
        }

     
    }

 
}
