using System;
using System.Collections.Generic;
using System.Text;

namespace Week5_AdapterPattern
{
    class VlcPlayer : AdvancedMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Playing Vlc file - Name: " + fileName);
        }

        public void PlayMp4(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
