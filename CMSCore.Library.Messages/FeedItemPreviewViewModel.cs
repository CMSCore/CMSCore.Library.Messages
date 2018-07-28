namespace CMSCore.Library.Messages
{
    using System;
    using Orleans.Concurrency;

    [Immutable]
    [Serializable]
    public class FeedItemPreviewViewModel
    {
        public FeedItemPreviewViewModel(string id, string title, string normalizedTitle, string description, DateTime created, DateTime modified, TagViewModel[] tags)
        {
            Id = id;
            Title = title;
            NormalizedTitle = normalizedTitle;
            Description = description;
            Created = created;
            Modified = modified;
            Tags = tags;
        }

        public string Id { get;  }
        public string Title { get;  }
        public string NormalizedTitle { get;  }
        public string Description { get;  }

        public DateTime Created { get;  }
        public DateTime Modified { get;  }

        public TagViewModel [ ] Tags { get;  }
    }
}