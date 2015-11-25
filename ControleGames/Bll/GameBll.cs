using ControleGames.Dal;
using ControleGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleGames.Bll
{
    /// <summary>
    /// Classe responsável pelas lógicas de negócio das Games
    /// </summary>
    public class GameBll
    {
        /// <summary>
        /// Método que cria um Game
        /// </summary>
        /// <param name="game">Game</param>
        public static void Criar(Game game)
        {
            try
            {
                //Validar o Game
                Validar(game);

                //Criar o Game
                GameDal.Criar(game);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método que edita um Game
        /// </summary>
        /// <param name="game">Game</param>
        public static void Editar(Game game)
        {
            try
            {
                //Validar o Game
                Validar(game);

                //Editar o Game
                GameDal.Editar(game);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método que encontra um Game
        /// </summary>
        /// <param name="gameId">Id do Game</param>
        /// <returns>Game</returns>
        public static Game Encontrar(int gameId)
        {
            //Obter o game
            var game = (from x in Listar()
                        where x.GameId == gameId
                        select x).FirstOrDefault();

            //Verificar se o game existe, caso não, lança um excessão
            if (game == null)
                throw new Exception("A Game não existe");

            //Retornar o game
            return game;
        }

        /// <summary>
        /// Método que lista os Games
        /// </summary>
        /// <returns>Lista de Games</returns>
        public static List<Game> Listar()
        {
            try
            {
                //Retornar os games
                return GameDal.Listar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método que remove um Game
        /// </summary>
        /// <param name="game">Game</param>
        public static void Remover(Game game)
        {
            try
            {
                //Remover o game
                GameDal.Remover(game);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método que valida o Game
        /// </summary>
        /// <param name="game">Game</param>
        private static void Validar(Game game)
        {
            //Validar o nome
            if (string.IsNullOrEmpty(game.Nome))
                throw new Exception("O Nome do Game é obrigatório.");

            //Verificar se o Game já existe
            var gameExiste = (from x in Listar()
                              where x.Nome.ToLower().Equals(game.Nome.ToLower()) &&
                              x.Plataforma == game.Plataforma &&
                              x.GameId != game.GameId
                              select x).FirstOrDefault();

            //Verificar se o Game Existe, caso exista, lança um excessão
            if (gameExiste != null)
                throw new Exception("Já existe um Game com este nome para a plataforma informada.");
        }
    }
}