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
    /// This represents the configuration entity for the element group.
    /// </summary>
    public partial class ElementGroupTypeConfiguration : EntityTypeConfiguration<ElementGroup>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the ElementGroupTypeConfiguration class.
        /// </summary>
        public ElementGroupTypeConfiguration()
        {
            //  Sets the PK on ElementGroupId.
            this.HasKey(p => p.ElementGroupId);
            //  Sets the auto increment and identity on ElementGroupId.
            this.Property(p => p.ElementGroupId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.DisplayName).IsRequired().HasMaxLength(128);
            this.Property(p => p.StronglyTypedName).IsRequired().HasMaxLength(128);
            this.Property(p => p.Description).IsOptional().HasMaxLength(null);
            this.Property(p => p.SortOrder).IsRequired();
            this.Property(p => p.DateCreated).IsRequired();
            this.Property(p => p.DateUpdated).IsRequired();

            //  Sets the relation between ElementGroup and PageSchema.
            this.HasRequired(p => p.PageSchema)
                .WithMany(p => p.ElementGroups)
                .HasForeignKey(p => p.PageSchemaId)
                .WillCascadeOnDelete();

            //  Sets the relation between ElementGroup and User that has created this.
            this.HasRequired(p => p.CreatedByUser)
                .WithMany(p => p.ElementGroups)
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete();

            //  Sets the relation between ElementGroup and User that has updated this.
            this.HasRequired(p => p.UpdatedByUser)
                .WithMany(p => p.ElementGroups)
                .HasForeignKey(p => p.UpdatedBy)
                .WillCascadeOnDelete();
        }

        #endregion
    }
}
