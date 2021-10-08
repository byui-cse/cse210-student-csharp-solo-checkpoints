using System;

namespace _05_hide_and_seek
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
        // In the future, we'll make some of these member variables/functions private,
        // but for now, we'll just make everything public, until we discuss it in more detail.
        public bool _keepPlaying;
        public Seeker _seeker;
        public Hider _hider;
        public UserService _userService;

        /// <summary>
        /// Initializes the actors of the game.
        /// </summary>
        public Director()
        {
            _keepPlaying = true;
            _seeker = new Seeker();
            _hider = new Hider();
            _userService = new UserService();
        }

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void StartGame()
        {
            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Get any input needed from the user.
        /// </summary>
        public void GetInputs()
        {
            string message = _seeker.GetMessage();
            _userService.DisplayText(message);

            string prompt = "Enter a location [1-1000]: ";
            int location = _userService.GetNumberChoice(prompt);

            _seeker.Move(location);
        }

        /// <summary>
        /// Update any of the actors.
        /// </summary>
        public void DoUpdates()
        {
            _hider.Watch(_seeker._location);
            
            // Keep playing if the hider is not found (the ! symbol means not)
            _keepPlaying = !_hider.IsFound();

        }

        /// <summary>
        /// Display the updated state of the game to the user.
        /// </summary>
        public void DoOutputs()
        {
            string hint = _hider.GetHint();
            _userService.DisplayText(hint);
        }
    }
}
