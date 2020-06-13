using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomacaoWeb
{
    public class Util
    {
        public enum TFormulario
        {
            Fraude = 1,
            AcordoPrevio = 2,
            Execucao = 3,
            Liminar = 4,
            Descumprimento = 5,
            Acidente = 6,
            Portabilidade = 7,
            ProblemasComVendas = 8,
            MigracaoIndevida = 9,
            NegativacaoIndevida = 10,
            Cancelamento = 11,
            EntregaAparelho = 12,
            ProblemasTecnicos = 13,
            ServicosAdicionais = 14,
            Subsidio = 15,
            RedeCobertura = 16,
            Outros = 17
        }

        public static void Alertbootsrap(string msg, Page page, UpdatePanel up)
        {
            try
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.AppendLine("$(document).ready(function() {");
                sb.AppendLine("$('.modal-body #modalId').html('" + msg.Replace("'", "") + "') ");
                sb.AppendLine("$('#myModal').modal('show');");
                sb.AppendLine(" });");
                UserControl uc = (UserControl)page.LoadControl("~/template/UserControlAlertBootstrap.ascx");
                up.ContentTemplateContainer.Controls.Add(uc);
                ScriptManager.RegisterClientScriptBlock(page, typeof(Page), Guid.NewGuid().ToString(), sb.ToString(), true);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static void CarregaControle(Control controle, Object objeto,
                                           bool carregaPrimeiroRegistro = true,
                                           string textField = "Nome", string valueField = "id",
                                           string textoSelecionar = "<< Selecionar >>",
                                           bool naoCarregarValor = false)
        {
            DropDownList DropList = new DropDownList();
            Type t = controle.GetType();

            if (t.Equals(typeof(DropDownList)))
            {
                DropDownList ddl = (DropDownList)controle;
                ddl.DataSource = objeto;
                ddl.DataTextField = textField;
                ddl.DataValueField = valueField;
                ddl.DataBind();
                if (textoSelecionar != "")
                {
                    ListItem ddlItem = new ListItem(textoSelecionar, 0.ToString());
                    ddl.Items.Insert(0, ddlItem);
                    if (naoCarregarValor == false)
                    {
                        if (!carregaPrimeiroRegistro)
                            ddl.SelectedIndex = 0;
                        else
                            ddl.SelectedIndex = 1;
                    }
                }
            }
            else if (t.Equals(typeof(ListBox)))
            {
                ListBox lb = (ListBox)controle;
                lb.DataSource = objeto;
                lb.DataSource = objeto;
                lb.DataTextField = textField;
                lb.DataValueField = valueField;
                lb.DataBind();
                if (textoSelecionar != "")
                {
                    ListItem ddlItem = new ListItem(textoSelecionar, 0.ToString());
                    lb.Items.Insert(0, ddlItem);
                    if (naoCarregarValor == false)
                    {
                        if (!carregaPrimeiroRegistro)
                            lb.SelectedIndex = 0;
                        else
                            lb.SelectedIndex = 1;
                    }
                }
            }
            else if (t.Equals(typeof(DataGrid)))
            {
                DataGrid grid = (DataGrid)controle;
                grid.DataSource = objeto;

            }
        }

        public static void LimpaControles(ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
                else if (ctrl is DropDownList)
                {
                    if (((DropDownList)(ctrl)).Items.Count > 0)
                        ((DropDownList)(ctrl)).SelectedIndex = -1;
                    //((DropDownList)(ctrl)).Items.FindByValue(0.ToString()).Selected = true;
                }
                else if (ctrl is CheckBox)
                {
                    ((CheckBox)(ctrl)).Checked = false;
                }
                else if (ctrl is RadioButton)
                {
                    ((RadioButton)(ctrl)).Checked = false;
                }
                //else if (ctrl is ListBox)
                //{
                //    ((ListBox)(ctrl)).DataSource = null;
                //}
                else if (ctrl is DataGrid)
                {
                    ((DataGrid)(ctrl)).DataSource = null;
                }

                if (ctrl.HasControls())
                    LimpaControles(ctrl.Controls);
            }
        }

        public static bool ISDate(String date)
        {
            try
            {
                DateTime dt = DateTime.Parse(date);
                return true;
            }
            catch
            {
                return false;

            }
        }

        public static bool IsNum(System.Object Expression)
        {
            if (Expression == null || Expression is DateTime)
                return false;

            if (Expression is Int16 || Expression is Int32 || Expression is Int64 || Expression is Decimal || Expression is Single || Expression is Double || Expression is Boolean)
                return true;

            try
            {
                if (Expression is string)
                    Double.Parse(Expression as string);
                else
                    Double.Parse(Expression.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }


        private static TripleDESCryptoServiceProvider TripleDES = new TripleDESCryptoServiceProvider();
        private static MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
        /// <summary>
        /// Gera md5
        /// </summary>
        /// <param name="value">chave</param>
        /// <returns></returns>
        public static byte[] MD5Hash()
        {
            try
            {
                byte[] byteArray = ASCIIEncoding.ASCII.GetBytes("");
                return MD5.ComputeHash(byteArray);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        /// <summary>
        /// Metodo que encriptografa uma string
        /// </summary>
        /// <param name="stringToEncrypt">texto a ser encriptografado</param>
        /// <returns></returns>
        public static string Encrypt(string stringToEncrypt)
        {
            try
            {
                TripleDES.Key = MD5Hash();
                TripleDES.Mode = CipherMode.ECB;
                byte[] Buffer = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt);
                return Convert.ToBase64String(TripleDES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        /// <summary>
        /// Metodo que descriptografa uma string
        /// </summary>
        /// <param name="encryptedString">a string a ser desencriptografada</param>
        /// <returns></returns>
        public static string Decrypt(string encryptedString)
        {
            try
            {
                TripleDES.Key = MD5Hash();
                TripleDES.Mode = CipherMode.ECB;
                byte[] Buffer = Convert.FromBase64String(encryptedString.Replace(" ", "+"));
                return ASCIIEncoding.ASCII.GetString(TripleDES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}