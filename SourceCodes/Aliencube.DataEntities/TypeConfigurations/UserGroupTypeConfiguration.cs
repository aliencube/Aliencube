using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the user group.
    /// </summary>
    public partial class UserGroupTypeConfiguration : EntityTypeConfiguration<UserGroup>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the UserGroupTypeConfiguration class.
        /// </summary>
        public UserGroupTypeConfiguration()
        {
            //  Sets the PK on UserGroupId.
            this.HasKey(p => p.UserGroupId);
            //  Sets the auto increment and identity on UserGroupId.
            this.Property(p => p.UserGroupId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.IsGranted).IsRequired();
            this.Property(p => p.DateGranted).IsRequired();

            //  Sets the relation between UserGroup and User.
            this.HasRequired(p => p.User)
                .WithMany(p => p.UserGroups)
                .HasForeignKey(p => p.UserId)
                .WillCascadeOnDelete();

            //  Sets the relation between UserGroup and Group.
            this.HasRequired(p => p.Group)
                .WithMany(p => p.UserGroups)
                .HasForeignKey(p => p.GroupId)
                .WillCascadeOnDelete();

            //  Sets the relation between UserGroup and User that has granted this.
            this.HasRequired(p => p.GrantedByUser)
                .WithMany(p => p.UserGroups)
                .HasForeignKey(p => p.GrantedBy)
                .WillCascadeOnDelete();
        }

        #endregion Constructors
    }
}