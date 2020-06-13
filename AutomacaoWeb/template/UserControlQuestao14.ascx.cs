using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomacaoWeb.template
{
    public partial class UserControlQuestao14 : System.Web.UI.UserControl
    {
        #region Page Load
        protected void Page_Load(object sender, EventArgs ep)
        {
        }


        #endregion Page Load

        public Panel panelPrincipal14
        {
            get
            {
                return pPrincipal14;
            }
            set
            {
                pPrincipal14 = value;
            }
        }

        private void disabilitaCamposReabertura(string status)
        {
            if (status.Equals("Incluir Atualização"))
                pPrincipal14.Visible = true;
        }

        /// <summary>
        /// Popula questão 14.
        /// </summary>
        public async Task populaCampos(int FormularioId, string status)
        {
            if (status != null)
            {
                disabilitaCamposReabertura(status);

                Questao14BLL questao14Bll = new Questao14BLL();
                var q = await questao14Bll.readAsync(FormularioId);
                if (q != null)
                {
                    ViewState["idQuestao"] = q.id;
                    txtDescricaoReanalise.Text = q.resposta;
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
                    Questao14BLL questao14BLL = new Questao14BLL();
                    Questao14 q14 = new Questao14();
                    q14.id = Convert.ToInt32(ViewState["idQuestao"]);
                    q14.formularioId = FormularioId;
                    q14.resposta = txtDescricaoReanalise.Text;
                    questao14BLL.save(q14);
                    ViewState["idQuestao"] = q14.id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }

}