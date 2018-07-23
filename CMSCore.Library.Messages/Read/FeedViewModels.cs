namespace CMSCore.Library.Messages
{
 
    public class UpdateTagViewModel
    {
        public string Id { get; set; }

        public string TagName { get; set; }
    }

 
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