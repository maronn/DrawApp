using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace DDD
{
    interface ICharacterMediator
    {
        void AddCharcter(Character charcter);
        bool IsPlayerDead();
        bool IsPlayerGoal();
        Vector2 PlayerPosition();
    }
}
