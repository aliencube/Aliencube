using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the user role.
    /// </summary>
    public partial class UserRoleTypeConfiguration : EntityTypeConfiguration<UserRole>
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

            this.Property(p => p.IsGranted).IsRequired();
            this.Property(p => p.DateGranted).IsRequired();

            //  Sets the relation between UserRole and User.
            this.HasRequired(p => p.User)
                .WithMany(p => p.UserRoles)
                .HasForeignKey(p => p.UserId)
                .WillCascadeOnDelete();

            //  Sets the relation between UserRole and Role.
            this.HasRequired(p => p.Role)
                .WithMany(p => p.UserRoles)
                .HasForeignKey(p => p.RoleId)
                .WillCascadeOnDelete();

            //  Sets the relation between UserRole and User that has granted this.
            this.HasRequired(p => p.GrantedByUser)
                .WithMany(p => p.UserRoles)
                .HasForeignKey(p => p.GrantedBy)
                .WillCascadeOnDelete();
        }

        #endregion Constructors
    }
}