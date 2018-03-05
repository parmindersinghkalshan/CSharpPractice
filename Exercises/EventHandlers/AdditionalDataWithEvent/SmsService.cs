using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers.AdditionalDataWithEvent
{
    public class SmsService
    {
        public void OnVideoEncode(object source, VideoEventArgs args)
        {
            Console.WriteLine("SMS Service... Sending SMS"+args.Video.Title);
        }
    }
}
