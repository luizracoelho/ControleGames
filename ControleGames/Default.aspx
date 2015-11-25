<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControleGames.Games" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Games</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="Content/font-awesome.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery.mask.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="well">
            <div class="container">
                <h1>
                    <i class="fa fa-gamepad"></i>&nbsp;Controle de Games
                </h1>
            </div>
        </div>
        <div class="container">

            <p>
                <a href="Criar.aspx"><i class="fa fa-plus"></i>&nbsp;Criar Novo</a>
            </p>

            <div class="panel panel-default">
                <div class="panel-body">
                    <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
                        <HeaderTemplate>
                            <table class="table table-responsive table-hover">
                                <caption>Listagem de Games</caption>
                                <thead>
                                    <tr>
                                        <th>Nome</th>
                                        <th>Ano Lançamento</th>
                                        <th>Distribuidora</th>
                                        <th>Categoria</th>
                                        <th>Plataforma</th>
                                        <th>Valor Venda</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <asp:Label ID="lblNome" runat="server" Text=""></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblAnoLancamento" runat="server" Text=""></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblDistribuidora" runat="server" Text=""></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblCategoria" runat="server" Text=""></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblPlataforma" runat="server" Text=""></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblValorVenda" runat="server" Text=""></asp:Label>
                                </td>
                                <td>
                                    <asp:HyperLink ID="hypGameIdDetalhes" runat="server"><i class="fa fa-search"></i>&nbsp;Detalhes</asp:HyperLink>
                                    | 
                                    <asp:HyperLink ID="hypGameIdEditar" runat="server"><i class="fa fa-edit"></i>&nbsp;Editar</asp:HyperLink>
                                    | 
                                    <asp:HyperLink ID="hypGameIdRemover" runat="server"><i class="fa fa-remove"></i>&nbsp;Remover</asp:HyperLink>
                                </td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </tbody>
                    </table>
                        </FooterTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
