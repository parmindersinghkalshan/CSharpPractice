using System;

namespace EventHandlers
{
    public class MailServiceExtended
    {
        //Event Handler
        //Should have same signature as delegate
        public void OnVideoEncode(object source, EventArgs args)
        {
            Console.WriteLine("MailService: Sending an email...!");
        }
    }
}
