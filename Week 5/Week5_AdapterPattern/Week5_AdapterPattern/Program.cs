using System;

namespace Week5_AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer audioPlayer = new AudioPlayer();

            audioPlayer.Play("mp3", "Let Me Love You.mp3");
            audioPlayer.Play("vlc", "Come Thru.vlc");
            audioPlayer.Play("mp4", "Far Far Away.mp4");
            audioPlayer.Play("avi", "Mind.avi");

            Console.ReadLine();
        }
    }
}
