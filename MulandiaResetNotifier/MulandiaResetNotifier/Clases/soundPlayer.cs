using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MulandiaResetNotifier.Clases
{
    

    public class soundPlayer
    {
        private MediaPlayer notification;
        private string resourcePath;

        public soundPlayer(string wavPath)
        {
            notification = new MediaPlayer();
            resourcePath = "Resources/" + wavPath;
            notification.Open(new Uri(resourcePath, UriKind.Relative));
        }

        public void setVolume(int _volume)
        {
            notification.Volume = _volume / 100.0f;
        }

        public void play()
        {
            notification.Play();
        }
    }
}
