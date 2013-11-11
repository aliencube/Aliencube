using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the page type entity.
    /// </summary>
    public class PageTypeConfiguration : EntityTypeConfiguration<Page>
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
            this.Property(p => p.IsPublished).IsRequired();

            this.Property(p => p.DatePublished).IsOptional();
            this.Property(p => p.PublishedBy).IsOptional();
            this.Property(p => p.DateUpdated).IsOptional();
            this.Property(p => p.UpdatedBy).IsOptional();
        }

        #endregion Constructors
    }
}