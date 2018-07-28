namespace CMSCore.Library.Messages
{
    using System;
    using Orleans.Concurrency;

    [Immutable]
    [Serializable]
    public class UserViewModel
    {
        public UserViewModel(DateTime created, string email, string firstName, string id, string identityUserId, string lastName, DateTime modified)
        {
            Created = created;
            Email = email;
            FirstName = firstName;
            Id = id;
            IdentityUserId = identityUserId;
            LastName = lastName;
            Modified = modified;
        }

        public DateTime Created { get;  }
        public string Email { get;  }

        public string FirstName { get;  }
        public string Id { get;  }
        public string IdentityUserId { get;  }
        public string LastName { get;  }
        public DateTime Modified { get;  }
    }

 }