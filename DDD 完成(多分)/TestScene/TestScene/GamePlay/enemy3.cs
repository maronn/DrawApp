using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
namespace DDD
{
    class enemy3 : Character
    {
        public enemy3(Vector2 position, ICharacterMediator mediator)
            : base("enemy3", position, 8.0f, mediator)
        {
        }
        public override void Update()
        {


            Vector2 temp = mediator.PlayerPosition();
            temp = temp - position;
            temp.Normalize();
            position = position + temp * 1.5f;



        }
        public override void Hit(Character character)
        {

        }
    }
}
