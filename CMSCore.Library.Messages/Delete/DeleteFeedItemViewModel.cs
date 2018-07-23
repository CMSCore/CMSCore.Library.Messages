namespace CMSCore.Library.Messages
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