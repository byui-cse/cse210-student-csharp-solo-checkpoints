using System.Collections.Generic;
using _08_rfk.Casting;
using _08_rfk.Services;


namespace _08_rfk.Scripting
{
    /// <summary>
    /// An action to appropriately handle any collisions in the game.
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();

        public HandleCollisionsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor billboard = cast["environment"][0]; // There is only one
            Actor robot = cast["movers"][0]; // There is only one

            List<Actor> artifacts = cast["stationary"]; // Get all the artifacts

            billboard.SetText(Constants.DEFAULT_BILLBOARD_MESSAGE);

            foreach (Actor actor in artifacts)
            {
                Artifact artifact = (Artifact)actor;
                if (_physicsService.IsCollision(robot, artifact))
                {
                    string artifactText = artifact.GetDescription();
                    billboard.SetText(artifactText);
                }
            }
        }

    }
}