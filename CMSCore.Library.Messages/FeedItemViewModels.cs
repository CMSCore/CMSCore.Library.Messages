namespace CMSCore.Library.Messages
{
    using System;
    using System.Collections.Generic;

    #region Read

    public class FeedItemViewModel
    {
        public CommentViewModel [ ] Comments { get; set; } = new CommentViewModel[ 1 ];
        public bool CommentsEnabled { get; set; }

        public string Content { get; set; }
        public DateTime Date { get; set; }

        public string Description { get; set; }
        public string FeedId { get; set; }
        public string Id { get; set; }
        public DateTime Modified { get; set; }
        public string NormalizedTitle { get; set; }

        public TagViewModel [ ] Tags { get; set; } = new TagViewModel[ 1 ];

        public string Title { get; set; }
    }

    #endregion

    #region Write

    public class CreateFeedItemViewModel
    {
        public bool CommentsEnabled { get; set; } = true;

        public string Content { get; set; }

        public string Description { get; set; }

        public string FeedId { get; set; }

        public bool IsContentMarkdown { get; set; } = true;

        public IList<string> Tags { get; set; }

        public string Title { get; set; }
    }

    public class UpdateFeedItemViewModel
    {
        public bool CommentsEnabled { get; set; } = true;

        public string Content { get; set; }

        public string Description { get; set; }

        public string Id { get; set; }

        public bool IsContentMarkdown { get; set; } = true;

        public IList<string> Tags { get; set; }

        public string Title { get; set; }
    }

    public class DeleteFeedItemViewModel
    {
        public DeleteFeedItemViewModel(string entityId)
        {
            Id = entityId;
        }

        public string Id { get; set; }

        public static DeleteFeedItemViewModel Initialize(string entityId)
        {
            return new DeleteFeedItemViewModel(entityId);
        }
    }

    #endregion
}