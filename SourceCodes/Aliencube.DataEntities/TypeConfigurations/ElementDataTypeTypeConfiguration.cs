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
    /// This represents the configuration entity for the element data type.
    /// </summary>
    public partial class ElementDataTypeTypeConfiguration : EntityTypeConfiguration<ElementDataType>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the ElementDataTypeTypeConfiguration class.
        /// </summary>
        public ElementDataTypeTypeConfiguration()
        {
            //  Sets the PK on ElementDataTypeId.
            this.HasKey(p => p.ElementDataTypeId);
            //  Sets the auto increment and identity on ElementDataTypeId.
            this.Property(p => p.ElementDataTypeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.DataType).IsRequired().HasMaxLength(32);
            this.Property(p => p.Description).IsOptional().HasMaxLength(null);
            this.Property(p => p.DateCreated).IsRequired();
            this.Property(p => p.DateUpdated).IsRequired();

            //  Sets the relation between ElementDataType and User that has created this.
            this.HasRequired(p => p.CreatedByUser)
                .WithMany(p => p.ElementDataTypes)
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete();

            //  Sets the relation between ElementDataType and User that has updated this.
            this.HasRequired(p => p.UpdatedByUser)
                .WithMany(p => p.ElementDataTypes)
                .HasForeignKey(p => p.UpdatedBy)
                .WillCascadeOnDelete();
        }

        #endregion
    }
}
