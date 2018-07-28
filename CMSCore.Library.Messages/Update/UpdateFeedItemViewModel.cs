namespace CMSCore.Library.Messages.Update
{
    using System.Collections.Generic;

    #region Write

    public class UpdateFeedItemViewModel
    {
        public bool CommentsEnabled { get; set; } = true;

        public string Description { get; set; }

        public string Id { get; set; }

        public IList<string> Tags { get; set; }

        public string Title { get; set; }
    }

    #endregion
}