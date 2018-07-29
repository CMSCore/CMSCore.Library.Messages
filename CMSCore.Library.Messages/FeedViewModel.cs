namespace CMSCore.Library.Messages
{
    using System;
    using System.Collections.Generic;
    using Orleans.Concurrency;

    [Immutable]
    [Serializable]
    public class FeedViewModel
    { 
        //public FeedViewModel(string id, string name, string normalizedName, DateTime date, DateTime modified, FeedItemPreviewViewModel [ ]feedItems)
        //{
        //    Id = id;
        //    Name = name;
        //    NormalizedName = normalizedName;
        //    Date = date;
        //    Modified = modified;
        //    FeedItems = feedItems;
        //}
 
        public DateTime Date { get; set; }

        public List<FeedItemPreviewViewModel>FeedItems { get; set; }
        public string Id { get; set; }
        public DateTime Modified { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
    }
}