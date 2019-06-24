using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoEngine.EngineUtil
{
    public class CollisionBox
    {
        public CollisionBox(Entity entity)
        {
            Entity = entity;
        }

        public Entity Entity { get; set; }
        public Shape Shape { get; set; }
    }
}
