using System;
using System.Collections.Generic;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the entity of a group for a user.
    /// </summary>
    public partial class Group
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique Id representing a group.
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// Gets or sets the name to be displayed.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the name when to generate a strongly typed object as a property.
        /// </summary>
        public string StronglyTypedName { get; set; }

        /// <summary>
        /// Gets or sets the description of the group.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether the group is active or not.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the date when the group is created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that has created the group.
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the group is updated.
        /// </summary>
        public DateTime DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that has updated the group.
        /// </summary>
        public int UpdatedBy { get; set; }

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
        /// Gets or sets the list of user-group instances.
        /// </summary>
        public virtual ICollection<UserGroup> UserGroups { get; set; }

        /// <summary>
        /// Gets or sets the list of group-role instances.
        /// </summary>
        public virtual ICollection<GroupRole> GroupRoles { get; set; }

        #endregion Relations
    }
}