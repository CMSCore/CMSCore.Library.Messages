namespace CMSCore.Library.Messages.Create
{
    using System.ComponentModel.DataAnnotations;

    public class CreateCommentViewModel
    {
        [Required]
        public string FeedItemId { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Text { get; set; }
    }
}