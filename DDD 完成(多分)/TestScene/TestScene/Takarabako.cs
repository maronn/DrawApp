using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace DDD
{
    class Takarabako : Character
    {


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="input">入力オブジェクト</param>
        public Takarabako()
            :base("takarabako",32.0f)
        {
            
        }

        /// <summary>
        /// 初期化処理
        /// </summary>
        public override void Initialize()
        {
            position = new Vector2(64.0f, 64.0f);
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
    }
}
