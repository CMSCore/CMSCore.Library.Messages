namespace CMSCore.Library.Messages
{
    using System;
 
    public class FeedItemViewModel
    {
        public CommentViewModel [ ] Comments { get; set; } = new CommentViewModel[ 1 ];
        public bool CommentsEnabled { get; set; }

        public ContentViewModel Content { get; set; }
        public DateTime Date { get; set; }

        public string Description { get; set; }
        public string FeedId { get; set; }
        public string Id { get; set; }
        public DateTime Modified { get; set; }
        public string NormalizedTitle { get; set; }

        public TagViewModel [ ] Tags { get; set; } = new TagViewModel[ 1 ];

        public string Title { get; set; }
    }

 }