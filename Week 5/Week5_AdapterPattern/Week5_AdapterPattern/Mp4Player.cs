using System;
using System.Collections.Generic;
using System.Text;

namespace Week5_AdapterPattern
{
    class Mp4Player : AdvancedMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            throw new NotImplementedException();
        }

        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing Mp4 file - Name: " + fileName);
        }
    }
}
