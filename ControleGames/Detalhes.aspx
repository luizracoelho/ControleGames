<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="ControleGames.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detalhes do Game</title>
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
                <i class="fa fa-gamepad"></i>&nbsp;Games <i class="fa fa-angle-right"></i>&nbsp;<small><i class="fa fa-search"></i>&nbsp;Detalhes</small>
            </h1>
        </div>  
    </div>

    <div class="container">
        <dl class="dl-horizontal">
            <dt>
                <strong>Nome</strong>
            </dt>

            <dd>
                <asp:Label ID="lblNome" runat="server" Text=""></asp:Label>
            </dd>

            <dt>
                <strong>Ano Lançamento</strong>
            </dt>

            <dd>
                <asp:Label ID="lblAnoLancamento" runat="server" Text=""></asp:Label>
            </dd>

            <dt>
                <strong>Distribuidora</strong>
            </dt>

            <dd>
                <asp:Label ID="lblDistribuidora" runat="server" Text=""></asp:Label>
            </dd>

            <dt>
                <strong>Categoria</strong>
            </dt>

            <dd>
                <asp:Label ID="lblCategoria" runat="server" Text=""></asp:Label>
            </dd>

            <dt>
                <strong>Plataforma</strong>
            </dt>

            <dd>
                <asp:Label ID="lblPlataforma" runat="server" Text=""></asp:Label>
            </dd>

            <dt>
                <strong>Valor Venda</strong>
            </dt>

            <dd>
                <asp:Label ID="lblValorVenda" runat="server" Text=""></asp:Label>
            </dd>
        </dl>
        <p>
            <asp:HyperLink ID="hypGameId" runat="server">Editar</asp:HyperLink>
            | <a href="/">Voltar para Lista</a>
        </p>
    </div>
</body>
</html>
