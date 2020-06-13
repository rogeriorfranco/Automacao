<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlUpdateProgress.ascx.cs" Inherits="AutomacaoWeb.template.UserControlUpdateProgress" %>
<asp:UpdateProgress ID="updateProgress" runat="server" DisplayAfter="1000">
    <ProgressTemplate>
        <div class="progressBackgroundModal">
            <img alt="Loading" src="../images/loading.gif" class="center" />
        </div>
    </ProgressTemplate>
</asp:UpdateProgress>
