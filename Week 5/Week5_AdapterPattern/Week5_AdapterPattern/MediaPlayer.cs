using System;
using System.Collections.Generic;
using System.Text;

namespace Week5_AdapterPattern
{
    interface MediaPlayer
    {
        void Play(string audioType, string fileName);
    }
}
