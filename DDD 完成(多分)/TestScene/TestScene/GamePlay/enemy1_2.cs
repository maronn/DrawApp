using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace DDD
{
    class enemy1_2 : Character
    {
        float time = 0.0f;
        float speed = 1.0f;
        //float dierction = 0.05f;
        Vector2 startPosition;

        public enemy1_2(Vector2 position, ICharacterMediator mediator, float t)
            : base("enemy1", position, 8.0f, mediator)
        {
            startPosition = position;
            time = t;
        }

        public override void Update()
        {
            time++;

            position.X += 0.0f;
            position.Y += speed;
            position = position + new Vector2(0.0f, speed);
            if (time == 120)
            {
                speed = speed * -1;
                time = 0;
            }

            /*time += 1 * dierction;

            if (time > 1 || time < 0)
            {
                dierction *= -1;
            }
            position = new Vector2(startPosition.X, lerp(startPosition.Y, startPosition.Y + 100, time));
            */
        }

        public override void Hit(Character character)
        {   
        }

        //public float lerp(float a, float b, float timer)
        //{
        //    float range = ((a) + ((b) - (a)) * (timer));
        //    return range;
        //}
    }
}