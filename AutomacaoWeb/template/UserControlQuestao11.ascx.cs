using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace AutomacaoWeb.template
{
    public partial class UserControlQuestao11 : System.Web.UI.UserControl
    {
        public int tipoFormulario;
        #region Page Load
        protected void Page_Load(object sender, EventArgs ep)
        {
        }


        #endregion Page Load

        public Panel panelPrincipal11
        {
            get
            {
                return pPrincipal11;
            }
            set
            {
                pPrincipal11 = value;
            }
        }

        private void disabilitaCamposReabertura(string status)
        {
            StatusReaberturaBll srBll = new StatusReaberturaBll();

            if (srBll.listAll().Contains(status))
            {
                pPrincipal11.Visible = true;
            }

            if (this.tipoFormulario == 3 || this.tipoFormulario == 4 || this.tipoFormulario == 5)
                lblNroTitulo.Text = "4";
            else
                lblNroTitulo.Text = "11";

        }

        #region Public  

        public async Task populaCampos(int FormularioId, string status)
        {
            if (status != null)
            {
                disabilitaCamposReabertura(status);

                Questao11BLL questao11Bll = new Questao11BLL();
                var q = await questao11Bll.readAsync(FormularioId);
                if (q != null)
                {
                    ViewState["idQuestao"] = q.id;
                    txtRespostaMaQualidade.Text = q.resposta;
                    ddlClassificacaoMaQualidade.SelectedValue = q.classificacao;
                }
            }
        }
        // <summary>
        // Métoedo para salar questão 11 na tabela TbQuestao11
        // </summary>
        public void Salvar(int FormularioId)
        {
            try
            {
                if (FormularioId > 0)
                {
                    Questao11BLL questao11Bll = new Questao11BLL();
                    Questao11 q11 = new Questao11();
                    q11.id = Convert.ToInt32(ViewState["idQuestao"]);
                    q11.formularioId = FormularioId;
                    q11.classificacao = ddlClassificacaoMaQualidade.SelectedValue == "0" ? null : ddlClassificacaoMaQualidade.SelectedValue;
                    q11.resposta = txtRespostaMaQualidade.Text;
                    questao11Bll.save(q11);
                    ViewState["idQuestao"] = q11.id;
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