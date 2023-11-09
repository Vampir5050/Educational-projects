using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TicTacToeGame.Models;

namespace TicTacToeGame.Controllers
{
    public class HomeController : Controller
    {
        private Game _game = new Game();

        public IActionResult Index()
        {
            return View(_game);
        }

        public IActionResult MakeMove(int row, int col)
        {
            _game.MakeMove(row, col, "X"); // Предположим, что всегда ходит первый игрок
            return View("Index", _game);
        }

        //private bool CheckWin()
        //{
        //    // Check rows and columns
        //    for (int i = 0; i < 3; i++)
        //    {
        //        if (_game.Board[i][0] == _game.Board[i][1] && _game.Board[i][1] == _game.Board[i][2] && _game.Board[i][0] != ' ')
        //            return true;
        //        if (_game.Board[0][i] == _game.Board[1][i] && _game.Board[1][i] == _game.Board[2][i] && _game.Board[0][i] != ' ')
        //            return true;
        //    }

        //    // Check diagonals
        //    if (_game.Board[0][0] == _game.Board[1][1] && _game.Board[1][1] == _game.Board[2][2] && _game.Board[0][0] != ' ')
        //        return true;
        //    if (_game.Board[0][2] == _game.Board[1][1] && _game.Board[1][1] == _game.Board[2][0] && _game.Board[0][2] != ' ')
        //        return true;

        //    return false;
        //}

        //private bool CheckForDraw()
        //{
        //    char[,] board = game.Board;

        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            if (board[i, j] == 0) // Проверка на наличие пустых клеток
        //            {
        //                return false;
        //            }
        //        }
        //    }

        //    return true;
        //}


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}