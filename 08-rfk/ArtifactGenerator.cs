using System;
using System.Collections.Generic;
using System.IO;
using _08_rfk.Casting;

namespace _08_rfk
{
    /// <summary>
    /// This class is used to generate new artifacts, pulling their
    /// messages from the message file.
    /// </summary>
    public class ArtifactGenerator
    {
        private List<string> _messages;
        private Random _randomGenerator = new Random();

        public ArtifactGenerator()
        {
            LoadMessages();
        }

        /// <summary>
        /// Loads messages from a file.
        /// </summary>
        private void LoadMessages()
        {
            // There are other ways to do this, including not putting it into an
            // actual List<string>, but this seemed most consistent with what we have
            // done to this point.
            string[] allLines = File.ReadAllLines(Constants.MESSAGE_FILE);

            _messages = new List<string>();
            foreach (string line in allLines)
            {
                _messages.Add(line);
            }
        }

        /// <summary>
        /// Generates a new artifact at a random location.
        /// </summary>
        /// <returns></returns>
        public Artifact Generate()
        {
            Artifact artifact = new Artifact();

            int x = _randomGenerator.Next(0, Constants.MAX_X - Constants.DEFAULT_FONT_SIZE);
            int y = _randomGenerator.Next(0, Constants.MAX_Y - Constants.DEFAULT_FONT_SIZE);
            artifact.SetPosition(new Point(x, y));

            char symbol = (char)_randomGenerator.Next(33, 126);
            artifact.SetText(symbol.ToString());

            string message = GetRandomMessage();
            artifact.SetDescription(message);

            return artifact;
        }

        /// <summary>
        /// Gets a random message from the messages file.
        /// </summary>
        /// <returns></returns>
        public string GetRandomMessage()
        {
            string message = _messages[_randomGenerator.Next(0, _messages.Count)];
            return message;
        }
    }
}