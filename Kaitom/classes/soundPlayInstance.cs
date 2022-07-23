using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Kaitom.classes
{
    internal class soundPlayInstance
    {
        MediaPlayer mPlay = new MediaPlayer();
        bool mPlaying = false;

        public soundPlayInstance()
        {
            mPlay.MediaEnded += (s, e) =>
            {
                mPlaying = false;
                mPlay.Close();
            };
        }

        public void PlaySound(string File,int volume)
        {
            if (!mPlaying)
            {
                mPlay.Open(new Uri(File));
                mPlay.Volume = (double)volume;
                mPlay.Play();
                mPlaying = true;
                Console.WriteLine($"{File} is played {mPlay.Volume}% {volume}");

            }
            else
            {
                return;
            }
        }
        public void StopAllSound()
        {
            if (mPlaying)
            {
                mPlay.Stop();
            }
        }
    }
}
