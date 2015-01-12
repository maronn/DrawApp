using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace DDD
{
    class TakarabakoKi : Character
    {
        private bool isOpen2 = false;
        private bool isKiGet = false;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="input">入力オブジェクト</param>
        public TakarabakoKi(Vector2 position, ICharacterMediator mediator)
            : base("takarabako", position, 16.0f, mediator)
        {
        }

        /// <summary>
        /// 初期化処理
        /// </summary>

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

        public bool IsOpen2()
        {
            return isOpen2;
        }

        public bool IsKiGet()
        {
            return isKiGet;
        }

        public void Open2()
        {
            isOpen2 = true;
            name = "takarabakoki";
        }

        public void KiGet()
        {
            isKiGet = true;
            name = "takarabakoaku";
        }
    }
}
