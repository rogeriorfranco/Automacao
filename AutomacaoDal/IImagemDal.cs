using AutomacaoModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace AutomacaoDal
{
    public interface IImagemDal : IGenericCrudDal<Imagem>
    {
        void save(Imagem f);
        Task deleteAsync(int id);
        void delete(int id);
        List<ImagemRelatorio> read(int id, int nro_pergunta, int? sub_nro);
        Task<DataTable> readDt(int formularioId, int nro_pergunta, int? sub_nro);
        byte[] loadImageById(int id);
        List<object> readImages(int formularioId, int nro_pergunta, int? sub_nro);
        Task copyImage(int[] ids, int nQuestao, int? subQuestao);
    }
}
