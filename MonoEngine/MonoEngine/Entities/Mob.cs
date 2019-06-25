using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoEngine.EngineUtil;

namespace MonoEngine.Entities
{
    public class Mob : Entity, IEntity
    {
        public Mob(int Id, int X, int Y, int Z, ContentManager Content)
        {
            this.Id = Id;
            this.X = X;
            this.Y = Y;
            this.Z = Z;

            HasCollision = true;

            RenderPriority = 0;

            Texture2D = Content.Load<Texture2D>("");
        }

        public override void Update()
        {
            Collision(10);
            Control();
        }

        public override void Control()
        {
            
        }

        public override void CollisionRange(IEntity entity)
        {
            
        }
    }
}
