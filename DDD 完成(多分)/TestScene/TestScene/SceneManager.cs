using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDD
{
    class SceneManager
    {
        private Dictionary<Scene, IScene> scenes = new Dictionary<Scene, IScene>();
        private IScene currentScene = null;

        public SceneManager() { }
        public void Add(Scene name, IScene scene)
        {
            this.scenes[name] = scene;
        }
        public void Change(Scene name)
        {
            if (this.currentScene != null)
            {
                this.currentScene.Shutdown();
            }
            this.currentScene = this.scenes[name];
            this.currentScene.Initialize();
        }
        public void Update()
        {
            if (this.currentScene == null)
            {
                return;
            }
            this.currentScene.Update();
            if (this.currentScene.IsEnd2())
            {
                this.Change(this.currentScene.Next2());         //下と入れ替えると機能しない
            }
            if (this.currentScene.IsEnd())
            {
                this.Change(this.currentScene.Next());
            }
            
        }
        public void Draw(Renderer renderer)
        {
            if (this.currentScene == null)
            {
                return;
            }
            this.currentScene.Draw(renderer);
        }
        public void mSound(Sound sounds)
        {
            if (this.currentScene == null)
            {
                return;
            }
            this.currentScene.mSound(sounds);
        }
    }
}
