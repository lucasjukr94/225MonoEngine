using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoEngine.EngineUtil;

namespace MonoEngine.Entities
{
    public class Player : Entity
    {
        public Player(int Id, int X, int Y, int Z, ContentManager Content)
        {
            this.Id = Id;
            this.X = X;
            this.Y = Y;
            this.Z = Z;

            RenderPriority = 0;

            Texture2D = Content.Load<Texture2D>("");
        }

        public override void Update()
        {
            Control();
            Collision();
        }

        public override void Control()
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                //TODO: Move entity
            }
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                //TODO: Move entity
            }
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                //TODO: Move entity
            }
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                //TODO: Move entity
            }
        }

        public override void Collision()
        {

        }
    }
}
