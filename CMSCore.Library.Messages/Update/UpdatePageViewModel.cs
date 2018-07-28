namespace CMSCore.Library.Messages.Update
{
    #region Write 

    public class UpdatePageViewModel
    {
        public string Content { get; set; }

        public bool FeedEnabled { get; set; } = true;

        public string Id { get; set; }

        public string Name { get; set; }
    }

    #endregion
}