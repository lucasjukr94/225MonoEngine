using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoEngine.EngineUtil
{
    public abstract class Scene
    {
        public int Id { get; set; }
        public float Gravity { get; set; }

        public virtual void Load(ContentManager Content) { }

        public virtual void Update() { }

        public virtual void Render(SpriteBatch spriteBatch) { }
    }
}
