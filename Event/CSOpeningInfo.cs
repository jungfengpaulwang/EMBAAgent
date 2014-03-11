using System;

namespace Agent.Event
{
    /// <summary>
    /// 選課開放時間更新通知
    /// </summary>
    public class CSOpeningInfo 
    {
        public static void RaiseAfterUpdateEvent(object sender, EventArgs e)
        {
            if (CSOpeningInfo.AfterUpdate != null)
                CSOpeningInfo.AfterUpdate(sender, e);
        }

        public static event EventHandler<EventArgs> AfterUpdate;
    }
}