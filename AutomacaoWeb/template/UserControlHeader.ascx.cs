using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomacaoWeb.template
{
    public partial class UserControlHeader : System.Web.UI.UserControl
    {
        public string cliente
        {
            get { return lblCliente.Text == null ? string.Empty : lblCliente.Text; }
            set { lblCliente.Text = value; }
        }
        public string cpf
        {
            get { return lblCPF.Text == null ? string.Empty : lblCPF.Text; }
            set { lblCPF.Text = value; }
        }
        public string linha
        {
            get { return txtNroLinha.Text == null ? string.Empty : txtNroLinha.Text; }
            set { txtNroLinha.Text = value; }
        }
        public string contrato
        {
            get { return txtNroContrato.Text == null ? string.Empty : txtNroContrato.Text; }
            set { txtNroContrato.Text = value; }
        }
        public string processo
        {
            get { return lblNroProcesso.Text == null ? string.Empty : lblNroProcesso.Text; }
            set { lblNroProcesso.Text = value; }
        }
        public string reclamacao
        {
            get { return lblResumoReclamacao.Text == null ? string.Empty : lblResumoReclamacao.Text; }
            set { lblResumoReclamacao.Text = value; }
        }
        public string reclamacaoCliente
        {
            get { return lblReclamacaoCliente.Text == null ? string.Empty : lblReclamacaoCliente.Text; }
            set { lblReclamacaoCliente.Text = value; }
        }
        public string obs
        {
            get { return lblObs.Text == null ? string.Empty : lblObs.Text; }
            set { lblObs.Text = value; }
        }
        public string escritorio
        {
            get { return lblEscritorio.Text ?? string.Empty; }
            set { lblEscritorio.Text = value; }
        }
        public string dataAudiencia
        {
            get { return lblDtAudiencia.Text ?? string.Empty; }
            set { lblDtAudiencia.Text = value; }
        }
        public string valorRequerido
        {
            get { return lblValorRequerido.Text ?? string.Empty; }
            set { lblValorRequerido.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}