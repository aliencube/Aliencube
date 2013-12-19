using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the page.
    /// </summary>
    public partial class PageTypeConfiguration : EntityTypeConfiguration<Page>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the PageTypeConfiguration class.
        /// </summary>
        public PageTypeConfiguration()
        {
            //  Sets the PK on PageId.
            this.HasKey(p => p.PageId);
            //  Sets the auto increment and identity on PageId.
            this.Property(p => p.PageId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.PageHierarchy).IsRequired().HasMaxLength(256);
            this.Property(p => p.IsRoot).IsRequired();
            this.Property(p => p.SortOrder).IsRequired();

            //  Sets the relation between Page and PageSchema.
            this.HasRequired(p => p.PageSchema)
                .WithMany(p => p.Pages)
                .HasForeignKey(p => p.PageSchemaId)
                .WillCascadeOnDelete();
        }

        #endregion Constructors
    }
}