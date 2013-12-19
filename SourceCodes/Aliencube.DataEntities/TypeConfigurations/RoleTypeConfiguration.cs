﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the role type.
    /// </summary>
    public partial class RoleTypeConfiguration : EntityTypeConfiguration<Role>
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

            this.Property(p => p.DisplayName).IsRequired().HasMaxLength(128);
            this.Property(p => p.StronglyTypedName).IsRequired().HasMaxLength(128);
            this.Property(p => p.Description).IsOptional().HasMaxLength(null);
            this.Property(p => p.IsActive).IsRequired();
            this.Property(p => p.DateCreated).IsRequired();
            this.Property(p => p.DateUpdated).IsRequired();

            //  Sets the relation between Role and User that has created this.
            this.HasRequired(p => p.CreatedByUser)
                .WithMany(p => p.Roles)
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete();

            //  Sets the relation between Role and User that has updated this.
            this.HasRequired(p => p.UpdatedByUser)
                .WithMany(p => p.Roles)
                .HasForeignKey(p => p.UpdatedBy)
                .WillCascadeOnDelete();
        }

        #endregion Constructors
    }
}