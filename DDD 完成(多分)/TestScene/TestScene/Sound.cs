﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Media;

namespace DDD
{
    class Sound
    {
        private ContentManager contentManager;
        private Dictionary<string, Song> bgms = new Dictionary<string, Song>();
        private Dictionary<string, SoundEffect> SEs = new Dictionary<string, SoundEffect>();
        private Dictionary<string, SoundEffectInstance> SEInstances =
            new Dictionary<string, SoundEffectInstance>();

        public Sound(ContentManager content)
        {
            contentManager = content;
            contentManager.RootDirectory = "Content";
            MediaPlayer.IsRepeating = true;
        }

        public void LoadBGM(string name)
        {
            bgms[name] = contentManager.Load<Song>(name);
        }

        public bool IsStopBGM()
        {
            return MediaPlayer.State != MediaState.Playing;
        }

        public void PlayBGM(string name)
        {
            if (IsStopBGM())
            {
                MediaPlayer.Play(bgms[name]);
            }
        }

        public void StopBGM()
        {
            MediaPlayer.Stop();
        }

        public void SetBGMLoopPlay(bool loopFlag)
        {
            MediaPlayer.IsRepeating = loopFlag;
        }

        public void LoadSE(string name)
        {
            SEs[name] = contentManager.Load<SoundEffect>(name);
        }

        public void PlaySE(string name)
        {
            SEs[name].Play();
        }

        public void CreateInstance(string name, bool loopFlag = false)
        {
            SEInstances[name] = SEs[name].CreateInstance();
            SEInstances[name].IsLooped = loopFlag;
        }


        public bool IsStopSE(string name)
        {
            return SEInstances[name].State != SoundState.Playing;
        }

        public void PlayInstanceSE(string name)
        {
            if (!SEInstances.ContainsKey(name))
            {
                return;
            }

            if (IsStopSE(name))
            {
                SEInstances[name].Play();
            }
        }

        public void StopSE(string name)
        {
            SEInstances[name].Stop();
        }

        public void SetSELoopPlay(string name, bool loopFlag)
        {
            SEInstances[name].IsLooped = loopFlag;
        }
        public void Unload()
        {
            bgms.Clear();
            SEs.Clear();
            SEInstances.Clear();
            contentManager.Unload();
        }

    }
}
