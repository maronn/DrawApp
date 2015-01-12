using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace DDD
{
    class CharacterControl : ICharacterMediator
    {
        private LinkedList<Character> characters;
        private IList<Character> newCharacters;



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
            characters.AddLast(character);
            return true;
        }
        public void Update()
        {
            foreach (Character c in characters)
            {
                c.Update();
            }
            New();
            Hit();
            Remove();
        }
        private void New()
        {
            //var newCharacters = new List<Character>();
            foreach (Character c in newCharacters)
            {
                Add(c);
                //Character newCharacter = c.New();
                //if (newCharacter != null)
                //{
                //    newCharacters.Add(newCharacter);
                //}
            }
            //foreach (Character c in newCharacters)
            //{
            //    characters.AddLast(c);
            //}
            newCharacters.Clear();
        }
        private void Hit()
        {
            foreach (Character c1 in characters)
            {
                foreach (Character c2 in characters)
                {
                    if (c1.IsCollistion(c2))
                    {
                        c1.Hit(c2);
                        c2.Hit(c1);
                    }
                }
            }
        }

        private void Remove()
        {
            LinkedListNode<Character> node = characters.First;
            while (node != null)
            {
                LinkedListNode<Character> next = node.Next;
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
                    return false;
                }
            }
            return true;
        }
        
        public bool IsPlayerGoal()
        {
            foreach (Character c in characters)
            {
                if (c is Player)
                {
                    return ((Player)c).IsGoal();
                }
            }
            return true;
        }
        public void Draw(Renderer renderer)
        {
            foreach (Character c in characters)
            {
                c.Draw(renderer);
            }
        }


        public void AddCharcter(Character charcter)
        {
            newCharacters.Add(charcter);
        }

        public Vector2 PlayerPosition()
        {
            foreach (var c in characters)
            {
                if (c is Player)
                {
                    return c.Position();
                }
            }
            return Vector2.Zero;
        }
    }
}
