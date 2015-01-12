using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;


namespace DDD
{
    class GamePlay : IScene
    {
        private InputState input;
        private bool isEnd;
        private bool isEnd2;

        private int time;
        private int kaminari;

        private Kurayami kurayami;

        private CharacterControl characterControl;
        private Random rand;
        private Map map;

        public GamePlay(InputState input)
        {
            this.input = input;
        }
        public void Initialize()
        {
            rand = new Random(Environment.TickCount);

            time = 0;
            kaminari = 0;

            this.isEnd = false;
            this.isEnd2 = false;

            characterControl = new CharacterControl();
            characterControl.Initialize();

            kurayami = new Kurayami();
            kurayami.Initialize();

            rand = new Random();

            map = new Map(characterControl);

            map.Load("kag.csv");


            //横幽霊
            characterControl.Add(new enemy1(new Vector2(780.0f, 50.0f), characterControl, 30.0f));
            characterControl.Add(new enemy1(new Vector2(750.0f, 170.0f), characterControl, 40.0f));
            characterControl.Add(new enemy1(new Vector2(260.0f, 200.0f), characterControl, 30.0f));
            characterControl.Add(new enemy1(new Vector2(230.0f, 320.0f), characterControl, 50.0f));
            characterControl.Add(new enemy1(new Vector2(775.0f, 410.0f), characterControl, 25.0f));
            characterControl.Add(new enemy1(new Vector2(260.0f, 585.0f), characterControl, 10.0f));

            //縦幽霊
            characterControl.Add(new enemy1_2(new Vector2(240.0f, 555.0f), characterControl, 40.0f));
            characterControl.Add(new enemy1_2(new Vector2(400.0f, 50.0f), characterControl, 0.0f));
            characterControl.Add(new enemy1_2(new Vector2(593.0f, 110.0f), characterControl, 30.0f));
            characterControl.Add(new enemy1_2(new Vector2(655.0f, 390.0f), characterControl, 50.0f));

            //追尾幽霊
            characterControl.Add(new enemy2(new Vector2(500.0f, 55.0f), characterControl));
            characterControl.Add(new enemy2(new Vector2(100.0f, 100.0f), characterControl));
            characterControl.Add(new enemy2(new Vector2(900.0f, 110.0f), characterControl));
            characterControl.Add(new enemy2(new Vector2(147.0f, 620.0f), characterControl));
            characterControl.Add(new enemy2(new Vector2(815.0f, 620.0f), characterControl));






//************ 宝箱配置　~以下、クソース~*******************************************************************************************




            if (rand.Next(10) == 0)
            {
                characterControl.Add(new TakarabakoKi(new Vector2(55.0f, 55.0f), characterControl)); //当たり
                characterControl.Add(new Takarabako(new Vector2(400.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 55.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 170.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(817.0f, 170.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(210.0f, 200.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(430.0f, 200.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(945.0f, 220.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(690.0f, 290.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(150.0f, 320.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(350.0f, 320.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(800.0f, 350.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(250.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(450.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 400.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(340f, 500.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(687f, 500.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(895.0f, 515.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(180.0f, 550.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(575.0f, 570.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(390.0f, 580.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 617.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(145.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(210.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(470.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(850.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(945.0f, 655.0f), characterControl));
            }
            else if (rand.Next(10) == 1)
            {
                characterControl.Add(new Takarabako(new Vector2(55.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(400.0f, 55.0f), characterControl));
                characterControl.Add(new TakarabakoKi(new Vector2(590.0f, 55.0f), characterControl)); //当たり

                characterControl.Add(new Takarabako(new Vector2(750.0f, 170.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(817.0f, 170.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(210.0f, 200.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(430.0f, 200.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(945.0f, 220.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(690.0f, 290.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(150.0f, 320.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(350.0f, 320.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(800.0f, 350.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(250.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(450.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 400.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(340f, 500.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(687f, 500.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(895.0f, 515.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(180.0f, 550.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(575.0f, 570.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(390.0f, 580.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 617.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(145.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(210.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(470.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(850.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(945.0f, 655.0f), characterControl));
            }
            else if (rand.Next(10) == 2)
            {
                characterControl.Add(new Takarabako(new Vector2(55.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(400.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 55.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 170.0f), characterControl));
                characterControl.Add(new TakarabakoKi(new Vector2(817.0f, 170.0f), characterControl)); //当たり

                characterControl.Add(new Takarabako(new Vector2(210.0f, 200.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(430.0f, 200.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(945.0f, 220.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(690.0f, 290.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(150.0f, 320.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(350.0f, 320.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(800.0f, 350.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(250.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(450.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 400.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(340f, 500.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(687f, 500.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(895.0f, 515.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(180.0f, 550.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(575.0f, 570.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(390.0f, 580.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 617.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(145.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(210.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(470.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(850.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(945.0f, 655.0f), characterControl));
            }
            else if (rand.Next(10) == 3)
            {
                characterControl.Add(new Takarabako(new Vector2(55.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(400.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 55.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 170.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(817.0f, 170.0f), characterControl));

                characterControl.Add(new TakarabakoKi(new Vector2(210.0f, 200.0f), characterControl));//当たり
                characterControl.Add(new Takarabako(new Vector2(430.0f, 200.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(945.0f, 220.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(690.0f, 290.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(150.0f, 320.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(350.0f, 320.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(800.0f, 350.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(250.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(450.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 400.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(340f, 500.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(687f, 500.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(895.0f, 515.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(180.0f, 550.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(575.0f, 570.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(390.0f, 580.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 617.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(145.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(210.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(470.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(850.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(945.0f, 655.0f), characterControl));
            }
            else if (rand.Next(10) == 4)
            {
                characterControl.Add(new Takarabako(new Vector2(55.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(400.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 55.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 170.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(817.0f, 170.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(210.0f, 200.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(430.0f, 200.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(945.0f, 220.0f), characterControl));

                characterControl.Add(new TakarabakoKi(new Vector2(690.0f, 290.0f), characterControl));//当たり

                characterControl.Add(new Takarabako(new Vector2(150.0f, 320.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(350.0f, 320.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(800.0f, 350.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(250.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(450.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 400.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(340f, 500.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(687f, 500.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(895.0f, 515.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(180.0f, 550.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(575.0f, 570.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(390.0f, 580.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 617.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(145.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(210.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(470.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(850.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(945.0f, 655.0f), characterControl));
            }
            else if (rand.Next(10) == 5)
            {
                characterControl.Add(new Takarabako(new Vector2(55.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(400.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 55.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 170.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(817.0f, 170.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(210.0f, 200.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(430.0f, 200.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(945.0f, 220.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(690.0f, 290.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(150.0f, 320.0f), characterControl));
                characterControl.Add(new TakarabakoKi(new Vector2(350.0f, 320.0f), characterControl));//当たり

                characterControl.Add(new Takarabako(new Vector2(800.0f, 350.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(250.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(450.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 400.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(340f, 500.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(687f, 500.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(895.0f, 515.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(180.0f, 550.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(575.0f, 570.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(390.0f, 580.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 617.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(145.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(210.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(470.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(850.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(945.0f, 655.0f), characterControl));
            }
            else if (rand.Next(10) == 6)
            {
                characterControl.Add(new Takarabako(new Vector2(55.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(400.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 55.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 170.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(817.0f, 170.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(210.0f, 200.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(430.0f, 200.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(945.0f, 220.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(690.0f, 290.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(150.0f, 320.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(350.0f, 320.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(800.0f, 350.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(250.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(450.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 400.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(340f, 500.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(687f, 500.0f), characterControl));

                characterControl.Add(new TakarabakoKi(new Vector2(895.0f, 515.0f), characterControl));//当たり

                characterControl.Add(new Takarabako(new Vector2(180.0f, 550.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(575.0f, 570.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(390.0f, 580.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 617.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(145.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(210.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(470.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(850.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(945.0f, 655.0f), characterControl));
            }
            else if (rand.Next(10) == 7)
            {
                characterControl.Add(new Takarabako(new Vector2(55.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(400.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 55.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 170.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(817.0f, 170.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(210.0f, 200.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(430.0f, 200.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(945.0f, 220.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(690.0f, 290.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(150.0f, 320.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(350.0f, 320.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(800.0f, 350.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(250.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(450.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 400.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(340f, 500.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(687f, 500.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(895.0f, 515.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(180.0f, 550.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(575.0f, 570.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(390.0f, 580.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 617.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(145.0f, 655.0f), characterControl));
                characterControl.Add(new TakarabakoKi(new Vector2(210.0f, 655.0f), characterControl));//当たり
                characterControl.Add(new Takarabako(new Vector2(470.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(850.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(945.0f, 655.0f), characterControl));
            }
            else if (rand.Next(10) == 8)
            {
                characterControl.Add(new Takarabako(new Vector2(55.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(400.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 55.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 170.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(817.0f, 170.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(210.0f, 200.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(430.0f, 200.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(945.0f, 220.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(690.0f, 290.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(150.0f, 320.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(350.0f, 320.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(800.0f, 350.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(250.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(450.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 400.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(340f, 500.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(687f, 500.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(895.0f, 515.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(180.0f, 550.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(575.0f, 570.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(390.0f, 580.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 617.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(145.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(210.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(470.0f, 655.0f), characterControl));
                characterControl.Add(new TakarabakoKi(new Vector2(850.0f, 655.0f), characterControl));//当たり
                characterControl.Add(new Takarabako(new Vector2(945.0f, 655.0f), characterControl));
            }
            else
            {
                characterControl.Add(new Takarabako(new Vector2(55.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(400.0f, 55.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 55.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 170.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(817.0f, 170.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(210.0f, 200.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(430.0f, 200.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(945.0f, 220.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(690.0f, 290.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(150.0f, 320.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(350.0f, 320.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(800.0f, 350.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(250.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(450.0f, 400.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(590.0f, 400.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(340f, 500.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(687f, 500.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(895.0f, 515.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(180.0f, 550.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(575.0f, 570.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(390.0f, 580.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(750.0f, 617.0f), characterControl));

                characterControl.Add(new Takarabako(new Vector2(145.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(210.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(470.0f, 655.0f), characterControl));
                characterControl.Add(new Takarabako(new Vector2(850.0f, 655.0f), characterControl));
                characterControl.Add(new TakarabakoKi(new Vector2(945.0f, 655.0f), characterControl)); //当たり
            }


//**********************************************************************************************************************

            if (rand.Next(3) == 0)
            {
                characterControl.Add(new Goal(new Vector2(200.0f, 27.0f), characterControl));
            }
            else if (rand.Next(3) == 1)
            {
                characterControl.Add(new Goal(new Vector2(700.0f, 27.0f), characterControl));
            }
            else
            {
                characterControl.Add(new Goal(new Vector2(963.0f, 27.0f), characterControl));
            }
           
            characterControl.Add(new Player(input, characterControl));
            
            kurayami.Update(characterControl.PlayerPosition());

        }
        public void Update()
        {
            characterControl.Update();

            if (characterControl.IsPlayerGoal())
            {
                this.isEnd = true;
            }
            
            if(characterControl.IsPlayerDead())
            {
                this.isEnd2 = true;
            }

            
            kurayami.Update(characterControl.PlayerPosition());
            

            time++;
            if (time ==　3600)
            {
                if (rand.Next(2) == 0)
                {
                    characterControl.Add(new enemy3(new Vector2(0.0f, 768.0f), characterControl));
                }
                else
                {
                    characterControl.Add(new enemy3(new Vector2(1024.0f, 768.0f), characterControl));
                }
            }

        }
        public void Draw(Renderer renderer)
        {
            renderer.DrawTexture("bg", Vector2.Zero);
            characterControl.Draw(renderer);

            kaminari++;
            if (kaminari <= 160 && kaminari % 20 == 0)
            {
                return;
            }
            if(kaminari > 600)
            {
                kaminari = 0;
            }
             kurayami.Draw(renderer);
        }

        public void mSound(Sound sounds)
        {
            sounds.PlayBGM("gameplaybgm");
        }

        public void Shutdown()
        {
            
        }

        public bool IsEnd()
        {
            return this.isEnd;
        }
        public bool IsEnd2()
        { 
            return this.isEnd2;
        }

        public Scene Next()
        {
            return Scene.Gameclear;
        }
        public Scene Next2()
        {
            return Scene.GameOver;
        }
    }
}
