<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlAlertBootstrap.ascx.cs" Inherits="AutomacaoWeb.template.UserControlAlertBootstrap" %>
  
<div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button id="btnClose" type="button" class="close" data-dismiss="modal" onclick="fechar()" aria-hidden="true">&times;</button>
                <h4 class="modal-title" id="myModalLabel">Automação</h4>
            </div>
            <div class="modal-body">
                <h4>
                    <label id="modalId"></label>
                </h4>
            </div>
            <div class="modal-footer">
                <button id="btnOk" type="button" class="btn btn-default" data-dismiss="modal" onclick="fechar()">Ok</button>
            </div>
        </div>
    </div>
</div>