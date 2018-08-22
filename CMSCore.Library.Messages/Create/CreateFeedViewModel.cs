namespace CMSCore.Library.Messages.Read
{
    using System;
    using System.ComponentModel.DataAnnotations;

    [Serializable]
    public class CreateFeedViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string PageId { get; set; }
    }
}