namespace CMSCore.Library.Messages
{
    using System;

    public class FeedViewModel
    {
        public DateTime Date { get; set; }
        public FeedItemPreviewViewModel [ ] FeedItems { get; set; }
        public string Id { get; set; }
        public DateTime Modified { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
    }
}