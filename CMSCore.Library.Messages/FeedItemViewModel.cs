namespace CMSCore.Library.Messages.Read
{
    using System;
    using System.Collections.Generic;
    using Orleans.Concurrency;

    [Serializable]
    [Immutable]
    public class FeedItemViewModel
    {
        //public FeedItemViewModel(string id, string title, string normalizedTitle, bool commentsEnabled, string description, string feedId, DateTime created, DateTime modified,
        //    CommentViewModel [ ] comments, ContentViewModel content, TagViewModel [ ] tags)
        //{
        //    Id = id;
        //    Title = title;
        //    NormalizedTitle = normalizedTitle;
        //    CommentsEnabled = commentsEnabled;
        //    Description = description;
        //    FeedId = feedId;
        //    Created = created;
        //    Modified = modified;
        //    Comments = comments;
        //    Content = content;
        //    Tags = tags;
        //}

        public string Id { get; set; }
        public string Title { get; set; }
        public string NormalizedTitle { get; set; }

        public bool CommentsEnabled { get; set; }

        public string Description { get; set; }
        public string FeedId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }


        public List<CommentViewModel> Comments { get; set; }

        public ContentViewModel Content { get; set; }
        public List<TagViewModel> Tags { get; set; }
    }
}