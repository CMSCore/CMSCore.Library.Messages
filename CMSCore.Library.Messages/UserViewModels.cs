namespace CMSCore.Library.Messages
{
    using System;

    #region Read

    public class UserViewModel
    {
        public DateTime Created { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string Id { get; set; }
        public string IdentityUserId { get; set; }
        public string LastName { get; set; }
        public DateTime Modified { get; set; }
    }

    #endregion

    #region Write

    public class CreateUserViewModel
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string IdentityUserId { get; set; }

        public string LastName { get; set; }
    }

    public class UpdateUserViewModel
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class DeleteUserViewModel
    {
        public DeleteUserViewModel(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

        public static DeleteUserViewModel Initialize(string id)
        {
            return new DeleteUserViewModel(id);
        }
    }

    #endregion
}