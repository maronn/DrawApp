using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace DDD
{
    abstract class Character
    {
        protected string name;
        protected Vector2 position;
        protected float radius;


        protected Character(string name, float radius)
        {
            this.name = name;
            this.radius = radius;
            position = Vector2.Zero;
        }

        public abstract void Initialize();
        public abstract void Update();

        public void Draw(Renderer renderer)
        {
            renderer.DrawTexture(name, position - new Vector2(radius, radius));
        }

        public bool IsCollistion(Character other)
        {
            if (Vector2.Distance(position, other.position) <= (radius + other.radius))
            {
                return true;
            }
            return false;
        }
    }
}