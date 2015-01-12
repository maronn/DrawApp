using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace DDD
{
    class Title:IScene
    {
        private InputState input;
        private bool isEnd;
        private bool isEnd2;

        public Title(InputState input)
        {
            this.input = input;
        }
        public void Initialize()
        {
            this.isEnd = false;
            this.isEnd2 = false;
        }
        public void Update()
        {
            if (this.input.IsKeyDown(Keys.Space))
            {
                this.isEnd = true;
            }
            if (this.input.IsKeyDown(Keys.S))
            {
                this.isEnd2 = true;
            }
        }
        public void Draw(Renderer renderer)
        {
            renderer.DrawTexture("title", Vector2.Zero);
        }
        public void mSound(Sound sounds)
        {

        }
        public void Shutdown()
        {

        }

        public bool IsEnd()
        {
            return this.isEnd;
        }
        public bool IsEnd2()
        {
            return this.isEnd2;
        }

        public Scene Next()
        {
            return Scene.GamePlay;
        }

        public Scene Next2()
        {
            return Scene.Stafflol;
        }
    }
}
