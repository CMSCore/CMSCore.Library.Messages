namespace CMSCore.Library.Messages.Read
{
    using System;
    using Orleans.Concurrency;

    [Serializable]
    [Immutable]
    public class FeedItemViewModel
    {
        public FeedItemViewModel(string id, string title, string normalizedTitle, bool commentsEnabled, string description, string feedId, DateTime created, DateTime modified,
            CommentViewModel [ ] comments, ContentViewModel content, TagViewModel [ ] tags)
        {
            Id = id;
            Title = title;
            NormalizedTitle = normalizedTitle;
            CommentsEnabled = commentsEnabled;
            Description = description;
            FeedId = feedId;
            Created = created;
            Modified = modified;
            Comments = comments;
            Content = content;
            Tags = tags;
        }

        public string Id { get;  }
        public string Title { get;  }
        public string NormalizedTitle { get;  }

        public bool CommentsEnabled { get;  }

        public string Description { get;  }
        public string FeedId { get;  }
        public DateTime Created { get;  }
        public DateTime Modified { get;  }


        public CommentViewModel [ ] Comments { get;  }

        public ContentViewModel Content { get;  }
        public TagViewModel [ ] Tags { get;  }
    }
}