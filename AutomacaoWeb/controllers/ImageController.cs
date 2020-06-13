using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace AutomacaoWeb.controllers
{
    public class ImageController : ApiController
    {
        [Route("readImages/{formularioId}/{nro_pergunta}/{sub_nro}")]
        public List<object> Get(int formularioId, int nro_pergunta, int? sub_nro)
        {
            ImagemBll imagemBll = new ImagemBll();
            return imagemBll.readImages(formularioId, nro_pergunta, (sub_nro == 0 ? (int?)null : sub_nro));
        }

        [Route("testeApi")]
        public List<Formulario1> Get()
        {
            FormularioBll frmBll = new FormularioBll();
            return frmBll.apiTeste();
        }


        [Route("loadImage/{imgId}")]
        public string Get(int imgId)
        {
            ImagemBll imagemBll = new ImagemBll();
            return Convert.ToBase64String(imagemBll.loadImageById(imgId));
        }

        [Route("saveImage")]
        public void Post([FromBody]ImagemRequest imRequest)
        {
            ImagemBll imagemBll = new ImagemBll();
            Imagem imagem = new Imagem();

            byte[] bytes = Convert.FromBase64String(imRequest.img);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            Bitmap b = new Bitmap(120, 120);
            Graphics g = Graphics.FromImage(b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(image, 0, 0, 120, 120);
            g.Dispose();
            image = b;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                imagem.img = Convert.FromBase64String(imRequest.img);
                imagem.imgRedimensionada = ms.ToArray();
                imagem.nro_pergunta = imRequest.nro_pergunta;
                imagem.formularioId = imRequest.formularioId;
                imagem.sub_nro = (imRequest.sub_nro == 0 ? (int?)null : imRequest.sub_nro);
                imagemBll.save(imagem);
            }
        }

        [Route("copyImage")]
        public async Task Post([FromBody]copyImageRequest ids)
        {
            ImagemBll imagemBll = new ImagemBll();
            await imagemBll.copyImage(ids.ids, Convert.ToInt32(ids.nQuestao), Convert.ToInt32(ids.subQuestao));
        }

        [Route("delete/{imgId}")]
        public void Post(int imgId)
        {
            ImagemBll imagemBll = new ImagemBll();
            imagemBll.delete(imgId);
        }

        [Route("listaPendente/{id_caso}/{questao}")]
        public string[] Get(int id_caso, int questao)
        {
            string[] pendente = null;
            string ret;
            if (questao == 7)
            {
                Questao7Bll q = new Questao7Bll();
                ret = q.readPendente(id_caso);
                if (!String.IsNullOrEmpty(ret))
                    pendente = ret.Split(',');

                return pendente;

            }
            else if (questao == 3)
            {
                Questao3BLL q = new Questao3BLL();
                ret = q.readPendente(id_caso);
                if (!String.IsNullOrEmpty(ret))
                    pendente = ret.Split(',');

                return pendente;
            }

            return null;
        }
    }
}