namespace CMSCore.Library.Messages
{
    using System;

    public class CommentViewModel
    {
        public string CommentId { get; set; }
        public DateTime Date { get; set; }
        public string FullName { get; set; }
        public string Text { get; set; }
    }

    public class CreateCommentViewModel
    {
        public string FeedItemId { get; set; }

        public string FullName { get; set; }

        public string Text { get; set; }
    }
}