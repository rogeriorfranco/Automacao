using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomacaoWeb.template
{
    public partial class UserControlExecQuestao3 : System.Web.UI.UserControl
    {
        public int tipoFormulario = 0;

        #region Properties
        Pendente pendente = new Pendente();
        PendenteBLL pendenteBLL = new PendenteBLL();
        ResponsavelDescumprimento respdescumprimento = new ResponsavelDescumprimento();
        ResponsavelDescumprimentoBLL respDescumprimentoBLL = new ResponsavelDescumprimentoBLL();
        UserControlExecQuestao1 questao1 = new UserControlExecQuestao1();
        Questao3BLL questao3BLL = new Questao3BLL();
        Questao3 questao3 = new Questao3();

        private string _detalheExecCumprimento;
        public string DetalheExecCumprimento
        {
            get
            {
                return this._detalheExecCumprimento;
            }
            set
            {
                this._detalheExecCumprimento = value;
                txtdetalheExec.Text = value != null ? value.ToString() : String.Empty;
            }
        }

        private string _respDescumprimento;
        public string RespDescumprimento
        {
            get
            {
                return this._respDescumprimento;
            }
            set
            {
                this._respDescumprimento = value;
                if (value != null)
                    drprespDescumprimento.SelectedValue = respDescumprimentoBLL.read(_respDescumprimento);
                else
                    drprespDescumprimento.Items.FindByValue(0.ToString()).Selected = true;
            }
        }

        private string _pendenteCom;
        public string PendenteCom
        {
            get
            {
                return this._pendenteCom;
            }
            set
            {
                this._pendenteCom = value;
            }
        }

        #endregion Properties

        #region Page Load
        protected void Page_Load(object sender, EventArgs ep)
        {
        }

        private void desabilitaValidador()
        {
            if (this.tipoFormulario == Convert.ToInt16(Util.TFormulario.Execucao) ||
                   this.tipoFormulario == Convert.ToInt16(Util.TFormulario.Liminar))
            {
                rfDet.Enabled = true;
            }
            else if (this.tipoFormulario == Convert.ToInt16(Util.TFormulario.Descumprimento))
            {
                rfDet.Enabled = true;
                rfRespDesc.Enabled = true;
            }
            else
            {
                rfDet.Enabled = false;
                rfRespDesc.Enabled = false;
            }
        }

        #endregion Page Load



        #region Public  
        /// <summary>
        /// Popula questão 3.
        /// </summary>
        public async Task PopulaQuestao3(Formulario form)
        {
            await PopulaQuestion3();
            desabilitaValidador();
            questao3 = await questao3BLL.readAsync(form.id);
            if (form.tipoFormularioId == (int)Util.TFormulario.Execucao || form.tipoFormularioId == (int)Util.TFormulario.Liminar || form.tipoFormularioId == (int)Util.TFormulario.Descumprimento)
            {
                respDescID.Visible = false;
                if (questao3 != null)
                {
                    ViewState["idQuestao"] = questao3.id;
                    DetalheExecCumprimento = questao3.detalheExecCumprimento;
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "pendente3", "preenchePendente_3();", true);
                }
            }
            else
            {
                respDescID.Visible = true;
                if (questao3 != null)
                {
                    ViewState["idQuestao"] = questao3.id;
                    DetalheExecCumprimento = questao3.detalheExecCumprimento;
                    RespDescumprimento = questao3.respDescumprimento;
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "pendente3", "preenchePendente_3();", true);
                }
            }
        }

        /// <summary>
        /// Métoedo para salar questão 3 na tabela TbQuestao3.
        /// </summary>
        public bool SaveQuestao3(int FormularioId)
        {
            try
            {
                if (FormularioId > 0)
                {
                    Questao3BLL questao3BLL = new Questao3BLL();
                    Questao3 quest3 = new Questao3();
                    quest3.id = Convert.ToInt32(ViewState["idQuestao"]);
                    quest3.formularioId = FormularioId;
                    quest3.detalheExecCumprimento = txtdetalheExec.Text;

                    if (drprespDescumprimento.SelectedValue != "0")
                        quest3.respDescumprimento = drprespDescumprimento.SelectedItem.Text;
                    else
                        quest3.respDescumprimento = null;

                    quest3.pendenteComValue = "";
                    quest3.pendenteCom = "";
                    foreach (ListItem item in pendenteID.Items)
                    {
                        if (item.Selected)
                        {
                            quest3.pendenteCom += item.Text + ",";
                            quest3.pendenteComValue += item.Value + ",";
                        }
                    }

                    if (quest3.pendenteCom.EndsWith(","))
                        quest3.pendenteCom = quest3.pendenteCom.Remove(quest3.pendenteCom.Length - 1, 1);

                    if (quest3.pendenteComValue.EndsWith(","))
                        quest3.pendenteComValue = quest3.pendenteComValue.Remove(quest3.pendenteComValue.Length - 1, 1);

                    questao3BLL.save(quest3);
                    ViewState["idQuestao"] = quest3.id;
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        /// <summary>
        /// Método para popular dropdowlist Pendente.
        /// </summary>
        /// <param name="listPendente"></param>
        public void PopularDropDownPendente(List<Pendente> listPendente)
        {
            pendenteID.DataSource = listPendente;
            pendenteID.DataValueField = "ID";
            pendenteID.DataTextField = "nome";
            pendenteID.DataBind();
        }

        /// <summary>
        /// Método para popular dropdownlist Responsável pelo Descumprimento.
        /// </summary>
        /// <param name="listRespDescumprimento"></param>
        public void PopularDropDownRespDescumprimento(List<ResponsavelDescumprimento> listRespDescumprimento)
        {
            drprespDescumprimento.DataSource = listRespDescumprimento;
            drprespDescumprimento.DataValueField = "ID";
            drprespDescumprimento.DataTextField = "nome";
            drprespDescumprimento.DataBind();
            drprespDescumprimento.Items.Insert(0, new ListItem("<< Selecione >>", "0"));
        }

        /// <summary>
        /// Método responsável por popular todas as questões.
        /// </summary>
        public async Task PopulaQuestion3()
        {
            PopularDropDownPendente(await pendenteBLL.listAsyncAll());

            PopularDropDownRespDescumprimento(await respDescumprimentoBLL.listAsyncAll());
        }
        #endregion Public      

    }

}