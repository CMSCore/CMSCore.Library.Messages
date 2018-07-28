namespace CMSCore.Library.Messages.Delete
{

    public class DeleteFeedItemViewModel
    {
        public DeleteFeedItemViewModel(string entityId)
        {
            Id = entityId;
        }

        public string Id { get; set; }

        public static DeleteFeedItemViewModel Initialize(string entityId)
        {
            return new DeleteFeedItemViewModel(entityId);
        }
    }

 }