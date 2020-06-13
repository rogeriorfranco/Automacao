using AutomacaoModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoDal
{
    public class ImagemDal : GenericCrudDal<Imagem>, IImagemDal
    {
        public List<ImagemRelatorio> read(int id, int nro_pergunta, int? sub_nro)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, img ");
            sql.Append("from TbImagem ");
            sql.Append("where formularioId=" + id + " ");
            sql.Append("and nro_pergunta=" + nro_pergunta + " ");

            if (sub_nro == null)
                sql.Append("and sub_nro is null ");
            else
                sql.Append("and sub_nro=" + sub_nro + "");

            return (from rw in ConexaoAdo.ExecutaSqlRetorno(sql.ToString()).AsEnumerable()
                    select new ImagemRelatorio
                    {
                        id = Convert.ToInt32(rw["id"]),
                        img = Convert.ToBase64String((Byte[])rw["img"])
                    }).ToList();

        }
        public async Task deleteAsync(int id)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Delete from TbImagem ");
                sql.Append("where id=" + id + " ");

                await ConexaoAdo.ExecutaSqlAsync(sql.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public void delete(int id)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Delete from TbImagem ");
                sql.Append("where id=" + id + " ");

                ConexaoAdo.ExecutaSql(sql.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public void save(Imagem f)
        {
            if (f.id == 0)
                create(f);
            else
                update(f);
        }
        public async Task<DataTable> readDt(int formularioId, int nro_pergunta, int? sub_nro)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select id, imgRedimensionada ");
                sql.Append("from TbImagem ");
                sql.Append("where formularioId=" + formularioId + " ");
                sql.Append("and nro_pergunta=" + nro_pergunta + " ");

                if (sub_nro == null)
                    sql.Append("and sub_nro is null ");
                else
                    sql.Append("and sub_nro=" + sub_nro + "");

                return await ConexaoAdo.ExecutaSqlRetornoAsync(sql.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public async Task copyImage(int[] ids, int nQuestao, int? subQuestao)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select formularioId, img, imgRedimensionada ");
                sql.Append("from TbImagem ");
                sql.Append("where id in (");

      
                for (int x = 0; x < ids.Length; x++)
                {
                    if (x != ids.Length - 1)
                        sql.Append(ids[x] + ", ");
                    else
                        sql.Append(ids[x] + ")");
                }

                await Task.Run(() =>
                {
                    DataTable images = ConexaoAdo.ExecutaSqlRetorno(sql.ToString());
                    foreach (DataRow item in images.Rows)
                    {
                        Imagem i = new Imagem();
                        i.formularioId = Convert.ToInt32(item["formularioId"]);
                        i.img = (byte[])item["img"];
                        i.imgRedimensionada = (byte[])item["imgRedimensionada"];
                        i.nro_pergunta = nQuestao;
                        i.sub_nro = (subQuestao == 0 ? (int?)null : subQuestao);
                        save(i);
                    }
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }


        public byte[] loadImageById(int id)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select id,img from TbImagem where id=" + id + " ");
                return (byte[])ConexaoAdo.ExecutaSqlRetornoRegistro(sql.ToString())["img"];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public List<object> readImages(int formularioId, int nro_pergunta, int? sub_nro)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select id, imgRedimensionada ");
                sql.Append("from TbImagem ");
                sql.Append("where formularioId=" + formularioId + " ");
                sql.Append("and nro_pergunta=" + nro_pergunta + " ");

                if (sub_nro == null)
                    sql.Append("and sub_nro is null ");
                else
                    sql.Append("and sub_nro=" + sub_nro + " ");

                var reult = (from rw in ConexaoAdo.ExecutaSqlRetorno(sql.ToString()).AsEnumerable()
                             select new
                             {
                                 id = rw["id"],
                                 imgRedimensionada = (rw["imgRedimensionada"] != DBNull.Value ? Convert.ToBase64String((Byte[])rw["imgRedimensionada"]) : null)
                             }).ToList();

                return reult.ConvertAll<object>(o => (object)o);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }


    }
}
