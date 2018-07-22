namespace CMSCore.Library.Messages
{
    using System;

    #region Read

    public class PageViewModel
    {
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public FeedViewModel Feed { get; set; }
        public string Id { get; set; }
        public DateTime Modified { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
    }


    public class PageTreeViewModel
    {
        public DateTime Date { get; set; }
        public string Id { get; set; }

        public string Name { get; set; }
        public string NormalizedName { get; set; }
    }

    #endregion

    #region Write 

    public class UpdatePageViewModel
    {
        public string Content { get; set; }

        public bool FeedEnabled { get; set; } = true;

        public string Id { get; set; }

        public string Name { get; set; }
    }

    public class CreatePageViewModel
    {
        public string Content { get; set; }

        public bool FeedEnabled { get; set; } = true;

        public string Name { get; set; }
    }

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

    #endregion
}