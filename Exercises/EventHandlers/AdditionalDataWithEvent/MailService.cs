using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers.AdditionalDataWithEvent
{
    public class MailService
    {
        public void OnVideoEncoded(object obj, VideoEventArgs args)
        {
            Console.WriteLine("Mail Service... Sending an email"+args.Video.Title);
        }
    }
}
