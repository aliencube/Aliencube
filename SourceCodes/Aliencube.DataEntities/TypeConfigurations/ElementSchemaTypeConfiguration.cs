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
    /// This represents the configuration entity for the element schema.
    /// </summary>
    public partial class ElementSchemaTypeConfiguration : EntityTypeConfiguration<ElementSchema>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the ElementSchemaTypeConfiguration class.
        /// </summary>
        public ElementSchemaTypeConfiguration()
        {
            //  Sets the PK on ElementSchemaId.
            this.HasKey(p => p.ElementSchemaId);
            //  Sets the auto increment and identity on ElementSchemaId.
            this.Property(p => p.ElementSchemaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.DisplayName).IsRequired().HasMaxLength(128);
            this.Property(p => p.StronglyTypedName).IsRequired().HasMaxLength(128);
            this.Property(p => p.Description).IsOptional().HasMaxLength(null);
            this.Property(p => p.IsRequired).IsRequired();
            this.Property(p => p.ValidationRule).IsOptional().HasMaxLength(null);
            this.Property(p => p.SortOrder).IsRequired();
            this.Property(p => p.DateCreated).IsRequired();
            this.Property(p => p.DateUpdated).IsRequired();

            //  Sets the relation between ElementSchema and ElementDataType.
            this.HasRequired(p => p.ElementDataType)
                .WithMany(p => p.ElementSchemata)
                .HasForeignKey(p => p.ElementDataTypeId)
                .WillCascadeOnDelete();

            //  Sets the relation between ElementSchema and ElementGroup.
            this.HasRequired(p => p.ElementGroup)
                .WithMany(p => p.ElementSchemata)
                .HasForeignKey(p => p.ElementGroupId)
                .WillCascadeOnDelete();

            //  Sets the relation between ElementSchema and User that has created this.
            this.HasRequired(p => p.CreatedByUser)
                .WithMany(p => p.ElementSchemata)
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete();

            //  Sets the relation between ElementSchema and User that has updated this.
            this.HasRequired(p => p.UpdatedByUser)
                .WithMany(p => p.ElementSchemata)
                .HasForeignKey(p => p.UpdatedBy)
                .WillCascadeOnDelete();
        }

        #endregion
    }
}
