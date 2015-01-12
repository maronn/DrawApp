using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Shooting
{
    class CharacterControl : ICharcterMediator
    {
        private LinkedList<Character> characters;
        private List<Character> newCharacters;

        public CharacterControl() { }
        public void Initialize()
        {
            if (characters != null)
            {
                characters.Clear();
            }
            characters = new LinkedList<Character>();
            newCharacters = new List<Character>();
        }
        public bool Add(Character character)
        {
            //キャラをコレクションに追加
            characters.AddLast(character);
            return true;
        }
        public void Update()
        {
            foreach (Character c in characters)
            {//管理している全キャラを行動
                c.Update();
            }
            New();//弾発射
            Hit();//当たり
            Remove();//キャラを消す
        }
        private void New()
        {
            foreach (Character c in newCharacters)
            {
                Add(c);
            }
            newCharacters.Clear();
        }
        private void Hit()
        {
            foreach (Character c1 in characters)
            {//キャラ同士の総当たり
                foreach (Character c2 in characters)
                {
                    if (c1.Collision(c2))
                    {//キャラ同士が当たっていたら
                        c1.Hit(c2);//それぞれのキャラに
                        c2.Hit(c1);//当たったキャラを伝える
                    }
                }
            }
        }
        private void Remove()
        {
            LinkedListNode<Character> node = characters.First;
            while (node != null)//先頭から開始
            {
                LinkedListNode<Character> next = node.Next;//次のキャラ
                if (node.Value.IsDead())
                {
                    characters.Remove(node);

                }
                node = next;
            }

        }
        public bool IsPlayerDead()
        {
            foreach (Character c in characters)
            {
                if (c is Player)
                {
                    return false;//生きている
                }
            }
            return true;//死んでいる
        }
        public void Draw(Renderer renderer)
        {
            foreach (Character c in characters)
            {
                c.Draw(renderer);
            }
        }

        public void AddCharcter(Character character)
        {
            newCharacters.Add(character);
        }
    }
}
