using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace DDD
{
    class Ki : Character
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="input">入力オブジェクト</param>

        private Random rand;
        private int goalflag = 0;

        public Ki()
            : base("ki", 32.0f)
        {

        }

        /// <summary>
        /// 初期化処理
        /// </summary>
        public override void Initialize()
        {
            rand = new Random();

            if(rand.Next(8) == 0)
            {
                position = new Vector2(832.0f, 672.0f);
            }
            else if (rand.Next(8) == 1)
            {
                position = new Vector2(864.0f, 672.0f);
            }
            else if (rand.Next(8) == 2)
            {
                position = new Vector2(800.0f, 672.0f);
            }
            else if (rand.Next(8) == 3)
            {
                position = new Vector2(864.0f, 640.0f);
            }
            else if (rand.Next(8) == 4)
            {
                position = new Vector2(800.0f,640.0f);
            }
            else if (rand.Next(8) == 5)
            {
                position = new Vector2(832.0f,608.0f);
            }
            else if (rand.Next(8) == 6)
            {
                position = new Vector2(864.0f,608.0f);
            }
            else 
            {
                position = new Vector2(800.0f,608.0f);
            }
        }

        /// <summary>
        /// 更新処理
        /// </summary>
        public override void Update()
        {

        }

        public void Get()
        {
            position = new Vector2(0.0f, 0.0f);
            goalflag = 1;
        }

        public bool IsKiget()
        {
            if(goalflag == 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 描画処理
        /// </summary>
        /// <param name="renderer">描画オブジェクト</param>
    }

}