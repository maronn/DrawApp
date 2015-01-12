using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Shooting
{
    class Bullet : Character
    {
        public Bullet(Vector2 position,ICharcterMediator mediator)
            : base("Bullet16", position, 8.0f,mediator)
        {
        }
        public override void Update()
        {
            position = position + new Vector2(10.0f, 0.0f);
            if (position.X > (Screen.Width + radius))
            {
                isDead = true;
            }
        }
        public override void Hit(Character character)
        {
            if (character is Enemy)
            {
                isDead = true;
            }
        }
    }
}
