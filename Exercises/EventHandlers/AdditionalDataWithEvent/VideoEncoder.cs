using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventHandlers.AdditionalDataWithEvent
{
    public class VideoEncoder
    {
        public delegate void VideoEncodedNewDelegate(object source, VideoEventArgs args);

        public event VideoEncodedNewDelegate VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video!");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
