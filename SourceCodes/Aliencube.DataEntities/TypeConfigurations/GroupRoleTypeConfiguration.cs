using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the group role.
    /// </summary>
    public partial class GroupRoleTypeConfiguration : EntityTypeConfiguration<GroupRole>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the GroupRoleTypeConfiguration class.
        /// </summary>
        public GroupRoleTypeConfiguration()
        {
            //  Sets the PK on GroupRoleId.
            this.HasKey(p => p.GroupRoleId);
            //  Sets the auto increment and identity on GroupRoleId.
            this.Property(p => p.GroupRoleId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.IsGranted).IsRequired();
            this.Property(p => p.DateGranted).IsRequired();

            //  Sets the relation between GroupRole and Group.
            this.HasRequired(p => p.Group)
                .WithMany(p => p.GroupRoles)
                .HasForeignKey(p => p.GroupId)
                .WillCascadeOnDelete();

            //  Sets the relation between GroupRole and Role.
            this.HasRequired(p => p.Role)
                .WithMany(p => p.GroupRoles)
                .HasForeignKey(p => p.RoleId)
                .WillCascadeOnDelete();

            //  Sets the relation between GroupRole and User that has granted this.
            this.HasRequired(p => p.GrantedByUser)
                .WithMany(p => p.GroupRoles)
                .HasForeignKey(p => p.GrantedBy)
                .WillCascadeOnDelete();
        }

        #endregion Constructors
    }
}