namespace Application.Model
{
    public class TicTacToe
    {
        public bool IsGameOver { get; private set; }

        public bool IsDraw { get; private set; }

        public Client Player1 { get; set; }

        public Client Player2 { get; set; }

        private int _gameBoard { get; set; }

        private readonly int[] _field;

        private int _movesLeft;

        public TicTacToe(int gameBoard = 3) //default board size is 3
        {
            _gameBoard = gameBoard;
            _field = new int[_gameBoard * _gameBoard];
            _movesLeft = _gameBoard * _gameBoard;

            // Reset game
            for (var i = 0; i < _field.Length; i++)
            {
                _field[i] = -1;
            }
        }

        /// <summary>
        /// Insert a marker at a given position for a given player
        /// </summary>
        /// <param name="player">The player number should be 0 or 1</param>
        /// <param name="position">The position where to place the marker, should be between 0 and 9</param>
        /// <returns>True if a winner was found</returns>
        public bool Play(int player, int position)
        {
            if (IsGameOver)
                return false;

            PlaceMarker(player, position);

            return CheckWinner();
        }

        /// <summary>
        /// Checks each different combination of marker placements and looks for a winner
        /// Each position is marked with an initial -1 which means no marker has yet been placed
        /// </summary>
        /// <returns>True if there is a winner</returns>
        private bool CheckWinner()
        {
            for (int i = 0; i < _gameBoard * _gameBoard; i += _gameBoard) //for checking rows
            {
                int matchCount = 0;
                for (int j = i; j < i + _gameBoard; j++)
                {
                    if (_field[i] == _field[j] && _field[i] != -1 && _field[j] != -1)
                        matchCount++;
                }
                if (matchCount == _gameBoard)
                {
                    IsGameOver = true;
                    return true;
                }
            }

            for (int i = 0; i < _gameBoard; i++) //for checking columns
            {
                int matchCount = 0;
                for (int j = i; j < _gameBoard * _gameBoard; j += _gameBoard)
                {
                    if (_field[i] == _field[j] && _field[i] != -1 && _field[j] != -1)
                        matchCount++;
                }
                if (matchCount == _gameBoard)
                {
                    IsGameOver = true;
                    return true;
                }
            }

            do //for checking 1st diagonal
            {
                int count = 0, i = 0;
                for (int j = i; j < _gameBoard * _gameBoard; j = j + _gameBoard + 1)
                {
                    if (_field[i] == _field[j] && _field[i] != -1 && _field[j] != -1)
                    {
                        count++;
                    }
                }

                if (count == _gameBoard)
                {
                    IsGameOver = true;
                    return true;
                }

            } while (false);  //don't need to go in second time

            do //for checking 2nd diagonal
            {
                int count = 0, i = _gameBoard - 1;
                for (int j = i; j < _gameBoard * _gameBoard; j += _gameBoard - 1)
                {
                    if (_field[i] == _field[j] && _field[i] != -1 && _field[j] != -1)
                    {
                        count++;
                    }
                }

                if (count == _gameBoard)
                {
                    IsGameOver = true;
                    return true;
                }

            } while (false); //don't need to go in second time

            return false;
        }

        /// <summary>
        /// Places a marker at the given position for the given player as long as the position is marked as -1
        /// </summary>
        /// <param name="player">The player number should be 0 or 1</param>
        /// <param name="position">The position where to place the marker, should be between 0 and 9</param>
        /// <returns>True if the marker position was not already taken</returns>
        private bool PlaceMarker(int player, int position)
        {
            _movesLeft -= 1;

            if (_movesLeft <= 0)
            {
                IsGameOver = true;
                IsDraw = true;
                return false;
            }

            if (position > _field.Length)
                return false;
            if (_field[position] != -1)
                return false;

            _field[position] = player;

            return true;
        }
    }
}
