using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoEngine.EngineUtil;
using MonoEngine.Entities;

namespace MonoEngine.Scenes
{
    public class World : Scene, IScene
    {
        public World(int Id, float Gravity)
        {
            this.Id = Id;
            this.Gravity = Gravity;
            Players = new List<Player>();
            Tiles = new List<Tile>();
            Mobs = new List<Mob>();

            TriggerOtherWorld = false;
        }

        public List<Player> Players { get; set; }
        public List<Tile> Tiles { get; set; }
        public List<Mob> Mobs { get; set; } 

        public override void Load(ContentManager Content)
        {
            Player player = new Player(0, 0, 0, 0, Content);
            player.Width = 50;
            player.Height = 50;
            Players.Add(player);

            Tile tile = new Tile(0, 0, 0, 0, Content);
            Tiles.Add(tile);

            Mob mob = new Mob(0, 0, 0, 0, Content);
            Mobs.Add(mob);
        }

    }
}
