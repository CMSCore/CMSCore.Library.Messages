namespace CMSCore.Library.Messages
{
    using System;
 
    public class PageViewModel
    {
        public ContentViewModel Content { get; set; }
        public DateTime Date { get; set; }

        public FeedViewModel Feed { get; set; }
        public string Id { get; set; }
        public DateTime Modified { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
    }

    public class ContentViewModel
    {
        public string ContentId { get; set; }
        public string VersionId { get; set; }
        public int VersionNumber { get; set; }
        public string Value { get; set; }
    }

 }