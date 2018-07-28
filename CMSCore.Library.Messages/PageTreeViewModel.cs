namespace CMSCore.Library.Messages
{
    using System;
    using Orleans.Concurrency;

    [Immutable]
    [Serializable]
    public class PageTreeViewModel
    {
        public PageTreeViewModel(DateTime date, string id, string name, string normalizedName)
        {
            Date = date;
            Id = id;
            Name = name;
            NormalizedName = normalizedName;
        }

        public DateTime Date { get;  }
        public string Id { get;  }

        public string Name { get;  }
        public string NormalizedName { get;  }
    }

 }