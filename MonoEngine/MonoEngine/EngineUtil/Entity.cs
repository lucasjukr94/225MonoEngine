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
        
        public Texture2D Texture2D { get; set; }

        public Vector2 Vector2
        {
            get { return new Vector2(X, Y); }
        }

        public int RenderPriority { get; set; }
        public bool HasRender { get; set; }


        public virtual void Update()
        {
            
        }

        public virtual void Control()
        {
            
        }

        public bool HasCollision { get; set; }

        public virtual void Collision(int collisionRange)
        {
            if (HasCollision)
            {
                List<IEntity> listIEntities =
                    Enum.GetValues(typeof (IEntity))
                        .Cast<IEntity>()
                        .ToList()
                        .FindAll(x => x.Id != Id && InRange(collisionRange, x.Vector2));

                listIEntities.ForEach(CollisionRange);
            }
            
        }

        public virtual void CollisionRange(IEntity entity)
        {
            
        }

        public virtual bool InRange(int collisionRadius,Vector2 vector2)
        {
            float eqCirculo = (X + vector2.X) * (X + vector2.X) + (Y + vector2.Y) * (Y + vector2.Y);
            if (eqCirculo <= collisionRadius)
            {
                return true;
            }

            return false;
        }
    }

    public interface IEntity
    {
        int Id { get; set; }
        int X { get; set; }
        int Y { get; set; }
        int Z { get; set; }
        int SpeedX { get; set; }
        int SpeedY { get; set; }
        int SpeedZ { get; set; }
        float Inertia { get; set; }
        bool HasInertia { get; set; }
        float Momentum { get; set; }
        bool HasMomentum { get; set; }
        float Mass { get; set; }
        float Weight { get; set; }
        float Density { get; set; }
        float Gravity { get; set; }
        float Width { get; set; }
        float Height { get; set; }
        float Depth { get; set; }

        Texture2D Texture2D { get; set; }

        Vector2 Vector2 { get; }

        int RenderPriority { get; set; }
        bool HasRender { get; set; }

        void Update();

        void Control();
    }
}
