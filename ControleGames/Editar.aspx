<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Criar.aspx.cs" Inherits="ControleGames.Editar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Editar Game</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="Content/font-awesome.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery.mask.min.js"></script>
    <script src="Scripts/jquery.validate.min.js"></script>
    <script src="Scripts/jquery.validate.unobtrusive.min.js"></script>
    <script>
        $(document).ready(function () {
            $('#txtAnoLancamento').mask('0000');
            $('#txtValorVenda').mask('000.000.000,00', { reverse: true });
        });
    </script>
</head>
<body>
    <div class="well">
        <div class="container">
            <h1>
                <i class="fa fa-gamepad"></i>&nbsp;Games <i class="fa fa-angle-right"></i>&nbsp;<small><i class="fa fa-edit"></i>&nbsp;Editar</small>
            </h1>
        </div>
    </div>

    <div class="container">
        <form id="form1" runat="server" class="form-horizontal" role="form">

            <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger" />

            <div class="form-group">
                <label for="txtNome" class="control-label col-md-2">Nome*</label>
                <div class="col-md-6">
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" placeholder="Fifa 16"></asp:TextBox>
                    <asp:CustomValidator ID="valAnoLancamentoCustom0" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="txtNome" Display="Dynamic" CssClass="text-danger" OnServerValidate="valAnoLancamentoCustom0_ServerValidate" ValidateEmptyText="True"></asp:CustomValidator>
                </div>
            </div>
            <div class="form-group">
                <label for="txtAnoLancamento" class="control-label col-md-2">Ano Lançamento*</label>
                <div class="col-md-2">
                    <asp:TextBox ID="txtAnoLancamento" runat="server" CssClass="form-control" placeholder="2015" TextMode="Number"></asp:TextBox>
                    <asp:CustomValidator ID="valAnoLancamentoCustom" runat="server" ErrorMessage="Valor Inválido" ControlToValidate="txtAnoLancamento" Display="Dynamic" CssClass="text-danger" OnServerValidate="valAnoLancamentoCustom_ServerValidate" ValidateEmptyText="True"></asp:CustomValidator>
                </div>
            </div>
            <div class="form-group">
                <label for="txtDistribuidora" class="control-label col-md-2">Distribuidora</label>
                <div class="col-md-6">
                    <asp:TextBox ID="txtDistribuidora" runat="server" CssClass="form-control" placeholder="EA Games"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label for="ddlCategoria" class="control-label col-md-2">Categoria</label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label for="ddlPlataforma" class="control-label col-md-2">Plataforma</label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddlPlataforma" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label for="txtValorVenda" class="control-label col-md-2">Valor Venda*</label>
                <div class="col-md-2">
                    <asp:TextBox ID="txtValorVenda" runat="server" CssClass="form-control" placeholder="0,00"></asp:TextBox>
                    <asp:CustomValidator ID="valValorVendaCustom" runat="server" ErrorMessage="Valor Inválido" ControlToValidate="txtValorVenda" Display="Dynamic" CssClass="text-danger" OnServerValidate="valValorVendaCustom_ServerValidate" ValidateEmptyText="True"></asp:CustomValidator>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <button type="submit" id="btnConfirmar" runat="server" class="btn btn-primary" onserverclick="btnConfirmar_ServerClick"><i class="fa fa-check"></i>&nbsp;Confirmar</button>
                </div>
            </div>
        </form>
        <a href="/">Voltar para Lista</a>
    </div>
</body>
</html>
