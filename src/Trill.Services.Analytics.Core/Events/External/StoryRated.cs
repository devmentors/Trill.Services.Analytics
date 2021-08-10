using System;
using Convey.CQRS.Events;
using Convey.MessageBrokers;

namespace Trill.Services.Analytics.Core.Events.External
{
    [Message("stories")]
    public class StoryRated : IEvent
    {
        public long StoryId { get; }
        public Guid UserId { get; }
        public int Rate { get; }
        public int TotalRate { get; }

        public StoryRated(long storyId, Guid userId, int rate, int totalRate)
        {
            StoryId = storyId;
            UserId = userId;
            Rate = rate;
            TotalRate = totalRate;
        }
    }
}