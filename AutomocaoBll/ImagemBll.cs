using AutomacaoDal;
using AutomacaoModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class ImagemBll
    {
        IImagemDal imagemBll = new ImagemDal();
        public List<ImagemRelatorio> read(int id, int nro_pergunta, int? sub_nro)
        {
            return imagemBll.read(id, nro_pergunta, sub_nro);
        }

        public async Task<DataTable> readDt(int formularioId, int nro_pergunta, int? sub_nro)
        {
            return await imagemBll.readDt(formularioId, nro_pergunta, sub_nro);
        }
        public async Task deleteAsync(int id)
        {
            await imagemBll.deleteAsync(id);
        }
        public void delete(int id)
        {
            imagemBll.delete(id);
        }

        public byte[] loadImageById(int id)
        {
            return imagemBll.loadImageById(id);
        }
        public void save(Imagem f)
        {
            imagemBll.save(f);
        }
        public List<object> readImages(int formularioId, int nro_pergunta, int? sub_nro)
        {
            return imagemBll.readImages(formularioId, nro_pergunta, sub_nro);
        }

        public async Task copyImage(int[] ids, int nQuestao, int? subQuestao)
        {
            await imagemBll.copyImage(ids, nQuestao, subQuestao);
        }
    }
}
