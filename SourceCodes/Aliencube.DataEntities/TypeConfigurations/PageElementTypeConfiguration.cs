using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the page element.
    /// </summary>
    public partial class PageElementTypeConfiguration : EntityTypeConfiguration<PageElement>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the PageElementTypeConfiguration class.
        /// </summary>
        public PageElementTypeConfiguration()
        {
            //  Sets the PK on PageElementId.
            this.HasKey(p => p.PageElementId);
            //  Sets the auto increment and identity on PageElementId.
            this.Property(p => p.PageElementId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Value).IsOptional().HasMaxLength(null);

            //  Sets the relation between PageElement and ElementSchema.
            this.HasRequired(p => p.ElementSchema)
                .WithMany(p => p.PageElements)
                .HasForeignKey(p => p.ElementSchemaId)
                .WillCascadeOnDelete();

            //  Sets the relation between PageElement and PageVersion.
            this.HasRequired(p => p.PageVersion)
                .WithMany(p => p.PageElements)
                .HasForeignKey(p => p.PageVersionId)
                .WillCascadeOnDelete();
        }

        #endregion Constructors
    }
}