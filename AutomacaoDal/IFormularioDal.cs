using AutomacaoModel;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace AutomacaoDal
{
    public interface IFormularioDal : IGenericCrudDal<Formulario>
    {
        Formulario read(int id_caso);
        Task<Formulario> readAsync(int idCaso, int id_tipo_formulario);
        Formulario read(int idCaso, int id_tipo_formulario);
        List<Formulario> list(int idCaso, int id_tipo_formulario);
        List<Formulario> list(int idCaso);
        DataTable listaFormulario(int idCaso, string cliente, string cpf, string tipo_demanda);
        DataTable cabecalhoPdf(int idCaso, int id_tipo_formulario);
        void update(int id, string nro_linha, string nro_contrato, bool atendido);
        void save(Formulario f);
        void deleteFormulario(int id, string tabela);
        List<Formulario1> apiTeste();
    }
}
