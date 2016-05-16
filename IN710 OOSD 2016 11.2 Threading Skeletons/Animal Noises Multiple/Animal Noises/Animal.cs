using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace Animal_Noises
{
    public class Animal
    {
        private SoundPlayer soundPlayer;
        private Form1 sharedData;

        public Animal(String soundFileName, Form1 sharedData)
        {
            soundPlayer = new SoundPlayer(soundFileName);
            this.sharedData = sharedData;
        }

        public void speak()
        {
            while (true)
            {
                lock (sharedData)
                {
                    soundPlayer.Play();
                    Thread.Sleep(500);
                }
            }
        }

    }
}
