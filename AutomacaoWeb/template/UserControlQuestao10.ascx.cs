using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace AutomacaoWeb.template
{
    public partial class UserControlQuestao10 : System.Web.UI.UserControl
    {
        #region Page Load
        protected void Page_Load(object sender, EventArgs ep)
        {
        }


        #endregion Page Load

        public Panel panelPrincipal10
        {
            get
            {
                return pPrincipal10;
            }
            set
            {
                pPrincipal10 = value;
            }
        }

        private void disabilitaCamposReabertura(string status, string tipo)
        {
            if (status.Equals("Incluir Atualização"))
                panelPrincipal10.Visible = true;
            else if ((tipo != null) && tipo.Equals("Subsídio") && status.Equals("Reanálise Má Qualidade"))
                panelPrincipal10.Visible = true;
        }

        /// <summary>
        /// Popula questão 10.
        /// </summary>
        public async Task populaCampos(int FormularioId, string status, string tipo)
        {
            if (status != null)
            {
                disabilitaCamposReabertura(status, tipo);

                Questao10BLL Questao10Bll = new Questao10BLL();
                var q = await Questao10Bll.readAsync(FormularioId);
                if (q != null)
                {
                    ViewState["idQuestao"] = q.id;
                    ddlMotivo.SelectedValue = q.motivo;
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
                    Questao10BLL Questao10BLL = new Questao10BLL();
                    Questao10 q10 = new Questao10();
                    q10.id = Convert.ToInt32(ViewState["idQuestao"]);
                    q10.formularioId = FormularioId;
                    q10.motivo = ddlMotivo.SelectedValue;
                    Questao10BLL.save(q10);
                    ViewState["idQuestao"] = q10.id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }

}