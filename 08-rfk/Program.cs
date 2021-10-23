using System;
using _08_rfk.Services;
using _08_rfk.Casting;
using _08_rfk.Scripting;
using System.Collections.Generic;

namespace _08_rfk
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();

            // Environment Objects
            cast["environment"] = new List<Actor>();

            Billboard billboard = new Billboard();
            cast["environment"].Add(billboard);

            // The movers in the game
            cast["movers"] = new List<Actor>();

            Robot robot = new Robot();
            cast["movers"].Add(robot);

            // Stationary objects
            cast["stationary"] = new List<Actor>();

            ArtifactGenerator generator = new ArtifactGenerator();

            Artifact kitten = generator.Generate();
            kitten.SetDescription("You found the kitten!");
            cast["stationary"].Add(kitten);

            for (int i = 0; i < Constants.NUM_ARTIFACTS; i++)
            {
                Artifact artifact = generator.Generate();
                cast["stationary"].Add(artifact);
            }

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();


            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);

            MoveActorsAction moveActorsAction = new MoveActorsAction();
            script["update"].Add(moveActorsAction);

            HandleCollisionsAction handleCollisionsAction = new HandleCollisionsAction(physicsService);
            script["update"].Add(handleCollisionsAction);

            ControlActorsAction controlActorsAction = new ControlActorsAction(inputService);
            script["input"].Add(controlActorsAction);

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Robot Finding Kitten", Constants.FRAME_RATE);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();
        }
    }
}
