using System;

namespace _08_rfk.Casting
{
    /// <summary>
    /// Defines an artifact, which is an actor that also has a description.
    /// </summary>
    public class Artifact : Actor
    {
        private string _description;

        public Artifact()
        {
            SetText("?");
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string description)
        {
            _description = description;
        }

    }
}