using System;
using System.Collections.Generic;
using _08_rfk.Casting;

namespace _08_rfk
{
    /// <summary>
    /// The base class of all other actions.
    /// </summary>
    public abstract class Action
    {
        public virtual void Execute(Dictionary<string, List<Actor>> cast)
        {
            throw new NotImplementedException();
        }
    }
}