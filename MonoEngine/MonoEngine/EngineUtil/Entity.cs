using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoEngine.EngineUtil
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public int SpeedX { get; set; }
        public int SpeedY { get; set; }
        public int SpeedZ { get; set; }
        public float Inertia { get; set; }
        public bool HasInertia { get; set; }
        public float Momentum { get; set; }
        public bool HasMomentum { get; set; }
        public float Mass { get; set; }
        public float Weight { get; set; }
        public float Density { get; set; }
        public float Gravity { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Depth { get; set; }
        public CollisionBox CollisionBox { get; set; }
        public Texture2D Texture2D { get; set; }

        public Vector2 Vector2
        {
            get { return new Vector2(X, Y); }
        }

        public int RenderPriority { get; set; }
        public bool HasRender { get; set; }

        public virtual void Update() { }

        public virtual void Control() { }

        public virtual void Collision() { }
    }
}
