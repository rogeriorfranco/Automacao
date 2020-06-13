using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace AutomacaoWeb.template
{
    public partial class UserControlOcorrenciaNet : System.Web.UI.UserControl
    {
        public int tipoFormulario;
        #region Page Load
        protected void Page_Load(object sender, EventArgs ep)
        {
        }


        #endregion Page Load




        #region Public  

        public async Task populaCampos(int FormularioId)
        {
            QuestaoNetBll questaonetBll = new QuestaoNetBll();
            var q = await questaonetBll.readAsync(FormularioId);
            if (q != null)
            {
                ViewState["idQuestao"] = q.id;
                txtDescricao.Text = q.resposta;
            }
        }
        // <summary>
        // Métoedo para salar questão 11 na tabela TbQuestao11
        // </summary>
        public void Salvar(int FormularioId)
        {
            try
            {
                if (FormularioId > 0 && !string.IsNullOrEmpty(txtDescricao.Text))
                {
                    QuestaoNetBll questaonetBll = new QuestaoNetBll();
                    QuestaoNet qnet = new QuestaoNet();
                    qnet.id = Convert.ToInt32(ViewState["idQuestao"]);
                    qnet.formularioId = FormularioId;
                    qnet.resposta = txtDescricao.Text;
                    questaonetBll.save(qnet);
                    ViewState["idQuestao"] = qnet.id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        #endregion Public      

    }

}