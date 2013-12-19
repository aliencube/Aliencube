using System;
using System.Collections.Generic;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the entity of a role for a user.
    /// </summary>
    public partial class Role
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique Id representing a role.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the name to be displayed.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the name when to generate a strongly typed object as a property.
        /// </summary>
        public string StronglyTypedName { get; set; }

        /// <summary>
        /// Gets or sets the description of the role.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether the role is active or not.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the date when the role is created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that has created the role.
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the role is updated.
        /// </summary>
        public DateTime DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that has updated the role.
        /// </summary>
        public int UpdatedBy { get; set; }

        #endregion Properties

        #region Relations

        /// <summary>
        /// Gets or sets the user instance that has created this.
        /// </summary>
        public virtual User CreatedByUser { get; set; }

        /// <summary>
        /// Gets or sets the user instance that has updated this.
        /// </summary>
        public virtual User UpdatedByUser { get; set; }

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