using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace DDD
{
    /// <summary>
    /// キー入力状態クラス
    /// </summary>
    class InputState
    {
        //現在のキーを表すメンバ変数
        private KeyboardState currentKey;

        //１フレーム前のキーを表すメンバ変数
        private KeyboardState prebiosKey;

        //フィールド：移動速度：(0,0)で初期化
        private Vector2 velocity = Vector2.Zero;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InputState() { }

        /// <summary>
        /// Tigger判定
        /// 押しっぱなし状態(１フレーム前押されている場合)はfalseと判定
        /// </summary>
        /// <param name="key">チェックしたいキー</param>
        /// <returns>現フレームで押され、１フレーム前押されていなければtrue</returns>
        public bool IsKeyDown(Keys key)
        {
            bool current = currentKey.IsKeyDown(key);//現在チェックしたいキーが押されたか
            bool previos = prebiosKey.IsKeyDown(key);//1フレーム前に押されたか
            return current && !previos;
        }

        /// <summary>
        /// 移動速度(ベクトル)を取得する
        /// </summary>
        /// <returns></returns>
        public Vector2 Velocity()
        {
            return velocity;
        }
        /// <summary>
        /// キーノ更新処理
        /// </summary>
        /// <param name="keyState">最新のキー情報</param>
        private void UpdateKey(KeyboardState keyState)
        {
            //現在登録されているキーを１フレーム前のキーにする
            prebiosKey = currentKey;
            //最新キーを現在のキーに
            currentKey = keyState;
        }

        /// <summary>
        /// 移動速度の更新処理
        /// </summary>
        /// <param name="keyState">最新のキー情報</param>
        private void UpdateVelocity(KeyboardState keyState)
        {
            //移動族度をゼロベクトル(0,0)で初期化
            velocity = Vector2.Zero;

            //キー入力処理
            if (keyState.IsKeyDown(Keys.Right))//右
            {
                velocity.X = 1.0f;
            }
            if (keyState.IsKeyDown(Keys.Left))//左
            {
                velocity.X = -1.0f;
            }
            if (keyState.IsKeyDown(Keys.Down))//下
            {
                velocity.Y = 1.0f;
            }
            if (keyState.IsKeyDown(Keys.Up))//上
            {
                velocity.Y = -1.0f;
            }
            //ベクトルの長さを単位ベクトルへ変更処理
            //(ななめも移動も同じ速度にする)
            if (velocity.Length() != 0.0f)//0でなければ処理対象
            {
                //正規化(長さを１にする)
                velocity.Normalize();
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        public void Update()
        {
            //現在のキーボードの状態を取得
            var keyState = Keyboard.GetState();
            //Starキーの更新処理
            UpdateKey(keyState);

            //移動速度の更新
            UpdateVelocity(keyState);
        }
    }
}
