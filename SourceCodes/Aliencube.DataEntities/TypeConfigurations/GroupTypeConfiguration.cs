using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the group.
    /// </summary>
    public partial class GroupTypeConfiguration : EntityTypeConfiguration<Group>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the GroupTypeConfiguration class.
        /// </summary>
        public GroupTypeConfiguration()
        {
            //  Sets the PK on GroupId.
            this.HasKey(p => p.GroupId);
            //  Sets the auto increment and identity on GroupId.
            this.Property(p => p.GroupId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.DisplayName).IsRequired().HasMaxLength(128);
            this.Property(p => p.StronglyTypedName).IsRequired().HasMaxLength(128);
            this.Property(p => p.Description).IsOptional().HasMaxLength(null);
            this.Property(p => p.IsActive).IsRequired();
            this.Property(p => p.DateCreated).IsRequired();
            this.Property(p => p.DateUpdated).IsRequired();

            //  Sets the relation between Group and User that has created this.
            this.HasRequired(p => p.CreatedByUser)
                .WithMany(p => p.Groups)
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete();

            //  Sets the relation between Group and User that has updated this.
            this.HasRequired(p => p.UpdatedByUser)
                .WithMany(p => p.Groups)
                .HasForeignKey(p => p.UpdatedBy)
                .WillCascadeOnDelete();
        }

        #endregion
    }
}
