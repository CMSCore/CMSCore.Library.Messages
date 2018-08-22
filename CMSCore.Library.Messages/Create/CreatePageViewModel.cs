namespace CMSCore.Library.Messages.Create
{
    using System.ComponentModel.DataAnnotations;


    public class CreatePageViewModel
    {
        [Required]
        public string Content { get; set; }

         public bool FeedEnabled { get; set; } = true;

        [Required]
        public string Name { get; set; }

        [Required]
        public string FeedName { get; set; }
    }

}