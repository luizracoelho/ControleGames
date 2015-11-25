using ControleGames.Bll;
using ControleGames.Models;
using System;
using System.Web.UI.WebControls;

namespace ControleGames
{
    public partial class Games : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = GameBll.Listar();
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var game = (Game)e.Item.DataItem;
                
                ((HyperLink)e.Item.FindControl("hypGameIdDetalhes")).NavigateUrl = $"/Detalhes.aspx?id={game.GameId.ToString()}";
                ((HyperLink)e.Item.FindControl("hypGameIdEditar")).NavigateUrl = $"/Editar.aspx?id={game.GameId.ToString()}";
                ((HyperLink)e.Item.FindControl("hypGameIdRemover")).NavigateUrl = $"/Remover.aspx?id={game.GameId.ToString()}";
                ((Label)e.Item.FindControl("lblNome")).Text = game.Nome;
                ((Label)e.Item.FindControl("lblAnoLancamento")).Text = game.AnoLancamento.ToString();
                ((Label)e.Item.FindControl("lblDistribuidora")).Text = game.Distribuidora;
                ((Label)e.Item.FindControl("lblCategoria")).Text = game.Categoria.ToString();
                ((Label)e.Item.FindControl("lblPlataforma")).Text = game.Plataforma.ToString();
                ((Label)e.Item.FindControl("lblValorVenda")).Text = game.ValorVenda.ToString("C");
            }
        }
    }
}