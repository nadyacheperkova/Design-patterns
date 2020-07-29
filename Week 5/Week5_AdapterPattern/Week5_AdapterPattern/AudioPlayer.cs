using System;
using System.Collections.Generic;
using System.Text;

namespace Week5_AdapterPattern
{
    class AudioPlayer : MediaPlayer
    {
        private MediaPlayerAdapter mediaPlayerAdapter;
        public void Play(string audioType, string fileName)
        {
            if (audioType == "mp3")
            {
                Console.WriteLine("Playing Mp3 file - Name: " + fileName);
            }
            else if ((audioType == "vlc") || (audioType == "mp4"))
            {
                mediaPlayerAdapter = new MediaPlayerAdapter(audioType);
                mediaPlayerAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media " + audioType + " format not supported.");
            }
        }
    }
}
