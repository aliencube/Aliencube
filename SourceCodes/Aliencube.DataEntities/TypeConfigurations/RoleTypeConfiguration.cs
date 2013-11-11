using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the role type entity.
    /// </summary>
    public class RoleTypeConfiguration : EntityTypeConfiguration<Role>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the RoleTypeConfiguration class.
        /// </summary>
        public RoleTypeConfiguration()
        {
            //  Sets the PK on RoleId.
            this.HasKey(p => p.RoleId);
            //  Sets the auto increment and identity on RoleId.
            this.Property(p => p.RoleId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.RoleName).IsRequired().HasMaxLength(128);
            this.Property(p => p.RoleDescription).IsRequired();
            this.Property(p => p.IsActive).IsRequired();
            this.Property(p => p.DateCreated).IsRequired();
            this.Property(p => p.CreatedBy).IsRequired();
            this.Property(p => p.DateUpdated).IsRequired();
            this.Property(p => p.UpdatedBy).IsRequired();
        }

        #endregion Constructors
    }
}