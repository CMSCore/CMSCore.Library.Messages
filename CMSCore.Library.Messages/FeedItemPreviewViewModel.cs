namespace CMSCore.Library.Messages
{
    using System;
    using System.Collections.Generic;
    using Orleans.Concurrency;

    [Immutable]
    [Serializable]
    public class FeedItemPreviewViewModel
    {
        //public FeedItemPreviewViewModel(string id, string title, string normalizedTitle, string description, DateTime created, DateTime modified, TagViewModel [ ] tags)
        //{
        //    Id = id;
        //    Title = title;
        //    NormalizedTitle = normalizedTitle;
        //    Description = description;
        //    Created = created;
        //    Modified = modified;
        //    Tags = tags;
        //}

        //public FeedItemPreviewViewModel()
        //{
        //}

        public string Id { get; set; }
        public string Title { get; set; }
        public string NormalizedTitle { get; set; }
        public string Description { get; set; }

        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public List<TagViewModel> Tags { get; set; }
    }
}