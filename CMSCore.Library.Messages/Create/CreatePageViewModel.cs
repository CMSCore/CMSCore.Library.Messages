﻿namespace CMSCore.Library.Messages
{


    public class CreatePageViewModel
    {
        public string Content { get; set; }

        public bool FeedEnabled { get; set; } = true;

        public string Name { get; set; }

        public string FeedName { get; set; }
    }

}