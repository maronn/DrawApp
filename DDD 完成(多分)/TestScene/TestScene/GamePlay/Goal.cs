using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace DDD
{
    class Goal : Character
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="input">入力オブジェクト</param>
        public Goal(Vector2 position, ICharacterMediator mediator)
            : base ("goal",position, 16.0f, mediator)
        {
            
        }

        /// <summary>
        /// 更新処理
        /// </summary>
        public override void Update()
        {
            
        }

        /// <summary>
        /// 描画処理
        /// </summary>
        /// <param name="renderer">描画オブジェクト</param>
        /// 
        public override void Hit(Character character)
        {
        }
    }
}
