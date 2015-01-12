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
    class Player : Character
    {
        private InputState input;//入力用オブジェクト(白玉操作に必要)
        private float speed;
        private int hiroudo;

        private float distanceRange;
        private float disX;
        private float disY;

        private bool isHako = false;
        private bool isGoal = false;

        private bool isKiGet = false;
        private bool KiGet = false;

        private int Kinumber = 0;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="input">入力オブジェクト</param>
        /// 
        public Player(InputState input, ICharacterMediator mediator)
            : base("player", new Vector2(500.0f, 500.0f), 8.0f, mediator)
        {
            this.input = input;
        }

        /// <summary>
        /// 初期化処理
        /// </summary>

        /// <summary>
        /// 更新処理
        /// </summary>
        public override void Update()
        {
            speed = 1.5f;//白玉の移動スピード

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

            var min = new Vector2(radius + 38, radius + 42);
            var max = new Vector2(Screen.Width - radius - 50, Screen.Height - radius - 50);
            position = Vector2.Clamp(position, min, max);
        }


        /// <summary>
        /// 描画処理
        /// </summary>
        /// <param name="renderer">描画オブジェクト</param>
        /// 
        public override void Hit(Character character)
        {
            if (character is enemy1 || character is enemy1_2 || character is enemy2 || character is enemy3)
            {
                this.isDead = true;
            }

            if (character is Piano)
            {
                distanceRange = Vector2.Distance(this.position, character.Position());
                disX = this.position.X - character.Position().X;
                disY = this.position.Y - character.Position().Y;
                this.position += new Vector2(disX / distanceRange,disY / distanceRange);
            }
            if ( character is isu || character is isu2 || character is tukue || character is tukue2 || character is hako || character is hako|| character is tubo)
            {
                distanceRange = Vector2.Distance(this.position, character.Position());
                disX = this.position.X - character.Position().X;
                disY = this.position.Y - character.Position().Y;
                this.position += new Vector2(disX / distanceRange, disY / distanceRange);
            }

            //箱が開けるか状態チェック
            this.isHako = false;
            if (character is Takarabako)
            {
                if (IsCollistion(character)) //playerから見たら、characterは箱
                {
                    this.isHako = true;
                }
            }
            if ( isHako && Keyboard.GetState().IsKeyDown(Keys.F))
            {
                ((Takarabako)character).Open();
            }

            //鍵の箱を開けられるか
            this.isKiGet = false;
            if (character is TakarabakoKi)
            {
                if (IsCollistion(character))
                {
                    this.isKiGet = true;
                }

            }
            if (isKiGet && Keyboard.GetState().IsKeyDown(Keys.F))
            {
                ((TakarabakoKi)character).Open2();
            }

            //鍵を拾えるか
            this.KiGet = false;
            if (character is TakarabakoKi)
            {
                if (IsCollistion(character))
                {
                    this.KiGet = true;
                }

            }
            if (KiGet && Keyboard.GetState().IsKeyDown(Keys.G))
            {
                ((TakarabakoKi)character).KiGet();
                Kinumber = 1;
            }


            if (Kinumber == 1 && character is Goal)
            {
                this.isGoal = true;
            }

        }

        public bool IsGoal()
        {
            return isGoal;
        }

    }
    
}
