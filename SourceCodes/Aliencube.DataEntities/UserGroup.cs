using System;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the entity of a group assigned to a user.
    /// </summary>
    public partial class UserGroup
    {
        #region Properties

        /// <summary>
        /// Gets or sets the user group ID.
        /// </summary>
        public int UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the user Id which this belongs to.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the group Id which this belongs to.
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether the user group is granted or not.
        /// </summary>
        public bool IsGranted { get; set; }

        /// <summary>
        /// Gets or sets the date when the group is granted to the user.
        /// </summary>
        public DateTime DateGranted { get; set; }

        /// <summary>
        /// Gets or sets the user Id that has granted the user to the group.
        /// </summary>
        public int GrantedBy { get; set; }

        #endregion Properties

        #region Relations

        /// <summary>
        /// Gets or sets the user instance.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or sets the group instance.
        /// </summary>
        public virtual Group Group { get; set; }

        /// <summary>
        /// Gets or sets the user instance that has granted this.
        /// </summary>
        public virtual User GrantedBy { get; set; }

        #endregion Relations
    }
}