using System;

namespace _06_nim
{
    /// <summary>
    /// The director is responsible to direct the game, including to keep track of all
    /// the actors and to control the sequence of play.
    /// 
    /// Stereotype:
    ///     Controller
    /// </summary>
    public class Director
    {
        private Board _board = new Board();
        private UserService _userService = new UserService();
        private Roster _roster = new Roster();

        private Move move = null;
        private bool _keepPlaying = true;

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void StartGame()
        {
            PrepareGame();

            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Performs any initial setup for the game.
        /// </summary>
        private void PrepareGame()
        {
            for (int i = 0; i < 2; i++)
            {
                string prompt = $"Enter a name for player {i + 1}: ";
                string name = _userService.GetStringInput(prompt);

                Player player = new Player(name);
                _roster.AddPlayer(player);
            }
        }

        /// <summary>
        /// Get any input needed from the user.
        /// </summary>
        private void GetInputs()
        {
            // Display the board
            string board = _board.ToString();
            _userService.DisplayText(board);

            // Get next player's move
            Player currentPlayer = _roster.GetCurrentPlayer();
            _userService.DisplayText($"{currentPlayer.GetName()}'s turn:");

            int pile = _userService.GetNumberInput("What pile to remove from? ");
            int stones = _userService.GetNumberInput("How many stones to remove? ");

            // Set the move for the player
            Move move = new Move(stones, pile);
            currentPlayer.SetMove(move);
        }

        /// <summary>
        /// Update any of the actors.
        /// </summary>
        private void DoUpdates()
        {
            Player currentPlayer = _roster.GetCurrentPlayer();
            Move currentMove = currentPlayer.GetMove();

            _board.Apply(currentMove);
        }

        /// <summary>
        /// Display the updated state of the game to the user.
        /// </summary>
        private void DoOutputs()
        {
            if (_board.IsEmpty())
            {
                Player winningPlayer = _roster.GetCurrentPlayer();
                string name = winningPlayer.GetName();

                _userService.DisplayText($"{name} won!");
                _keepPlaying = false;
            }

            _roster.AdvanceNextPlayer();
        }
    }}
