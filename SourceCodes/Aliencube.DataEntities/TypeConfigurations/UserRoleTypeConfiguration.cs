using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the page type entity.
    /// </summary>
    public class UserRoleTypeConfiguration : EntityTypeConfiguration<UserRole>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the UserRoleTypeConfiguration class.
        /// </summary>
        public UserRoleTypeConfiguration()
        {
            //  Sets the PK on UserRoleId.
            this.HasKey(p => p.UserRoleId);
            //  Sets the auto increment and identity on UserRoleId.
            this.Property(p => p.UserRoleId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //this.Property(p => p.UserId).IsRequired();
            //this.Property(p => p.RoleId).IsRequired();

            this.Property(p => p.IsGranted).IsRequired();
            this.Property(p => p.DateAssigned).IsRequired();
            this.Property(p => p.AssignedBy).IsRequired();

            //  Sets the relation between User and UserRole.
            this.HasRequired(p => p.User)
                .WithMany(p => p.UserRoles)
                .HasForeignKey(p => p.UserId)
                .WillCascadeOnDelete();

            //  Sets the relation between Role and UserRole.
            this.HasRequired(p => p.Role)
                .WithMany(p => p.UserRoles)
                .HasForeignKey(p => p.RoleId)
                .WillCascadeOnDelete();
        }

        #endregion Constructors
    }
}