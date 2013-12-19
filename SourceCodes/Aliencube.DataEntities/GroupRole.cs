using System;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the entity of a role assigned to a group.
    /// </summary>
    public partial class GroupRole
    {
        #region Properties

        /// <summary>
        /// Gets or sets the group role ID.
        /// </summary>
        public int GroupRoleId { get; set; }

        /// <summary>
        /// Gets or sets the group Id which this belongs to.
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// Gets or sets the role Id which this belongs to.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether the group role is granted or not.
        /// </summary>
        public bool IsGranted { get; set; }

        /// <summary>
        /// Gets or sets the date when the role is granted to the group.
        /// </summary>
        public DateTime DateGranted { get; set; }

        /// <summary>
        /// Gets or sets the group Id that has granted the group to the role.
        /// </summary>
        public int GrantedBy { get; set; }

        #endregion Properties

        #region Relations

        /// <summary>
        /// Gets or sets the group instance.
        /// </summary>
        public virtual Group Group { get; set; }

        /// <summary>
        /// Gets or sets the role instance.
        /// </summary>
        public virtual Role Role { get; set; }

        /// <summary>
        /// Gets or sets the user instance that has granted this.
        /// </summary>
        public virtual User GrantedByUser { get; set; }

        #endregion Relations
    }
}