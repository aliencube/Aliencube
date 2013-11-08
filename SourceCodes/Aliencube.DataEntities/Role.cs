using System;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the entity of a role for a user.
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Gets or sets the role ID.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the role name.
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets the role description.
        /// </summary>
        public string RoleDescription { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether the role is active or not.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the date when the role is created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the user ID that has created the role.
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the role is updated.
        /// </summary>
        public DateTime DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the user ID that has updated the role.
        /// </summary>
        public int UpdatedBy { get; set; }
    }
}