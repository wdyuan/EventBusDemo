﻿using System;

namespace EventTest
{
    public class FishingEventHandler : IEventHandler<FishingEventData>
    {
        public void HandleEvent(FishingEventData eventData)
        {
            eventData.FishingMan.FishCount++;

            Console.WriteLine("{0}：钓到一条[{2}]，已经钓到{1}条鱼了！", eventData.FishingMan.Name, eventData.FishingMan.FishCount, eventData.FishType);
        }
    }
}
