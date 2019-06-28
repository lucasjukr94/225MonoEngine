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
        public virtual int Id { get; set; }
        public virtual float Gravity { get; set; }

        public virtual bool TriggerOtherWorld { get; set; }

        public virtual void Load(ContentManager Content)
        {
            
        }

        public virtual void Update()
        {
            List<IEntity> listIEntities = Enum.GetValues(typeof(IEntity)).Cast<IEntity>().ToList();
            listIEntities.ForEach(e => e.Update());
        }

        public virtual void Render(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            //Renderizando todas as entidades que herdam de IEntity de acordo com suas respectivas prioridades
            List<IEntity> listIEntities = Enum.GetValues(typeof(IEntity)).Cast<IEntity>().ToList();
            listIEntities.OrderBy(x => x.RenderPriority).ToList().ForEach(e => spriteBatch.Draw(e.Texture2D, e.Vector2));
            spriteBatch.End();
        }
    }

    public interface IScene
    {
        int Id { get; set; }
        float Gravity { get; set; }

        bool TriggerOtherWorld { get; set; }

        void Load(ContentManager Content);

        void Update();

        void Render(SpriteBatch spriteBatch);
    }
}
