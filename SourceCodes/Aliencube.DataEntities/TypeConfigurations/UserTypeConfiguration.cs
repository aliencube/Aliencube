using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the user.
    /// </summary>
    public partial class UserTypeConfiguration : EntityTypeConfiguration<User>
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
            this.Property(p => p.Password).IsRequired().HasMaxLength(128);
            this.Property(p => p.Email).IsRequired().HasMaxLength(256);
            this.Property(p => p.DateCreated).IsRequired();
            this.Property(p => p.DateUpdated).IsRequired();
            this.Property(p => p.IsVerified).IsRequired();
            this.Property(p => p.DateVerified).IsOptional();

            //  Sets the relation between PredefinedElementDataValue and User that has created this.
            this.HasRequired(p => p.CreatedByUser)
                .WithMany(p => p.Users)
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete();

            //  Sets the relation between PredefinedElementDataValue and User that has updated this.
            this.HasRequired(p => p.UpdatedByUser)
                .WithMany(p => p.Users)
                .HasForeignKey(p => p.UpdatedBy)
                .WillCascadeOnDelete();

            //  Sets the relation between PredefinedElementDataValue and User that has verified this.
            this.HasRequired(p => p.VerifiedByUser)
                .WithMany(p => p.Users)
                .HasForeignKey(p => p.VerifiedBy)
                .WillCascadeOnDelete();
        }

        #endregion Constructors
    }
}