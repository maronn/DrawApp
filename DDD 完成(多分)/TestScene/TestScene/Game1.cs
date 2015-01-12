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

    /// <summary>
    /// 基底 Game クラスから派生した、ゲームのメイン クラスです。
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager graphicsDeviceManager;
        private Renderer renderer;
        private InputState input;

        private Sound sounds;

        private SceneManager sceneManager;

        public Game1()
        {
            graphicsDeviceManager = new GraphicsDeviceManager(this);
            graphicsDeviceManager.PreferredBackBufferWidth = Screen.Width;
            graphicsDeviceManager.PreferredBackBufferHeight = Screen.Height;
        }

        /// <summary>
        /// ゲームの開始前に実行する必要がある初期化を実行できるようにします。
        /// ここで、要求されたサービスを問い合わせて、非グラフィック関連のコンテンツを読み込むことができます。
        /// base.Initialize を呼び出すと、任意のコンポーネントが列挙され、
        /// 初期化もされます。
        /// </summary>
        protected override void Initialize()
        {
            // TODO: ここに初期化ロジックを追加します。
            renderer = new Renderer(Content, GraphicsDevice);
            input = new InputState();
            sounds = new Sound(Content);

            sceneManager = new SceneManager();
            sceneManager.Add(Scene.Title, new Title(input));
            sceneManager.Add(Scene.GamePlay, new GamePlay(input));
            sceneManager.Add(Scene.GameOver, new GameOver(input));
            sceneManager.Add(Scene.Gameclear, new Gameclear(input));
            sceneManager.Add(Scene.Stafflol, new Stafflol(input));
            sceneManager.Change(Scene.Title);

            base.Window.Title = "DDD";
            base.Initialize();
        }

        /// <summary>
        /// LoadContent はゲームごとに 1 回呼び出され、ここですべてのコンテンツを
        /// 読み込みます。
        /// </summary>
        protected override void LoadContent()
        {
            // 新規の SpriteBatch を作成します。これはテクスチャーの描画に使用できます。


            // TODO: this.Content クラスを使用して、ゲームのコンテンツを読み込みます。
            renderer.LoadTexture("title");
            renderer.LoadTexture("gameover");
            renderer.LoadTexture("gameclear");
            renderer.LoadTexture("player");
            renderer.LoadTexture("takarabako");
            renderer.LoadTexture("takarabakoaku");
            renderer.LoadTexture("bg");
            renderer.LoadTexture("goal");
            renderer.LoadTexture("enemy1");
            renderer.LoadTexture("enemy2");
            renderer.LoadTexture("enemy3");
            renderer.LoadTexture("kurayami");
            renderer.LoadTexture("ものすごく苦労したピアノ");
            renderer.LoadTexture("isu");
            renderer.LoadTexture("isu2");
            renderer.LoadTexture("tukue");
            renderer.LoadTexture("tukue2");
            renderer.LoadTexture("tubo");
            renderer.LoadTexture("hako");
            renderer.LoadTexture("takarabakoki");
            renderer.LoadTexture("stafflol");

            sounds.LoadBGM("gameplaybgm");

            //sounds.LoadSE("gameoverse");
            
        }

        /// <summary>
        /// UnloadContent はゲームごとに 1 回呼び出され、ここですべてのコンテンツを
        /// アンロードします。
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: ここで ContentManager 以外のすべてのコンテンツをアンロードします。
            this.renderer.Unload();
            this.sounds.Unload();
        }

        /// <summary>
        /// ワールドの更新、衝突判定、入力値の取得、オーディオの再生などの
        /// ゲーム ロジックを、実行します。
        /// </summary>
        /// <param name="gameTime">ゲームの瞬間的なタイミング情報</param>
        protected override void Update(GameTime gameTime)
        {
            // ゲームの終了条件をチェックします。
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();

            // TODO: ここにゲームのアップデート ロジックを追加します。
            input.Update();
            sceneManager.Update();



            sceneManager.mSound(this.sounds);//ｺｺｼﾞｬﾅｲ

            
            

            base.Update(gameTime);
        }

        /// <summary>
        /// ゲームが自身を描画するためのメソッドです。
        /// </summary>
        /// <param name="gameTime">ゲームの瞬間的なタイミング情報</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: ここに描画コードを追加します。
            this.renderer.Begin();
            sceneManager.Draw(this.renderer);
            this.renderer.End();

            base.Draw(gameTime);
        }


    }
}
