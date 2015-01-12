using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace DDD
{
    class Kurayami:Character
    {
         private InputState input;//入力用オブジェクト(白玉操作に必要)
        private float speed;
        private int hiroudo;
       

       

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="input">入力オブジェクト</param>
        public Kurayami(InputState input)
            : base("暗闇", 16.0f)
        {
            this.input = input;
        }

        /// <summary>
        /// 初期化処理
        /// </summary>
        public override void Initialize()
        {
               position = new Vector2(Screen.Width / 2 + 16, Screen.Height / 2 + 16);//初期位置
        }

        /// <summary>
        /// 更新処理
        /// </summary>
        public override void Update()
        {
            speed = 1.0f;//白玉の移動スピード

            if (Keyboard.GetState().IsKeyDown(Keys.D) && hiroudo < 400)
            {
                speed = 3.0f;
                hiroudo = hiroudo + 2;
            }

            if (Keyboard.GetState().IsKeyUp(Keys.D) && hiroudo > 0)
            {
                hiroudo--;
            }


            //白玉の座標に運動量を加え、次の座標を求める
            position = position + input.Velocity() * speed;

            var min = new Vector2(radius, radius);
            var max = new Vector2(Screen.Width - radius, Screen.Height - radius);
            position = Vector2.Clamp(position, min, max);
        }


        /// <summary>
        /// 描画処理
        /// </summary>
        /// <param name="renderer">描画オブジェクト</param>
    }
    }

