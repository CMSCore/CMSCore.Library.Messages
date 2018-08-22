namespace CMSCore.Library.Messages.Create
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateFeedItemViewModel
    {
        public bool CommentsEnabled { get; set; } = true;

        [Required]
        public string Content { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string FeedId { get; set; }

        public bool IsContentMarkdown { get; set; } = true;

        public IList<string> Tags { get; set; }

        [Required]
        public string Title { get; set; }
    }

 }