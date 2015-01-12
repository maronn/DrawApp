using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace DDD
{
    class Stafflol:IScene
    {
        private InputState input;
        private bool isEnd;
        private bool isEnd2;
        public Stafflol(InputState input)
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
            if (this.input.IsKeyDown(Keys.Space) || this.input.IsKeyDown(Keys.S))
            {
                this.isEnd = true;
            }
        }
        public void Draw(Renderer renderer)
        {
            renderer.DrawTexture("stafflol", Vector2.Zero);
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
            return Scene.Title;
        }
        public Scene Next2()
        {
            return Scene.Title;
        }
    }
}
