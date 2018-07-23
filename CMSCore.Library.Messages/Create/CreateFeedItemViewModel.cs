namespace CMSCore.Library.Messages
{
    using System.Collections.Generic;
 
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

 }