using System;
using System.Collections.Generic;
using System.Text;

namespace Week5_AdapterPattern
{
    class MediaPlayerAdapter : MediaPlayer
    {
        private AdvancedMediaPlayer advancedMediaPlayer;

        public MediaPlayerAdapter(string audioType)
        {
            if (audioType == "vlc")
            {
                advancedMediaPlayer = new VlcPlayer();
            }
            else if (audioType == "mp4")
            {
                advancedMediaPlayer = new Mp4Player();
            }
        }
        public void Play(string audioType, string fileName)
        {
            if (audioType == "vlc")
            {
                advancedMediaPlayer.PlayVlc(fileName);
            }
            else if (audioType == "mp4")
            {
                advancedMediaPlayer.PlayMp4(fileName);
            }
        }
    }
}
