using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers.AdditionalDataWithEvent
{
    public class Invoke
    {
        public void Run()
        {
            var video = new Video()
            {
                Title = "Title1"
            };

            var videoEncoder = new VideoEncoder(); //publisher

            var mailService = new MailService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += new SmsService().OnVideoEncode;

            videoEncoder.Encode(video);
            Console.ReadLine();
        }
    }
}
