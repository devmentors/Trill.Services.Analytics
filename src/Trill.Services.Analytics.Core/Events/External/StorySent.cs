using System;
using System.Collections.Generic;
using Convey.CQRS.Events;
using Convey.MessageBrokers;

namespace Trill.Services.Analytics.Core.Events.External
{
    [Message("stories")]
    public class StorySent : IEvent
    {
        public long StoryId { get; }
        public AuthorModel Author { get; }
        public string Title { get; }
        public IEnumerable<string> Tags { get; }
        public DateTime CreatedAt { get; }

        public StorySent(long storyId, AuthorModel author, string title, IEnumerable<string> tags,
            DateTime createdAt)
        {
            StoryId = storyId;
            Author = author;
            Title = title;
            Tags = tags;
            CreatedAt = createdAt;
        }

        public class AuthorModel
        {
            public Guid Id { get; }
            public string Name { get; }

            public AuthorModel(Guid id, string name)
            {
                Id = id;
                Name = name;
            }
        }
    }
}