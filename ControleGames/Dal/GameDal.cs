using ControleGames.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ControleGames.Dal
{
    /// <summary>
    /// Classe responsável pelo CRUD dos Games no Banco de Dados
    /// </summary>
    public class GameDal
    {
        /// <summary>
        /// Método que cria um Game no banco de dados
        /// </summary>
        /// <param name="Game">Game</param>
        public static void Criar(Game Game)
        {
            try
            {
                using (var ctx = new DataContext())
                {
                    //Adicionar o Game
                    ctx.Games.Add(Game);

                    //Salvar as alterações
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método que edita um Game no banco de dados
        /// </summary>
        /// <param name="Game">Game</param>
        public static void Editar(Game Game)
        {
            try
            {
                using (var ctx = new DataContext())
                {
                    //Anexar a Game
                    ctx.Games.Attach(Game);

                    //Marcar o Game como alterada
                    ctx.Entry(Game).State = EntityState.Modified;

                    //Salvar as alterações
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método que lista os Games do banco de dados
        /// </summary>
        /// <returns>Lista de Games</returns>
        public static List<Game> Listar()
        {
            try
            {
                using (var ctx = new DataContext())
                {
                    //Obter os Game por ordem de nome
                    var Games = (from x in ctx.Games
                                 orderby x.Nome
                                 select x).ToList();

                    //Retornar a lista de Games
                    return Games;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método que remove um Game no banco de dados
        /// </summary>
        /// <param name="Game">Game</param>
        public static void Remover(Game Game)
        {
            try
            {
                using (var ctx = new DataContext())
                {
                    //Anexar o Game
                    ctx.Games.Attach(Game);

                    //Marcar o Game como alterada
                    ctx.Games.Remove(Game);

                    //Salvar as alterações
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
