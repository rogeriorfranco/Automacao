using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace AutomacaoWeb.template
{
    public partial class UserControlQuestao13 : System.Web.UI.UserControl
    {
        #region Page Load
        protected void Page_Load(object sender, EventArgs ep)
        {
        }


        #endregion Page Load

        public Panel panelPrincipal13
        {
            get
            {
                return pPrincipal13;
            }
            set
            {
                pPrincipal13 = value;
            }
        }

        private void disabilitaCamposReabertura(string status)
        {
            if (status.Equals("Incluir Atualização"))
                pPrincipal13.Visible = true;
        }

        /// <summary>
        /// Popula questão 13.
        /// </summary>
        public async Task populaCampos(int FormularioId, string status)
        {
            if (status != null)
            {
                disabilitaCamposReabertura(status);

                Questao13BLL questao13Bll = new Questao13BLL();
                var q = await questao13Bll.readAsync(FormularioId);
                if (q != null)
                {
                    ViewState["idQuestao"] = q.id;
                    txtDescricaoReanalise.Text = q.detalhamento;
                }
            }
        }
        /// <summary>
        /// Métoedo para salar questão 3 na tabela TbQuestao3.
        /// </summary>
        public void Salvar(int FormularioId)
        {
            try
            {
                if (FormularioId > 0)
                {
                    Questao13BLL questao13BLL = new Questao13BLL();
                    Questao13 q13 = new Questao13();
                    q13.id = Convert.ToInt32(ViewState["idQuestao"]);
                    q13.formularioId = FormularioId;
                    q13.detalhamento = txtDescricaoReanalise.Text;
                    questao13BLL.save(q13);
                    ViewState["idQuestao"] = q13.id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }

}