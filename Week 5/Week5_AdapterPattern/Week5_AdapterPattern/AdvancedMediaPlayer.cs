using System;
using System.Collections.Generic;
using System.Text;

namespace Week5_AdapterPattern
{
    interface AdvancedMediaPlayer
    {
        void PlayVlc(string fileName);
        void PlayMp4(string fileName);
    }
}
