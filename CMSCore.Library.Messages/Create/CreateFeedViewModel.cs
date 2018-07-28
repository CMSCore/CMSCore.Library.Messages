namespace CMSCore.Library.Messages.Read
{
    using System;

    [Serializable]
    public class CreateFeedViewModel
    {
        public string Name { get; set; }
        public string PageId { get; set; }
    }
}