using System;

namespace _06_nim
{
    /// <summary>
    /// This class abstracts the User interface for the project. In this case
    /// it wraps calls to the Console to display and get information from the user.
    /// 
    /// In the future it could be modified to other types of Input/Output besides
    /// the Console, and it could also include checking for valid input, etc.
    /// 
    /// Stereotype:
    ///     Service Provider, Interfacer
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// Displays the provided text.
        /// </summary>
        /// <param name="text">The text to display</param>
        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        /// Gets a numeric value from the user after displaying the provided
        /// prompt text.
        /// </summary>
        /// <param name="promptText">The text to display as a prompt</param>
        /// <returns>The user's response (as an int)</returns>
        public int GetNumberInput(string promptText)
        {
            Console.Write(promptText);
            string userInput = Console.ReadLine();

            // One of the benefits of abstracting this user i/o into this service class
            // is that we could add extra functionality here, such as checking
            // for a valid number and re-prompting if the user entered something invalid.
            
            // For simplicity, right now, it assumes proper input.
            int numericChoice = int.Parse(userInput);
            return numericChoice;
        }

        /// <summary>
        /// Gets a string value from the user after displaying the provided prompt text.
        /// </summary>
        /// <param name="promptText">The text to display as a prompt</param>
        /// <returns>The user's response</returns>
        public string GetStringInput(string promptText)
        {
            Console.Write(promptText);
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}
