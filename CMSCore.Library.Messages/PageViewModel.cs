namespace CMSCore.Library.Messages
{
    using System;
    using Orleans.Concurrency;

    [Immutable]
    [Serializable]
    public class PageViewModel
    {
        public PageViewModel(string id, string name, string normalizedName, DateTime created, DateTime modified, ContentViewModel content, FeedViewModel feed)
        {
            Id = id;
            Name = name;
            NormalizedName = normalizedName;
            Created = created;
            Modified = modified;
            Content = content;
            Feed = feed;
        }

        public string Id { get;  }
        public string Name { get;  }
        public string NormalizedName { get;  }

        public DateTime Created { get;  }
        public DateTime Modified { get;  }

        public ContentViewModel Content { get;  }
        public FeedViewModel Feed { get;  }
    }
}