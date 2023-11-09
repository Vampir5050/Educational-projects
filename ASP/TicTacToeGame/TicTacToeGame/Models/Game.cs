namespace TicTacToeGame.Models
{
    public class Game
    {
        public string[,] Board { get; set; }

        public Game()
        {
            Board = new string[3, 3];
        }

        public void MakeMove(int row, int col, string player)
        {
            // Реализуйте логику хода здесь
        }

        //public bool CheckWin()
        //{
        //    // Реализуйте логику проверки выигрыша здесь
        //}
    }
}