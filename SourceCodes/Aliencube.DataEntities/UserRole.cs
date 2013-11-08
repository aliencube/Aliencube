using System;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the entity of a role assigned to a user.
    /// </summary>
    public class UserRole
    {
        /// <summary>
        /// Gets or sets the user role ID.
        /// </summary>
        public int UserRoleId { get; set; }

        /// <summary>
        /// Gets or sets the user ID that the user role belongs to.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the role ID that the user role belongs to.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether the user role is granted or not.
        /// </summary>
        public bool IsGranted { get; set; }

        /// <summary>
        /// Gets or sets the date when the role is assigned to the user.
        /// </summary>
        public DateTime DateAssigned { get; set; }

        /// <summary>
        /// Gets or sets the user ID that has assigned the user to the role.
        /// </summary>
        public int AssignedBy { get; set; }
    }
}