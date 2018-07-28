namespace CMSCore.Library.Messages
{
    using System;
    using Orleans.Concurrency;

    [Immutable]
    [Serializable]
    public class TagViewModel
    {
        public TagViewModel(string id, string name, string normalizedName)
        {
            Id = id;
            Name = name;
            NormalizedName = normalizedName;
        }

        public string Id { get;  }
        public string Name { get;  }
        public string NormalizedName { get;  }
    }
}