using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Gui;
using FlatRedBall.Math;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Localization;
using Microsoft.Xna.Framework;



namespace BeefBall.Screens
{
    public partial class GameScreen
    {

        void CustomInitialize()
        {
            AssignInput();

        }

        void CustomActivity(bool firstTimeCalled)
        {


        }

        void CustomDestroy()
        {


        }

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

        private void AssignInput()
        {
            if (InputManager.Xbox360GamePads[0].IsConnected)
            {
                PlayerBall1.MovementInput =
                    InputManager.Xbox360GamePads[0].LeftStick;
                PlayerBall1.BoostInput =
                    InputManager.Xbox360GamePads[0].GetButton(Xbox360GamePad.Button.A);
            }
            else
            {
                PlayerBall1.MovementInput =
                    InputManager.Keyboard.Get2DInput(Microsoft.Xna.Framework.Input.Keys.A,
                    Microsoft.Xna.Framework.Input.Keys.D,
                    Microsoft.Xna.Framework.Input.Keys.W,
                    Microsoft.Xna.Framework.Input.Keys.S);
                PlayerBall1.BoostInput =
                    InputManager.Keyboard.GetKey(Microsoft.Xna.Framework.Input.Keys.B);
            }
        }

    }
}
