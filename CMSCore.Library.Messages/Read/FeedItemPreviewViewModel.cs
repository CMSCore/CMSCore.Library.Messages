namespace CMSCore.Library.Messages
{
    using System;

    public class FeedItemPreviewViewModel
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public DateTime Modified { get; set; }
        public string NormalizedTitle { get; set; }

        public TagViewModel [ ] Tags { get; set; }

        public string Title { get; set; }
    }
}