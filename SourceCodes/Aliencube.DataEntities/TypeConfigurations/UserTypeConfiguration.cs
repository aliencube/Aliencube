using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the user type entity.
    /// </summary>
    public class UserTypeConfiguration : EntityTypeConfiguration<User>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the UserTypeConfiguration class.
        /// </summary>
        public UserTypeConfiguration()
        {
            //  Sets the PK on UserId.
            this.HasKey(p => p.UserId);
            //  Sets the auto increment and identity on UserId.
            this.Property(p => p.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Username).IsRequired().HasMaxLength(128);
            this.Property(p => p.Password).IsRequired().HasMaxLength(256);
            this.Property(p => p.Email).IsRequired().HasMaxLength(256);
            this.Property(p => p.DateCreated).IsRequired();
            this.Property(p => p.CreatedBy).IsRequired();
            this.Property(p => p.DateUpdated).IsRequired();
            this.Property(p => p.UpdatedBy).IsRequired();

            this.Property(p => p.IsVerified).IsRequired();
            this.Property(p => p.DateVerified).IsOptional();
            this.Property(p => p.VerifiedBy).IsOptional();

            this.Property(p => p.IsSuspended).IsRequired();
            this.Property(p => p.DateSuspended).IsOptional();
            this.Property(p => p.SuspendedBy).IsOptional();
        }

        #endregion Constructors
    }
}