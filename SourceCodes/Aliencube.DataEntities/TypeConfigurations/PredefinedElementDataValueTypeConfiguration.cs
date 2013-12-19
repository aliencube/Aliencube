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
    /// This represents the configuration entity for the pre-defined element data value.
    /// </summary>
    public partial class PredefinedElementDataValueTypeConfiguration : EntityTypeConfiguration<PredefinedElementDataValue>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the PredefinedElementDataValueTypeConfiguration class.
        /// </summary>
        public PredefinedElementDataValueTypeConfiguration()
        {
            //  Sets the PK on PredefinedElementDataValueId.
            this.HasKey(p => p.PredefinedElementDataValueId);
            //  Sets the auto increment and identity on PredefinedElementDataValueId.
            this.Property(p => p.PredefinedElementDataValueId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Key).IsRequired();
            this.Property(p => p.Value).IsRequired();
            this.Property(p => p.SortOrder).IsRequired();
            this.Property(p => p.DateCreated).IsRequired();
            this.Property(p => p.DateUpdated).IsRequired();

            //  Sets the relation between PredefinedElementDataValue and ElementSchema.
            this.HasRequired(p => p.ElementSchema)
                .WithMany(p => p.PredefinedElementDataValues)
                .HasForeignKey(p => p.ElementSchemaId)
                .WillCascadeOnDelete();

            //  Sets the relation between PredefinedElementDataValue and User that has created this.
            this.HasRequired(p => p.CreatedByUser)
                .WithMany(p => p.PredefinedElementDataValues)
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete();

            //  Sets the relation between PredefinedElementDataValue and User that has updated this.
            this.HasRequired(p => p.UpdatedByUser)
                .WithMany(p => p.PredefinedElementDataValues)
                .HasForeignKey(p => p.UpdatedBy)
                .WillCascadeOnDelete();
        }

        #endregion
    }
}
