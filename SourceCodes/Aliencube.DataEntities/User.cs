using System;
using System.Collections.Generic;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the entity of a user.
    /// </summary>
    public partial class User
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique Id representing a user.
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

        #endregion Properties

        #region Relations

        /// <summary>
        /// Gets or sets the user instance that has created this.
        /// </summary>
        public virtual User CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the user instance that has updated this.
        /// </summary>
        public virtual User UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the user instance that has verified this.
        /// </summary>
        public virtual User VerifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the list of page schema instances.
        /// </summary>
        public virtual ICollection<PageSchema> PageSchemata { get; set; }

        /// <summary>
        /// Gets or sets the list of element group instances.
        /// </summary>
        public virtual ICollection<ElementGroup> ElementGroups { get; set; }

        /// <summary>
        /// Gets or sets the list of element schema instances.
        /// </summary>
        public virtual ICollection<ElementSchema> ElementSchemata { get; set; }

        /// <summary>
        /// Gets or sets the list of page schema instances.
        /// </summary>
        public virtual ICollection<ElementDataType> ElementDataTypes { get; set; }

        /// <summary>
        /// Gets or sets the list of page schema instances.
        /// </summary>
        public virtual ICollection<PredefinedElementDataValue> PredefinedElementDataValues { get; set; }

        /// <summary>
        /// Gets or sets the list of page version instances.
        /// </summary>
        public virtual ICollection<PageVersion> PageVersions { get; set; }

        /// <summary>
        /// Gets or sets the list of page URL instances.
        /// </summary>
        public virtual ICollection<PageUrl> PageUrls { get; set; }

        /// <summary>
        /// Gets or sets the list of user instances.
        /// </summary>
        public virtual ICollection<User> Users { get; set; }

        /// <summary>
        /// Gets or sets the list of group instances.
        /// </summary>
        public virtual ICollection<Group> Groups { get; set; }

        /// <summary>
        /// Gets or sets the list of role instances.
        /// </summary>
        public virtual ICollection<Role> Roles { get; set; }

        /// <summary>
        /// Gets or sets the list of user-group instances.
        /// </summary>
        public virtual ICollection<UserGroup> UserGroups { get; set; }

        /// <summary>
        /// Gets or sets the list of user-role instances.
        /// </summary>
        public virtual ICollection<UserRole> UserRoles { get; set; }

        /// <summary>
        /// Gets or sets the list of group-role instances.
        /// </summary>
        public virtual ICollection<GroupRole> GroupRoles { get; set; }

        #endregion Relations
    }
}