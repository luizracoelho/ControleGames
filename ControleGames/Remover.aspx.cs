using ControleGames.Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleGames
{
    public partial class Remover : System.Web.UI.Page
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
                    hidGameId.Value = game.GameId.ToString();
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

        protected void btnConfirmar_ServerClick(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    //Encontrar o Game
                    var game = GameBll.Encontrar(Convert.ToInt32(hidGameId.Value));

                    //Editar o Game
                    GameBll.Remover(game);

                    //Redirecionar
                    Response.Redirect("/");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
        }
    }
}