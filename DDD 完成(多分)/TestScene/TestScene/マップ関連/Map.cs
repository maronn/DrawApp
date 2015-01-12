using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.IO;

namespace DDD
{
    class Map
    {//ブロックを大量に管理
        private ICharacterMediator mediator;
        public Map(ICharacterMediator mediator)
        {
            this.mediator = mediator;
        }
        public void Load(String filename)
        { 
            //ファイルからロード
            var file = new FileStream("Content\\"+filename,
                FileMode.Open);
            StreamReader read = new StreamReader(file);

            int lineCnt = 0;
            string line;
            while ((line = read.ReadLine()) != null)
            {
                Console.WriteLine(line);
                AddItems(lineCnt, line);
                lineCnt++;
            }

            file.Close();
        }
        private void AddItems(int lineCnt, string line)
        {
            string[] part = line.Split(new[] { ',' }, StringSplitOptions.None);
            int ColCnt = 0;
            foreach (string s in part)
            {
                if (s == "1")
                {
                    mediator.AddCharcter(new Piano(new Vector2(ColCnt * 32 + 16, lineCnt * 32 + 16),mediator));
                }
                if (s == "2")
                {
                    mediator.AddCharcter(new tubo(new Vector2(ColCnt * 32 + 16, lineCnt * 32 + 16), mediator));
                } 
                if (s == "3")
                {
                    mediator.AddCharcter(new isu(new Vector2(ColCnt * 32 + 16, lineCnt * 32 + 16), mediator));
                }
                if (s == "4")
                {
                    mediator.AddCharcter(new isu2(new Vector2(ColCnt * 32 + 16, lineCnt * 32 + 16), mediator));
                }
                if (s == "5")
                {
                    mediator.AddCharcter(new tukue(new Vector2(ColCnt * 32 + 16, lineCnt * 32 + 16), mediator));
                }
                if (s == "6")
                {
                    mediator.AddCharcter(new tukue2(new Vector2(ColCnt * 32 + 16, lineCnt * 32 + 16), mediator));
                }
                if (s == "7")
                {
                    mediator.AddCharcter(new hako(new Vector2(ColCnt * 32 + 16, lineCnt * 32 + 16), mediator));
                }



                ColCnt++;
            }

        }
    }
}
