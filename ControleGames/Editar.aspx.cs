using ControleGames.Bll;
using ControleGames.Models;
using System;
using System.Web.UI;

namespace ControleGames
{
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Recuperar o id
                var gameId = Convert.ToInt32(Request.QueryString["id"]);

                if (!IsPostBack)
                {
                    //Preencher a Data de Lançamento
                    txtAnoLancamento.Text = DateTime.Today.Year.ToString();

                    //Preencher o Drop Down das Categorias
                    ddlCategoria.DataSource = Enum.GetNames(typeof(Categoria));
                    ddlCategoria.DataBind();

                    //Preencher o Drop Down das Plataformas
                    ddlPlataforma.DataSource = Enum.GetNames(typeof(Plataforma));
                    ddlPlataforma.DataBind();

                    //Encontrar o Game
                    var game = GameBll.Encontrar(gameId);

                    //Preencher o Game
                    txtNome.Text = game.Nome;
                    txtAnoLancamento.Text = game.AnoLancamento.ToString();
                    txtDistribuidora.Text = game.Distribuidora;
                    ddlCategoria.SelectedValue = game.Categoria.ToString();
                    ddlPlataforma.SelectedValue = game.Plataforma.ToString();
                    txtValorVenda.Text = game.ValorVenda.ToString("N2");
                }
            }
            catch (Exception)
            {
                //Redirecionar
                Response.Redirect("/");
            }
        }

        protected void btnConfirmar_ServerClick(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    //Criar a instância do Game
                    var game = new Game
                    {
                        GameId = Convert.ToInt32(Request.QueryString["id"]),
                        Nome = txtNome.Text,
                        AnoLancamento = Convert.ToInt32(txtAnoLancamento.Text),
                        Distribuidora = txtDistribuidora.Text,
                        Categoria = (Categoria)Enum.Parse(typeof(Categoria), ddlCategoria.SelectedValue),
                        Plataforma = (Plataforma)Enum.Parse(typeof(Plataforma), ddlPlataforma.SelectedValue),
                        ValorVenda = Convert.ToDecimal(txtValorVenda.Text)
                    };

                    //Editar o Game
                    GameBll.Editar(game);

                    //Redirecionar
                    Response.Redirect("/");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
        }

        protected void valAnoLancamentoCustom_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            try
            {
                Convert.ToInt32(args.Value);
                args.IsValid = true;
            }
            catch (Exception)
            {
                args.IsValid = false;
            }
        }

        protected void valValorVendaCustom_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            try
            {
                Convert.ToDecimal(args.Value);
                args.IsValid = true;
            }
            catch (Exception)
            {
                args.IsValid = false;
            }
        }

        protected void valAnoLancamentoCustom0_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            if (string.IsNullOrEmpty(args.Value))
                args.IsValid = false;
            else
                args.IsValid = true;
        }
    }
}