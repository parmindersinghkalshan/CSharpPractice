using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventHandlers
{
    // publisher class
    public class VideoEncoder
    {
        //1-Define a delegate
        //2-Define an event based on the delegate
        //3-Raise the event

            // 1-Delegate
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        //2-Define an event based on the delegate
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(VideoExtended video)
        {
            Console.WriteLine("Encoding Video ....");
            Thread.Sleep(3000);

            //Raise an Event
            OnVideoEncode();
        }

        //Rules for event raised method
        // a. Should be protected, virtal and return type should be void
        // b. naming convention starts with "On"+"name of the event"
        protected virtual void OnVideoEncode()
        {
            //check if event has subscribers
            if(VideoEncoded != null) //this will hold list of pointers to methods with same signature as delegate
            {
                //Make a call
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
