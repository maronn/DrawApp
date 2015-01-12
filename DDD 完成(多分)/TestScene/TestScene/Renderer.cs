using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace DDD
{
    class Renderer
    {
        private ContentManager contentManager;
        private GraphicsDevice graphicsDevice;

        private SpriteBatch spriteBatch;

        private Dictionary<string, Texture2D> textures = new Dictionary<string, Texture2D>();

        public Renderer(ContentManager content, GraphicsDevice graphics)
        {
            contentManager = content;
            contentManager.RootDirectory = "Content";
            graphicsDevice = graphics;
            spriteBatch = new SpriteBatch(graphics);
        }

        public void LoadTexture(string name)
        {
            textures[name] = contentManager.Load<Texture2D>(name);
        }

        public void Unload()
        {
            textures.Clear();
            contentManager.Unload();
        }

        public void Begin()
        {
             spriteBatch.Begin();
        }

        public void End()
        {
            spriteBatch.End();
        }

        public void DrawTexture(string name, Vector2 position, float alpha = 1.0f)
        {
             spriteBatch.Draw(textures[name], position, Color.White * alpha);
        }

        public void DrawNumber(string name, Vector2 position, int number)
        {
            foreach (var n in number.ToString())
            {
                spriteBatch.Draw(
                    textures[name],
                    position,
                    new Rectangle(int.Parse("" + n) * 32, 0, 32, 64),
                    Color.White);

                position.X = position.X + 32;
            }
        }
    }
}
