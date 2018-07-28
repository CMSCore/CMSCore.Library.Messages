namespace CMSCore.Library.Messages.Create
{
    using System.Collections.Generic;

    public class CreateTagsViewModel
    {
        public string FeedItemId { get; set; }

        public IList<string> Tags { get; set; }
    }
}