using System;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the entity of a user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the date when the user is created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the user ID that has created the user.
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the user is updated.
        /// </summary>
        public DateTime DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the user ID that has updated the user.
        /// </summary>
        public int UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the value that speficies whether the user has been verified or not.
        /// </summary>
        public bool IsVerified { get; set; }

        /// <summary>
        /// Gets or sets the date when the user is verified.
        /// </summary>
        public DateTime? DateVerified { get; set; }

        /// <summary>
        /// Gets or sets the user ID that has verified the user.
        /// </summary>
        public int? VerifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether the user is suspended or not.
        /// </summary>
        public bool IsSuspended { get; set; }

        /// <summary>
        /// Gets or sets the data when the user is suspended.
        /// </summary>
        public DateTime? DateSuspended { get; set; }

        /// <summary>
        /// Gets or sets the user ID that has suspended the user.
        /// </summary>
        public int? SuspendedBy { get; set; }
    }
}