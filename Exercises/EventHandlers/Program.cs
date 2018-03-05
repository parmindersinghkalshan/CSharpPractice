using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EventHandlers.AdditionalDataWithEvent;
namespace EventHandlers
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoke = new Invoke();
            invoke.Run();
            //var video = new VideoExtended() { Title = "Video 1" };

            //var videoEncoder = new VideoEncoder(); //Publisher

            //var mailService = new MailServiceExtended(); //Subscriber

            ////Register method to a delegate or do subscription
            //videoEncoder.VideoEncoded += mailService.OnVideoEncode;

            //videoEncoder.Encode(video);
        }
    }
}
