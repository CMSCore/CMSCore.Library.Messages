namespace CMSCore.Library.Messages
{
    using System;
    using Orleans.Concurrency;

    [Immutable]
    [Serializable]
    public class ContentViewModel
    {
        public ContentViewModel(string contentId, string versionId, int versionNumber, string value)
        {
            ContentId = contentId;
            VersionId = versionId;
            VersionNumber = versionNumber;
            Value = value;
        }

        public string ContentId { get;  }
        public string VersionId { get;  }
        public int VersionNumber { get;  }
        public string Value { get;  }
    }
}