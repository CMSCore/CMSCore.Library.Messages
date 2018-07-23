namespace CMSCore.Library.Messages
{

    public class DeleteUserViewModel
    {
        public DeleteUserViewModel(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

        public static DeleteUserViewModel Initialize(string id)
        {
            return new DeleteUserViewModel(id);
        }
    }

 }