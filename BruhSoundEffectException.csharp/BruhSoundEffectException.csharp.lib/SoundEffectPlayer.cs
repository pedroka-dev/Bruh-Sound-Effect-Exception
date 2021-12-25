using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BruhSoundEffectException.csharp.lib
{
    public class SoundEffectPlayer
    {
        public static void PlaySound()
        {
            string path = @"..\..\..\..\sounds\bruhSoundEffect2.wav";
            using (var soundPlayer = new SoundPlayer(path))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }

    }
}
