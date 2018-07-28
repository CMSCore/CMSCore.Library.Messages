namespace CMSCore.Library.Messages
{
    using System;
    using Orleans.Concurrency;

    [Immutable]
    [Serializable]
    public class CommentViewModel
    {
        public CommentViewModel(string commentId, DateTime created, string fullName, string text)
        {
            CommentId = commentId;
            Created = created;
            FullName = fullName;
            Text = text;
        }

        public string CommentId { get; }
        public DateTime Created { get; }
        public string FullName { get; }
        public string Text { get; }
    }
}