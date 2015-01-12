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
    class Kurayami
    {
        private Vector2 position;

        public Kurayami()
        {
    
        }

        public void Initialize()
        {
            position = new Vector2(-1025.0f, -760.0f);
        }

        public void Update(Vector2 playerPos)
        {
            position = playerPos + new Vector2(-1025.0f, -760.0f);
        }

        public void Draw(Renderer renderer)
        {
            renderer.DrawTexture("kurayami",position);
        }

        //public  void Hit2(Kurayami kurayami)
        //{
        //    if (kurayami is Piano)
        //    {
        //        distanceRange = Vector2.Distance(this.position, kurayami.Position());
        //        disX = this.position.X - kurayami.Position().X;
        //        disY = this.position.Y - kurayami.Position().Y;
        //        this.position += new Vector2(disX / distanceRange, disY / distanceRange);
        //    }
        //    if (kurayami is isu || kurayami is isu2 || kurayami is tukue || kurayami is tukue2 || kurayami is hako || kurayami is hako || kurayami is tubo)
        //    {
        //        distanceRange = Vector2.Distance(this.position, kurayami.Position());
        //        disX = this.position.X - kurayami.Position().X;
        //        disY = this.position.Y - kurayami.Position().Y;
        //        this.position += new Vector2(disX / distanceRange, disY / distanceRange);
        //    }
        //}
        /// <summary>
        /// 描画処理
        /// </summary>
        /// <param name="renderer">描画オブジェクト</param>
        /// 
        public void Hit(Character character)
        {
        }
    }
}

