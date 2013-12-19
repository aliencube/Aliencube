using System;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the entity of a role assigned to a user.
    /// </summary>
    public partial class UserRole
    {
        #region Properties

        /// <summary>
        /// Gets or sets the user role ID.
        /// </summary>
        public int UserRoleId { get; set; }

        /// <summary>
        /// Gets or sets the user Id which this belongs to.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the role Id which this belongs to.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether the user role is granted or not.
        /// </summary>
        public bool IsGranted { get; set; }

        /// <summary>
        /// Gets or sets the date when the role is granted to the user.
        /// </summary>
        public DateTime DateGranted { get; set; }

        /// <summary>
        /// Gets or sets the user Id that has granted the user to the role.
        /// </summary>
        public int GrantedBy { get; set; }

        #endregion Properties

        #region Relations

        /// <summary>
        /// Gets or sets the user instance.
        /// </summary>
        public virtual User User { get; set; }

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