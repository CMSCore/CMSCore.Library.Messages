namespace CMSCore.Library.Messages
{
    using System;

    #region Read

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


    public class FeedViewModel
    {
        public DateTime Date { get; set; }
        public FeedItemPreviewViewModel [ ] FeedItems { get; set; }
        public string Id { get; set; }
        public DateTime Modified { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
    }

    public class UpdateTagViewModel
    {
        public string Id { get; set; }

        public string TagName { get; set; }
    }

    #endregion

    #region Write

    public class CreateFeedViewModel
    {
        public string Name { get; set; }
        public string PageId { get; set; }
    }

    public class UpdateFeedViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }


    public class DeleteFeedViewModel
    {
        public DeleteFeedViewModel(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

        public static DeleteFeedViewModel Initialize(string entityId)
        {
            return new DeleteFeedViewModel(entityId);
        }
    }

    #endregion
}