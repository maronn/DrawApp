using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Shooting
{
    class Enemy : Character
    {
        public Enemy(Vector2 position,ICharcterMediator mediator)
            : base("Enemy64", position, 32.0f,mediator)
        {
        }
        public override void Update()
        {
            position = position + new Vector2(-10.0f, 0.0f);
            if (position.X < (0.0f + radius))
            {
                isDead = true;
            }
        }
        public override void Hit(Character character)
        {
            if (character is Bullet || character is Player)
            {
                isDead = true;
            }
        }
    }
}
