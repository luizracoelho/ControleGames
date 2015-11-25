using ControleGames.Bll;
using System;

namespace ControleGames
{
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Recuperar o id
                var gameId = Convert.ToInt32(Request.QueryString["id"]);

                if (!IsPostBack)
                {
                    //Encontrar o Game
                    var game = GameBll.Encontrar(gameId);

                    //Preencher o Game
                    hypGameId.NavigateUrl = $"Editar.aspx?id={game.GameId.ToString()}";
                    lblNome.Text = game.Nome;
                    lblAnoLancamento.Text = game.AnoLancamento.ToString();
                    lblDistribuidora.Text = game.Distribuidora;
                    lblCategoria.Text = game.Categoria.ToString();
                    lblPlataforma.Text = game.Plataforma.ToString();
                    lblValorVenda.Text = game.ValorVenda.ToString("C");
                }
            }
            catch (Exception)
            {
                //Redirecionar
                Response.Redirect("/");
            }
        }
    }
}