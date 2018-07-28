namespace CMSCore.Library.Messages
{
    using System;
    using Orleans.Concurrency;

    [Immutable]
    [Serializable]
    public class FeedViewModel
    { 
        public FeedViewModel(string id, string name, string normalizedName, DateTime date, DateTime modified, FeedItemPreviewViewModel [ ]feedItems)
        {
            Id = id;
            Name = name;
            NormalizedName = normalizedName;
            Date = date;
            Modified = modified;
            FeedItems = feedItems;
        }

        public DateTime Date { get; }

        public FeedItemPreviewViewModel [ ]FeedItems { get; }
        public string Id { get; }
        public DateTime Modified { get; }
        public string Name { get; }
        public string NormalizedName { get; }
    }
}