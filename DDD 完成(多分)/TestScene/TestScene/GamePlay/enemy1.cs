using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace DDD
{
    class enemy1 : Character
    {
        float time = 0.0f;
        float speed = 1.0f;
        Vector2 startPosition;

        public enemy1(Vector2 position, ICharacterMediator mediator, float t)
            : base("enemy1", position, 8.0f, mediator)
        {
            startPosition = position;
            time = t;
        }

        public override void Update()
        {
            time++;

            position.X += speed;
            position.Y += 0.0f;
            position = position + new Vector2(speed, 0.0f);
 
            if (time == 120)
            {
                speed = speed * -1;
                time = 0;
            }
        }

        public override void Hit(Character character)
        {
        }
    }
}
