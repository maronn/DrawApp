using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDD
{
    interface IScene
    {
        void Initialize();
        void Update();
        void Draw(Renderer renderer);
        void mSound(Sound sounds);
        void Shutdown();
        bool IsEnd();
        bool IsEnd2();
        Scene Next();
        Scene Next2();
    }
}
