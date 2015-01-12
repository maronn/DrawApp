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
        protected bool isDead = false;
   
        protected ICharacterMediator mediator;

        public abstract void Update();
        public abstract void Hit(Character character);

        protected Character(string name, Vector2 position, float radius, ICharacterMediator mediator)
        {
            this.name = name;
            this.position = position;
            this.radius = radius;
            this.mediator = mediator;
        }

        public void Draw(Renderer renderer)
        {
            //if (this is Player)
            //{
            //    renderer.DrawTexture("kurayami",position - new Vector2(1030.0f, 760.0f));
            //}
            renderer.DrawTexture(name, this.position - new Vector2(radius,radius));
        }

        public bool IsDead()
        {
            return isDead;
        }

        public bool IsCollistion(Character other)
        {
            if (Vector2.Distance(position, other.position) <= (radius + other.radius))
            {
                return true;
            }
            return false;
        }

        public Vector2 Position()
        {
            return position;
        }
    }
}