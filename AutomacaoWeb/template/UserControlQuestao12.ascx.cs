using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomacaoWeb.template
{
    public partial class UserControlQuestao12 : System.Web.UI.UserControl
    {
        #region Page Load
        protected void Page_Load(object sender, EventArgs ep)
        {
        }


        #endregion Page Load

        public Panel panelPrincipal12
        {
            get
            {
                return pPrincipal12;
            }
            set
            {
                pPrincipal12 = value;
            }
        }

        private void disabilitaCamposReabertura(string status)
        {
            //StatusReaberturaBll srBll = new StatusReaberturaBll();
            //if (srBll.listAll().Contains(status))
            if (status.Equals("Reanálise Má Qualidade"))
                pPrincipal12.Visible = true;
        }

        /// <summary>
        /// Popula questão 12.
        /// </summary>
        public async Task populaCampos(int FormularioId, string status)
        {
            if (status != null)
            {
                disabilitaCamposReabertura(status);

                Questao12BLL questao12Bll = new Questao12BLL();
                var q = await questao12Bll.readAsync(FormularioId);
                if (q != null)
                {
                    ViewState["idQuestao"] = q.id;
                    txtDescricaoReanalise.Text = q.reanalise;
                    txtDescricaoSupervisor.Text = q.descricao;
                    ddlClassificacaoMaQualidade.SelectedValue = q.classificacao;
                }
            }
        }
        // <summary>
        // Métoedo para salar questão 12 na tabela TbQuestao12.
        // </summary>
        public void Salvar(int FormularioId)
        {
            try
            {
                if (FormularioId > 0)
                {
                    Questao12BLL questao12BLL = new Questao12BLL();
                    Questao12 q12 = new Questao12();
                    q12.id = Convert.ToInt32(ViewState["idQuestao"]);
                    q12.formularioId = FormularioId;
                    q12.reanalise = txtDescricaoReanalise.Text;
                    q12.descricao = txtDescricaoSupervisor.Text;
                    q12.classificacao = ddlClassificacaoMaQualidade.SelectedValue;
                    questao12BLL.save(q12);
                    ViewState["idQuestao"] = q12.id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

    }

}