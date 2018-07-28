namespace CMSCore.Library.Messages.Delete
{
    public class DeletePageViewModel
    {
        public DeletePageViewModel(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

        public static DeletePageViewModel Initialize(string id)
        {
            return new DeletePageViewModel(id);
        }
    }

}