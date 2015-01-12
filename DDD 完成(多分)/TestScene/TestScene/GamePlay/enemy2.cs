using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace DDD
{
    class enemy2 : Character
    {
        public enemy2(Vector2 position,ICharacterMediator mediator)
            : base("enemy2", position, 8.0f,mediator)
        {
        }

        public override void Update()
        {
            
          if(Vector2.Distance(this.position,mediator.PlayerPosition()) <= 105)
          {  
            Vector2 temp = mediator.PlayerPosition();
            temp = temp - position;
            temp.Normalize();
            position = position + temp * 1.7f;
          }  
  
        }

        public override void Hit(Character character)
        {
        }
    }
}
