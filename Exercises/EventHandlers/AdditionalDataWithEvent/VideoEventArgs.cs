using System;

namespace EventHandlers.AdditionalDataWithEvent
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}