using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace DDD
{
    class Piano:Character
    {
        public Piano(Vector2 position, ICharacterMediator mediator)
            : base("ものすごく苦労したピアノ", position, 21.0f, mediator)
        {
        }
        public override void Update()
        {
            ;
        }
        

        public override void Hit(Character character)
        {
            ;
        }
        
    }
}
